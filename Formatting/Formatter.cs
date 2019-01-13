using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;

using HundredMilesSoftware.UltraID3Lib;

using Mp3Formatter.Model;
using Mp3Formatter.View;

namespace Mp3Formatter.Formatting
{
	/// <summary>
	/// Formatter provides MP3 formatting and processing methods
	/// for the application.
	/// </summary>
	public class Formatter : IFormatter
	{
		#region Private Members

		private MainForm	_mainForm;
		private IDictionary _dictionary;
		private char[]		_invalidFileNameChars;		

		#endregion
		
		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="Formatter"/> class.
		/// </summary>
		/// <param name="mainForm">The main form.</param>
		public Formatter(MainForm mainForm)
		{
			if (mainForm == null) throw new ArgumentNullException("mainForm");
			_mainForm				= mainForm;
			_invalidFileNameChars	= Path.GetInvalidFileNameChars();			
		}

		#endregion

		#region IFormatter Members

		/// <summary>
		/// Processes the MP3 file specified.
		/// </summary>
		/// <param name="mp3File">The MP3 file.</param>
		/// <param name="mp3TagModel">The MP3 tag model.</param>
		/// <param name="mp3FormatterOptions">The MP3 formatter options.</param>
		/// <returns></returns>
		public IFormatterStatus ProcessMp3(string mp3File, IMp3TagModel mp3TagModel, IMp3FormatterOptions mp3FormatterOptions)
		{
			if (string.IsNullOrEmpty(mp3File))	throw new ArgumentNullException("mp3File");
			if (mp3TagModel			== null)	throw new ArgumentNullException("mp3TagModel");
			if (mp3FormatterOptions == null)	throw new ArgumentNullException("mp3FormatterOptions");
			
			_mainForm.PrintOutputMessage("Processing a new MP3 file:");
			_mainForm.PrintOutputMessage(mp3File);

			IFormatterStatus	formatterStatus = new FormatterStatus();
			UltraID3			ultraID3		= new UltraID3();			
			bool				readComplete	= false;			

			try
			{			
				ultraID3.Read(mp3File);
				_mainForm.PrintOutputMessage("MP3 file read completed OK.");
				formatterStatus.ReadExceptions		= CheckForReadExceptions(ultraID3);
				FileInfo file						= new FileInfo(mp3File);
				formatterStatus.OriginalFileName	= file.Name.Substring(0, file.Name.LastIndexOf(".mp3", StringComparison.InvariantCultureIgnoreCase));
				readComplete						= true;

				//load dictionary
				if ((mp3FormatterOptions.UseDictionaryXML) && (_dictionary == null))
				{
					LoadDictionary();
				}
				
				//format MP3 tags
				FormatTrackNumber(ultraID3, mp3TagModel.TrackNumber, mp3FormatterOptions);
				FormatTitle(ultraID3, mp3TagModel.Title, mp3FormatterOptions);
				FormatAlbum(ultraID3, mp3TagModel.Album, mp3FormatterOptions);
				FormatArtist(ultraID3, mp3TagModel.Artist, mp3FormatterOptions);
				FormatComments(ultraID3, mp3TagModel.Comments, mp3FormatterOptions);
				FormatGenre(ultraID3, mp3TagModel.Genre, mp3FormatterOptions);
				FormatYear(ultraID3, mp3TagModel.Year, mp3FormatterOptions);
										
				//format File Name
				string formattedFileName = FormatFileName(ultraID3, formatterStatus.OriginalFileName, mp3TagModel.FileName, mp3FormatterOptions);

				if ((mp3FormatterOptions.FileNameTitleOption == FileNameTitleOptions.UseTitleAsNewFileNameUseNewFileNameAsTitle) ||
					(mp3FormatterOptions.FileNameTitleOption == FileNameTitleOptions.UseOriginalFileNameAsTitle))
				{
					//update the track Title once again with the formatted File Name
					if (mp3FormatterOptions.ID3Version == ID3Version.ID3v1)
					{
						ultraID3.ID3v1Tag.Title = formattedFileName;
						_mainForm.PrintOutputMessage(string.Format("Formatted MP3 Title is: '{0}'", ultraID3.ID3v1Tag.Title));
					}
					else if (mp3FormatterOptions.ID3Version == ID3Version.ID3v2)
					{
						ultraID3.ID3v2Tag.Title = formattedFileName;
						_mainForm.PrintOutputMessage(string.Format("Formatted MP3 Title is: '{0}'", ultraID3.ID3v2Tag.Title));
					}
				}
				
				//commit the changes
				ultraID3.Write();
				_mainForm.PrintOutputMessage("MP3 tag updates completed OK.");

				//rename the file
				formatterStatus.NewFileName = RenameMP3File(formattedFileName, mp3File);				
			}
			catch (Exception ex) 
			{
				throw new FormatterException("An exception occurred while processing an MP3 file.", ex);				
			}
			finally
			{
				if (readComplete)
				{
					ultraID3.Clear();					
				}
				ultraID3 = null;
			}

			return formatterStatus;
		}

		/// <summary>
		/// Handles the exception.
		/// </summary>
		/// <param name="ex">The ex.</param>
		public void HandleException(Exception ex)
		{			
			_mainForm.PrintOutputMessage("****ERROR****");
			_mainForm.PrintOutputMessage(ex.GetType().ToString());
			_mainForm.PrintOutputMessage(ex.Message);
			_mainForm.PrintOutputMessage(ex.StackTrace);
				
			if (ex.InnerException != null)
			{
				_mainForm.PrintOutputMessage("Inner Exception:");
				_mainForm.PrintOutputMessage(ex.InnerException.GetType().ToString());
				_mainForm.PrintOutputMessage(ex.InnerException.Message);
				_mainForm.PrintOutputMessage(ex.InnerException.StackTrace);
			}
		}

		/// <summary>
		/// Loads the dictionary.
		/// </summary>
		public void LoadDictionary()
		{
			XmlDocument xmlDictionary		= new XmlDocument();				
			string		xmlDictionaryPath	= new FileInfo(Assembly.GetExecutingAssembly().Location).DirectoryName;
						xmlDictionaryPath	= string.Format("{0}\\Resources\\Dictionary.xml", xmlDictionaryPath);
			
			xmlDictionary.Load(xmlDictionaryPath);
			
						_dictionary			= new Dictionary();
			XmlNode		replacementsNode	= xmlDictionary.SelectSingleNode("Dictionary/Replacements");

			foreach (XmlNode childNode in replacementsNode.ChildNodes)
			{
				if (childNode.Name == "Replacement")
				{
					IReplacement replacement = new Replacement(childNode.Attributes["before"].Value,
						 childNode.Attributes["after"].Value,
						 childNode.Attributes["replacementType"].Value);
					_dictionary.Replacements.Add(replacement);
				}
			}
		}

		#endregion

		#region Private Methods
		
		/// <summary>
		/// Checks for read exceptions.
		/// </summary>
		/// <param name="ultraID3">The ultra Id3 object.</param>
		private bool CheckForReadExceptions(UltraID3 ultraID3)
		{
			ID3MetaDataException[] readExceptions = ultraID3.GetExceptions();
			if (readExceptions.Length > 0)
			{
				_mainForm.PrintOutputMessage(string.Format("{0} non-fatal read exceptions have occurred.", readExceptions.Length.ToString(CultureInfo.CurrentCulture)));
				foreach (ID3MetaDataException metaDataException in readExceptions)
				{
					HandleException(metaDataException);
				}
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// Formats the track number.
		/// </summary>
		/// <param name="ultraID3">The ultra Id3.</param>
		/// <param name="manualOverrideTrackNumber">The manual override track number.</param>
		/// <param name="mp3FormatterOptions">The MP3 formatter options.</param>
		private void FormatTrackNumber(UltraID3 ultraID3, string manualOverrideTrackNumber, IMp3FormatterOptions mp3FormatterOptions)
		{
			if (mp3FormatterOptions.ID3Version == ID3Version.ID3v1)
			{			
				if (manualOverrideTrackNumber != Mp3TagModel.TAG_NOT_SET)
				{
					ultraID3.ID3v1Tag.SetTrackNum(manualOverrideTrackNumber);
				}

				_mainForm.PrintOutputMessage(string.Format("Formatted MP3 Track Number is: '{0}'", ultraID3.ID3v1Tag.TrackNum.ToString()));
			}
			else if (mp3FormatterOptions.ID3Version == ID3Version.ID3v2)
			{
				if (manualOverrideTrackNumber != Mp3TagModel.TAG_NOT_SET)
				{
					ultraID3.ID3v2Tag.SetTrackNum(manualOverrideTrackNumber);
				}

				_mainForm.PrintOutputMessage(string.Format("Formatted MP3 Track Number is: '{0}'", ultraID3.ID3v2Tag.TrackNum.ToString()));
			}		
		}

		/// <summary>
		/// Formats the title.
		/// </summary>
		/// <param name="ultraID3">The ultra Id3.</param>
		/// <param name="manualOverrideTitle">The manual override title.</param>
		/// <param name="mp3FormatterOptions">The MP3 formatter options.</param>
		private void FormatTitle(UltraID3 ultraID3, string manualOverrideTitle, IMp3FormatterOptions mp3FormatterOptions)
		{
			if (mp3FormatterOptions.ID3Version == ID3Version.ID3v1)
			{
				if (manualOverrideTitle != Mp3TagModel.TAG_NOT_SET)
				{
					ultraID3.ID3v1Tag.Title = manualOverrideTitle;
					if (mp3FormatterOptions.AutoFormatTags)
					{
						ultraID3.ID3v1Tag.Title = AutoFormatText(ultraID3.ID3v1Tag.Title, mp3FormatterOptions);
					}
				}
				else
				{
					ultraID3.ID3v1Tag.Title = AutoFormatText(ultraID3.ID3v1Tag.Title, mp3FormatterOptions);
				}

				_mainForm.PrintOutputMessage(string.Format("Formatted MP3 Title is: '{0}'", ultraID3.ID3v1Tag.Title));
			}
			else if (mp3FormatterOptions.ID3Version == ID3Version.ID3v2)
			{
				if (manualOverrideTitle != Mp3TagModel.TAG_NOT_SET)
				{
					ultraID3.ID3v2Tag.Title = manualOverrideTitle;
					if (mp3FormatterOptions.AutoFormatTags)
					{
						ultraID3.ID3v2Tag.Title = AutoFormatText(ultraID3.ID3v2Tag.Title, mp3FormatterOptions);
					}
				}
				else
				{
					ultraID3.ID3v2Tag.Title = AutoFormatText(ultraID3.ID3v2Tag.Title, mp3FormatterOptions);
				}

				_mainForm.PrintOutputMessage(string.Format("Formatted MP3 Title is: '{0}'", ultraID3.ID3v2Tag.Title));
			}
		}

		/// <summary>
		/// Formats the album.
		/// </summary>
		/// <param name="ultraID3">The ultra Id3.</param>
		/// <param name="manualOverrideAlbum">The manual override album.</param>
		/// <param name="mp3FormatterOptions">The MP3 formatter options.</param>
		private void FormatAlbum(UltraID3 ultraID3, string manualOverrideAlbum, IMp3FormatterOptions mp3FormatterOptions)
		{
		    if (mp3FormatterOptions.ID3Version == ID3Version.ID3v1)
			{
				if (manualOverrideAlbum != Mp3TagModel.TAG_NOT_SET)
				{
					ultraID3.ID3v1Tag.Album = manualOverrideAlbum;
					if (mp3FormatterOptions.AutoFormatTags)
					{
						ultraID3.ID3v1Tag.Album = AutoFormatText(ultraID3.ID3v1Tag.Album, mp3FormatterOptions);
					}
				}
				else
				{
					ultraID3.ID3v1Tag.Album = AutoFormatText(ultraID3.ID3v1Tag.Album, mp3FormatterOptions);
				}
			
				_mainForm.PrintOutputMessage(string.Format("Formatted MP3 Album is: '{0}'", ultraID3.ID3v1Tag.Album));
			}
			else if (mp3FormatterOptions.ID3Version == ID3Version.ID3v2)
			{
				if (manualOverrideAlbum != Mp3TagModel.TAG_NOT_SET)
				{
					ultraID3.ID3v2Tag.Album = manualOverrideAlbum;
					if (mp3FormatterOptions.AutoFormatTags)
					{
						ultraID3.ID3v2Tag.Album = AutoFormatText(ultraID3.ID3v2Tag.Album, mp3FormatterOptions);
					}
				}
				else
				{
					ultraID3.ID3v2Tag.Album = AutoFormatText(ultraID3.ID3v2Tag.Album, mp3FormatterOptions);
				}
			
				_mainForm.PrintOutputMessage(string.Format("Formatted MP3 Album is: '{0}'", ultraID3.ID3v2Tag.Album));
			}
		}

		/// <summary>
		/// Formats the artist.
		/// </summary>
		/// <param name="ultraID3">The ultra Id3.</param>
		/// <param name="manualOverrideArtist">The manual override artist.</param>
		/// <param name="mp3FormatterOptions">The MP3 formatter options.</param>
		private void FormatArtist(UltraID3 ultraID3, string manualOverrideArtist, IMp3FormatterOptions mp3FormatterOptions)
		{
		    if (mp3FormatterOptions.ID3Version == ID3Version.ID3v1)
			{
				if (manualOverrideArtist != Mp3TagModel.TAG_NOT_SET)
				{
					ultraID3.ID3v1Tag.Artist = manualOverrideArtist;
					if (mp3FormatterOptions.AutoFormatTags)
					{
						ultraID3.ID3v1Tag.Artist = AutoFormatText(ultraID3.ID3v1Tag.Artist, mp3FormatterOptions);
					}
				}
				else
				{
					ultraID3.ID3v1Tag.Artist = AutoFormatText(ultraID3.ID3v1Tag.Artist, mp3FormatterOptions);
				}
			
				_mainForm.PrintOutputMessage(string.Format("Formatted MP3 Artist is: '{0}'", ultraID3.ID3v1Tag.Artist));
			}
			else if (mp3FormatterOptions.ID3Version == ID3Version.ID3v2)
			{
				if (manualOverrideArtist != Mp3TagModel.TAG_NOT_SET)
				{
					ultraID3.ID3v2Tag.Artist = manualOverrideArtist;
					if (mp3FormatterOptions.AutoFormatTags)
					{
						ultraID3.ID3v2Tag.Artist = AutoFormatText(ultraID3.ID3v2Tag.Artist, mp3FormatterOptions);
					}
				}
				else
				{
					ultraID3.ID3v2Tag.Artist = AutoFormatText(ultraID3.ID3v2Tag.Artist, mp3FormatterOptions);
				}
			
				_mainForm.PrintOutputMessage(string.Format("Formatted MP3 Artist is: '{0}'", ultraID3.ID3v2Tag.Artist));
			}
		}

		/// <summary>
		/// Formats the comments.
		/// </summary>
		/// <param name="ultraID3">The ultra Id3.</param>
		/// <param name="manualOverrideComments">The manual override comments.</param>
		/// <param name="mp3FormatterOptions">The MP3 formatter options.</param>
		private void FormatComments(UltraID3 ultraID3, string manualOverrideComments, IMp3FormatterOptions mp3FormatterOptions)
		{
		    //set the comments value for both ID3v1Tag and ID3v2Tag tag as string.empty is ignored
			if (mp3FormatterOptions.ID3Version == ID3Version.ID3v1)
			{
				if (manualOverrideComments != Mp3TagModel.TAG_NOT_SET)
				{
					ultraID3.ID3v1Tag.Comments = manualOverrideComments;
					ultraID3.ID3v2Tag.Comments = manualOverrideComments;
					if (mp3FormatterOptions.AutoFormatTags)
					{
						ultraID3.ID3v1Tag.Comments = AutoFormatText(ultraID3.ID3v1Tag.Comments, mp3FormatterOptions);
						ultraID3.ID3v2Tag.Comments = AutoFormatText(ultraID3.ID3v2Tag.Comments, mp3FormatterOptions);
					}
				}
				else
				{
					ultraID3.ID3v1Tag.Comments = string.Empty;
					ultraID3.ID3v2Tag.Comments = string.Empty;
				}
			
				_mainForm.PrintOutputMessage(string.Format("Formatted MP3 ID3v1 Comments is: '{0}'", ultraID3.ID3v1Tag.Comments));
				_mainForm.PrintOutputMessage(string.Format("Formatted MP3 ID3v2 Comments is: '{0}'", ultraID3.ID3v2Tag.Comments));
			}
			else if (mp3FormatterOptions.ID3Version == ID3Version.ID3v2)
			{
				if (manualOverrideComments != Mp3TagModel.TAG_NOT_SET)
				{
					ultraID3.ID3v1Tag.Comments = manualOverrideComments;
					ultraID3.ID3v2Tag.Comments = manualOverrideComments;
					if (mp3FormatterOptions.AutoFormatTags)
					{
						ultraID3.ID3v1Tag.Comments = AutoFormatText(ultraID3.ID3v1Tag.Comments, mp3FormatterOptions);
						ultraID3.ID3v2Tag.Comments = AutoFormatText(ultraID3.ID3v2Tag.Comments, mp3FormatterOptions);
					}
				}
				else
				{
					ultraID3.ID3v1Tag.Comments = string.Empty;
					ultraID3.ID3v2Tag.Comments = string.Empty;
				}
			
				_mainForm.PrintOutputMessage(string.Format("Formatted MP3 ID3v1 Comments is: '{0}'", ultraID3.ID3v1Tag.Comments));
				_mainForm.PrintOutputMessage(string.Format("Formatted MP3 ID3v2 Comments is: '{0}'", ultraID3.ID3v2Tag.Comments));
			}
		}

		/// <summary>
		/// Formats the genre.
		/// </summary>
		/// <param name="ultraID3">The ultra Id3.</param>
		/// <param name="manualOverrideGenre">The manual override genre.</param>
		/// <param name="mp3FormatterOptions">The MP3 formatter options.</param>
		private void FormatGenre(UltraID3 ultraID3, string manualOverrideGenre, IMp3FormatterOptions mp3FormatterOptions)
		{
		    if (mp3FormatterOptions.ID3Version == ID3Version.ID3v1)
			{
				if (manualOverrideGenre != Mp3TagModel.TAG_NOT_SET)
				{
					ultraID3.ID3v1Tag.SetGenre(manualOverrideGenre);
				}
				else
				{
					ultraID3.ID3v1Tag.SetGenre(AutoFormatText(ultraID3.ID3v1Tag.GenreName, mp3FormatterOptions));
				}

				_mainForm.PrintOutputMessage(string.Format("Formatted MP3 Genre is: '{0}'", ultraID3.ID3v1Tag.GenreName));
			}
			else if (mp3FormatterOptions.ID3Version == ID3Version.ID3v2)
			{
				if (manualOverrideGenre != Mp3TagModel.TAG_NOT_SET)
				{
					ultraID3.ID3v2Tag.Genre = manualOverrideGenre;
				}
				else
				{
					ultraID3.ID3v2Tag.Genre = AutoFormatText(ultraID3.ID3v2Tag.Genre, mp3FormatterOptions);
				}

				_mainForm.PrintOutputMessage(string.Format("Formatted MP3 Genre is: '{0}'", ultraID3.ID3v2Tag.Genre));
			}
		}

		/// <summary>
		/// Formats the year.
		/// </summary>
		/// <param name="ultraID3">The ultra Id3.</param>
		/// <param name="manualOverrideYear">The manual override year.</param>
		/// <param name="mp3FormatterOptions">The MP3 formatter options.</param>
		private void FormatYear(UltraID3 ultraID3, string manualOverrideYear, IMp3FormatterOptions mp3FormatterOptions)
		{
		    if (mp3FormatterOptions.ID3Version == ID3Version.ID3v1)
			{
				if (manualOverrideYear != Mp3TagModel.TAG_NOT_SET)
				{
					ultraID3.ID3v1Tag.SetYear(manualOverrideYear);
				}
					
				_mainForm.PrintOutputMessage(string.Format("Formatted MP3 Year is: '{0}'", ultraID3.ID3v1Tag.Year.ToString()));
			}
			else if (mp3FormatterOptions.ID3Version == ID3Version.ID3v2)
			{
				if (manualOverrideYear != Mp3TagModel.TAG_NOT_SET)
				{
					ultraID3.ID3v2Tag.SetYear(manualOverrideYear);
				}
					
				_mainForm.PrintOutputMessage(string.Format("Formatted MP3 Year is: '{0}'", ultraID3.ID3v2Tag.Year.ToString()));
			}
		}

		/// <summary>
		/// Formats the name of the file.
		/// </summary>
		/// <param name="ultraID3">The ultra Id3.</param>
		/// <param name="originalFileName">Name of the original file.</param>
		/// <param name="manualOverrideFileName">Name of the manual override file.</param>
		/// <param name="mp3FormatterOptions">The MP3 formatter options.</param>
		/// <returns></returns>
		private string FormatFileName(UltraID3 ultraID3, string originalFileName, string manualOverrideFileName, IMp3FormatterOptions mp3FormatterOptions)
		{
			string formattedFileName = string.Empty;
					
			if (manualOverrideFileName != Mp3TagModel.TAG_NOT_SET)
			{
			    formattedFileName = manualOverrideFileName;
				if (mp3FormatterOptions.AutoFormatTags)
				{
					formattedFileName = AutoFormatText(formattedFileName, mp3FormatterOptions);
				}
			}
			else
			{
				if (mp3FormatterOptions.DesiredFileNameOutputFormat != DesiredFileNameOutputFormat.DesiredFileNameOutputFormat5)
				{
					if (mp3FormatterOptions.ID3Version == ID3Version.ID3v1)
					{
						if ((mp3FormatterOptions.PrefixZero) && (ultraID3.ID3v1Tag.TrackNum < 10))
						{
							formattedFileName = string.Format("0{0}", ultraID3.ID3v1Tag.TrackNum.ToString());
						}
						else
						{
							formattedFileName = string.Format("{0}", ultraID3.ID3v1Tag.TrackNum.ToString());
						}	
					}
					else if (mp3FormatterOptions.ID3Version == ID3Version.ID3v2)
					{
						if ((mp3FormatterOptions.PrefixZero) && (ultraID3.ID3v2Tag.TrackNum < 10))
						{
							formattedFileName = string.Format("0{0}", ultraID3.ID3v2Tag.TrackNum.ToString());
						}
						else
						{
							formattedFileName = string.Format("{0}", ultraID3.ID3v2Tag.TrackNum.ToString());
						}
					}
				}
				
				if (mp3FormatterOptions.ID3Version == ID3Version.ID3v1)
				{
					if ((mp3FormatterOptions.FileNameTitleOption == FileNameTitleOptions.UseTitleAsNewFileNameUseNewFileNameAsTitle) ||
						(mp3FormatterOptions.FileNameTitleOption == FileNameTitleOptions.UseTitleAsNewFileName))
					{
						formattedFileName = ProcessTrackFormat(mp3FormatterOptions, formattedFileName, ultraID3.ID3v1Tag.Title);
					}
					else if ((mp3FormatterOptions.FileNameTitleOption == FileNameTitleOptions.UseOriginalFileNameAndTitle) ||
						(mp3FormatterOptions.FileNameTitleOption == FileNameTitleOptions.UseOriginalFileNameAsTitle))
					{
						if (mp3FormatterOptions.AutoFormatOriginalFileName)
						{
							originalFileName = AutoFormatText(originalFileName, mp3FormatterOptions);
						}
						formattedFileName = ProcessTrackFormat(mp3FormatterOptions, formattedFileName, originalFileName);
					}
				}
				else if (mp3FormatterOptions.ID3Version == ID3Version.ID3v2)
				{
					if ((mp3FormatterOptions.FileNameTitleOption == FileNameTitleOptions.UseTitleAsNewFileNameUseNewFileNameAsTitle) ||
						(mp3FormatterOptions.FileNameTitleOption == FileNameTitleOptions.UseTitleAsNewFileName))
					{
						formattedFileName = ProcessTrackFormat(mp3FormatterOptions, formattedFileName, ultraID3.ID3v2Tag.Title);
					}
					else if ((mp3FormatterOptions.FileNameTitleOption == FileNameTitleOptions.UseOriginalFileNameAndTitle) ||
						(mp3FormatterOptions.FileNameTitleOption == FileNameTitleOptions.UseOriginalFileNameAsTitle))
					{
						if (mp3FormatterOptions.AutoFormatOriginalFileName)
						{
							originalFileName = AutoFormatText(originalFileName, mp3FormatterOptions);
						}
						formattedFileName = ProcessTrackFormat(mp3FormatterOptions, formattedFileName, originalFileName);
					}
				}			
			}

			//remove any invalid chars from the file name
			for (int x = 0; x < _invalidFileNameChars.Length; x++)
			{
				if (formattedFileName.IndexOf(_invalidFileNameChars[x]) > -1)
				{
					formattedFileName = formattedFileName.Replace(_invalidFileNameChars[x].ToString(), "");
					formattedFileName = formattedFileName.Replace("  ", " ");
				}
			}

			_mainForm.PrintOutputMessage(string.Format("Formatted MP3 File Name is: '{0}'", formattedFileName));
			return formattedFileName;			
		}

		/// <summary>
		/// Processes the track format.
		/// </summary>
		/// <param name="mp3FormatterOptions">The MP3 formatter options.</param>
		/// <param name="formattedFileName">Name of the formatted file.</param>
		/// <param name="value">The value.</param>
		/// <returns></returns>
		private string ProcessTrackFormat(IMp3FormatterOptions mp3FormatterOptions, string formattedFileName, string value)
		{
			if (mp3FormatterOptions.DesiredFileNameOutputFormat == DesiredFileNameOutputFormat.DesiredFileNameOutputFormat1)
			{
				formattedFileName = string.Format("{0}-{1}", new object[] { formattedFileName, value });
			}
			else if (mp3FormatterOptions.DesiredFileNameOutputFormat == DesiredFileNameOutputFormat.DesiredFileNameOutputFormat2)
			{
				formattedFileName = string.Format("{0}.{1}", new object[] { formattedFileName, value });	
			}
			else if (mp3FormatterOptions.DesiredFileNameOutputFormat == DesiredFileNameOutputFormat.DesiredFileNameOutputFormat3)
			{
				formattedFileName = string.Format("{0} - {1}", new object[] { formattedFileName, value });	
			}
			else if (mp3FormatterOptions.DesiredFileNameOutputFormat == DesiredFileNameOutputFormat.DesiredFileNameOutputFormat4)
			{
				formattedFileName = string.Format("{0} {1}", new object[] { formattedFileName, value });	
			}
			else if (mp3FormatterOptions.DesiredFileNameOutputFormat == DesiredFileNameOutputFormat.DesiredFileNameOutputFormat5)
			{
				formattedFileName = value;
			}

			return formattedFileName;
		}

		/// <summary>
		/// Renames the Mp3 file.
		/// </summary>
		/// <param name="newFileName">New name of the file.</param>
		/// <param name="currentFileName">Name of the current file.</param>
		/// <returns></returns>
		private string RenameMP3File(string newFileName, string currentFileName)
		{
			FileInfo	fileInfo	= new FileInfo(currentFileName);			
						newFileName = string.Format("{0}\\{1}", new object[] { fileInfo.DirectoryName, newFileName });
						newFileName = string.Format("{0}.mp3", newFileName);

			File.Move(currentFileName, newFileName);
			_mainForm.PrintOutputMessage(string.Format("MP3 file has been successfully renamed to '{0}'.\n", newFileName));
			return newFileName;
		}

		/// <summary>
		/// Formats the text using the automatic formatting logic.
		/// </summary>
		/// <param name="beforeValue">The before value.</param>
		/// <param name="mp3FormatterOptions">The MP3 formatter options.</param>
		/// <returns></returns>
		private string AutoFormatText(string beforeValue, IMp3FormatterOptions mp3FormatterOptions)
		{
			beforeValue.Trim();
			beforeValue					= beforeValue.ToLower();
						
			//apply the dictionary WordSegment replacements
			if ((mp3FormatterOptions.UseDictionaryXML) && (_dictionary != null))
			{
				foreach (IReplacement replacement in _dictionary.Replacements)
				{
					if (replacement.ReplacementType == "WordSegment")
					{
						beforeValue = ReplaceString(beforeValue, replacement.Before, replacement.After, StringComparison.CurrentCultureIgnoreCase);
					}
				}
			}

			string[] beforeValueWords;
			
			if (mp3FormatterOptions.ReplaceUnderscoreWithSpace)
			{
				beforeValueWords = beforeValue.Split(new string[] { " ", "_" }, StringSplitOptions.RemoveEmptyEntries);
			}
			else
			{
				beforeValueWords = beforeValue.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);	
			}			
			
			string[] afterValueWords = new string[beforeValueWords.Length];

			for (int x = 0; x < beforeValueWords.Length; x++)
			{
				string beforeValueWord	= beforeValueWords[x];
				char[] letters			= beforeValueWord.ToCharArray();
				if (letters.Length > 0)
				{
					letters[0]	= char.ToUpper(letters[0], CultureInfo.CurrentCulture);
					
					//handle brackets
					if (mp3FormatterOptions.UpperCaseAfterBrackets)
					{
						if ((letters[0] == '(') || (letters[0] == '[') || (letters[0] == '{'))
						{
							if (letters.Length > 1)
							{
								letters[1]	= char.ToUpper(letters[1], CultureInfo.CurrentCulture);
							}
						}
					}

					//handle underscores - UpperCaseAfterUnderscore
					if (mp3FormatterOptions.UpperCaseAfterUnderscore)
					{
						if (beforeValueWord.Contains("_"))
						{
							int underscoreIndex = beforeValueWord.IndexOf("_");
							if (letters.Length > underscoreIndex)
							{
								letters[underscoreIndex+1] = char.ToUpper(letters[underscoreIndex+1], CultureInfo.CurrentCulture);
							}
						}
					}

					string afterValueWord	= new string(letters);
					afterValueWords[x]		= afterValueWord;					
				}
			}

			string afterValue = string.Join(" ", afterValueWords);
			
			//finally apply the dictionary FullWord replacements
			if ((mp3FormatterOptions.UseDictionaryXML) && (_dictionary != null))
			{
				foreach (IReplacement replacement in _dictionary.Replacements)
				{
					if (replacement.ReplacementType == "FullWord")
					{
						afterValue = ReplaceString(afterValue, replacement.Before, replacement.After, StringComparison.CurrentCultureIgnoreCase);
					}
				}
			}
			
			return afterValue;
		}

		/// <summary>
		/// Replaces the string.
		/// </summary>
		/// <param name="fullString">The full string.</param>
		/// <param name="beforeValue">The before value.</param>
		/// <param name="afterValue">The after value.</param>
		/// <param name="comparison">The comparison.</param>
		/// <returns></returns>
		private static string ReplaceString(string fullString, string beforeValue, string afterValue, StringComparison comparison)
		{
			StringBuilder	sb				= new StringBuilder();
			int				previousIndex	= 0;
			int				index			= fullString.IndexOf(beforeValue, comparison);
			
			while (index != -1)
			{
				sb.Append(fullString.Substring(previousIndex, index - previousIndex));
				sb.Append(afterValue);
				
				index			+= beforeValue.Length;
				previousIndex	= index;
				index			= fullString.IndexOf(beforeValue, index, comparison);
			}

			sb.Append(fullString.Substring(previousIndex));
			return sb.ToString();
		}

		#endregion
	}
}
