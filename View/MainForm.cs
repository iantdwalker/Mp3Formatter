using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using Mp3Formatter.Formatting;
using Mp3Formatter.Model;

namespace Mp3Formatter.View
{
	/// <summary>
	/// MainForm for the MP3 Formatter application.
	/// 1. Format a single or folder of MP3s according to the format specified.
	/// 2. Manual override to set either a single MP3 tag manually or every MP3 tag manually.
	/// 3. Additional idea to tab GUI and have a table view where we can query the album folders
	/// by a Comments tag value and display the results. For example, comments set to New to find
	/// albums not yet listened to.
	/// </summary>
	public partial class MainForm : Form
	{
		#region Private Members

		private string		_currentMp3File;
		private string		_currentMp3FolderPath;
		private IFormatter	_formatter;

		#endregion

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="MainForm"/> class.
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			_currentMp3File					= string.Empty;
			_currentMp3FolderPath			= string.Empty;
			_formatter						= new Formatter(this);
			_comboBoxGenre.DataSource		= Mp3TagModel.ID3v1Genres;
			_comboBoxGenre.SelectedItem		= Mp3TagModel.ID3v1Genres[0];
			_comboBoxGenre.DropDownStyle	= ComboBoxStyle.DropDown;
		}

		#endregion

		#region Public Helper Methods

		/// <summary>
		/// Prints the output message.
		/// </summary>
		/// <param name="message">The message.</param>
		public void PrintOutputMessage(string message)
		{			
			if (!string.IsNullOrEmpty(_richTextBoxOutput.Text))
			{
				_richTextBoxOutput.Text = string.Format("{0}\n{1}", new object[] { _richTextBoxOutput.Text, message });
			}
			else
			{
				_richTextBoxOutput.Text = message;
			}
		}

		#endregion

		#region Event Handlers

		/// <summary>
		/// Handles the CheckedChanged event of the _radioButtonSingle control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _radioButtonSingle_CheckedChanged(object sender, EventArgs e)
		{
			if (_radioButtonSingle.Checked)
			{
				_checkBoxRecursive.Enabled = false;
			}
		}

		/// <summary>
		/// Handles the CheckedChanged event of the _radioButtonMulti control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _radioButtonMulti_CheckedChanged(object sender, EventArgs e)
		{
			if (_radioButtonMulti.Checked)
			{
				_checkBoxRecursive.Enabled = true;
			}
		}
		
		/// <summary>
		/// Handles the Click event of the _buttonOpen control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _buttonOpen_Click(object sender, EventArgs e)
		{
			try
			{
				if (_radioButtonSingle.Checked)
				{			
					OpenFileDialog openFileDialog	= new OpenFileDialog();
					openFileDialog.Multiselect		= true;
					openFileDialog.Title			= "Please select an MP3 file to format.";
					openFileDialog.Filter			= "MP3 files (*.mp3)|*.mp3";
			
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						_currentMp3File			= openFileDialog.FileName;
						_textBoxPath.Text		= _currentMp3File;
						_buttonProcess.Enabled	= true;
					}
					else
					{
						if (_textBoxPath.Text == string.Empty)
						{
							_buttonProcess.Enabled	= false;
						}
					}

					openFileDialog.Dispose();
					openFileDialog = null;
				}
				else if (_radioButtonMulti.Enabled)
				{
					FolderBrowserDialog selectFolderDialog	= new FolderBrowserDialog();
					selectFolderDialog.Description			= "Please select a folder or album of MP3 files to format.";
					selectFolderDialog.ShowNewFolderButton	= true;
					
					if (_currentMp3FolderPath != string.Empty)
					{
						selectFolderDialog.SelectedPath = _currentMp3FolderPath;
					}
				
					if (selectFolderDialog.ShowDialog() == DialogResult.OK)
					{
						_currentMp3FolderPath	= selectFolderDialog.SelectedPath;
						_textBoxPath.Text		= _currentMp3FolderPath;
						_buttonProcess.Enabled	= true;
					}
					else
					{
						if (_textBoxPath.Text == string.Empty)
						{
							_buttonProcess.Enabled	= false;
						}
					}

					selectFolderDialog.Dispose();
					selectFolderDialog = null;
				}
			}
			catch (Exception ex)
			{
				_formatter.HandleException(ex);
			}
		}

		/// <summary>
		/// Handles the TextChanged event of the _textBoxPath control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _textBoxPath_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(_textBoxPath.Text))
			{
				_buttonProcess.Enabled = false;
			}
		}

		/// <summary>
		/// Handles the Click event of the _buttonProcess control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _buttonProcess_Click(object sender, EventArgs e)
		{
			try
			{
				PrintOutputMessage("*************START***************\n");
				_progressBar.Value								= 0;
				this.Cursor										= Cursors.WaitCursor;
				IMp3FormatterOptions	mp3FormatterOptions		= GetFormattingOptions();			
				int						readExceptionsCounter	= 0;

				if ((_radioButtonSingle.Checked) && (!string.IsNullOrEmpty(_currentMp3File)))
				{
					PrintOutputMessage("Running in single mode...\n");
					IMp3TagModel mp3TagModel = new Mp3TagModel();
					
					if (_checkBoxManualOverride.Checked)
					{					
						SetManualOverrideValues(mp3TagModel, mp3FormatterOptions);
					}

					_progressBar.Value = 50;
				
					IFormatterStatus formatterStatus = _formatter.ProcessMp3(_currentMp3File, mp3TagModel, mp3FormatterOptions);
					if (formatterStatus.ReadExceptions)
					{
						readExceptionsCounter++;
					}

					//update the currently displayed file name
					_textBoxPath.Text	= formatterStatus.NewFileName;
					_currentMp3File		= formatterStatus.NewFileName;

					_progressBar.Value = 100;
				}
				else if ((_radioButtonMulti.Checked) && (!string.IsNullOrEmpty(_currentMp3FolderPath)))
				{
					PrintOutputMessage("Running in multi mode...");
					string[] files;
				
					if ((_checkBoxRecursive.Enabled) && (_checkBoxRecursive.Checked))
					{				
						PrintOutputMessage("Checking root and all child directories...");
						files = Directory.GetFiles(_currentMp3FolderPath, "*.mp3", SearchOption.AllDirectories);
					}
					else
					{
						PrintOutputMessage("Checking root directory only...");
						files = Directory.GetFiles(_currentMp3FolderPath, "*.mp3", SearchOption.TopDirectoryOnly);
					}

					PrintOutputMessage(string.Format("There are {0} mp3 files to process in total.\n", files.Length));
					IMp3TagModel mp3TagModel;

					int percentageIncrement = 100 / files.Length;
					for (int x = 0; x < files.Length; x++)
					{
						_currentMp3File = files[x];
						mp3TagModel		= new Mp3TagModel();

						if (_checkBoxManualOverride.Checked)
						{
							SetManualOverrideValues(mp3TagModel, mp3FormatterOptions);
						}
						
						IFormatterStatus formatterStatus = _formatter.ProcessMp3(_currentMp3File, mp3TagModel, mp3FormatterOptions);
						if (formatterStatus.ReadExceptions)
						{
							readExceptionsCounter++;
						}
						
						PrintOutputMessage(string.Format("There are {0} mp3 files left to process.\n", files.Length-(x+1)));
						_progressBar.Value = _progressBar.Value + percentageIncrement;
					}
				}
				
				PrintOutputMessage("*************FINISH***************");

				if ((_checkBoxPopupConfirmation.Checked) && (readExceptionsCounter == 0))
				{
					MessageBox.Show(this, "Processing of the selected MP3 file(s) is complete.", "Processing Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else if ((_checkBoxPopupConfirmation.Checked) && (readExceptionsCounter != 0))
				{
					MessageBox.Show(this, "Processing of the selected MP3 file(s) is complete. Some non-fatal read errors have occurred. Please see log output window for further information.", "Processing Complete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}				
			}
			catch (Exception ex)
			{
				_formatter.HandleException(ex);
				if (_checkBoxPopupError.Checked)
				{
					MessageBox.Show(this, "An error has occurred and processing may not have completed for all files. Please check the output log window for the error details.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				_progressBar.Value = 0;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		/// <summary>
		/// Handles the CheckedChanged event of the _radioButtonID3v1 control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _radioButtonID3v1_CheckedChanged(object sender, EventArgs e)
		{
			_comboBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		/// <summary>
		/// Handles the CheckedChanged event of the _radioButtonID3v2 control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _radioButtonID3v2_CheckedChanged(object sender, EventArgs e)
		{
			_comboBoxGenre.DropDownStyle = ComboBoxStyle.DropDown;
		}

		/// <summary>
		/// Handles the Click event of the _buttonClearOutput control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _buttonClearOutput_Click(object sender, EventArgs e)
		{
			_richTextBoxOutput.Text = string.Empty;
			_progressBar.Value		= 0;
		}

		/// <summary>
		/// Handles the Click event of the _buttonClearTags control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _buttonClearTags_Click(object sender, EventArgs e)
		{
			_textBoxFileName.Text		= string.Empty;
			_textBoxTrackNumber.Text	= string.Empty;
			_textBoxTitle.Text			= string.Empty;
			_textBoxAlbum.Text			= string.Empty;
			_textBoxArtist.Text			= string.Empty;
			_textBoxComments.Text		= string.Empty;
			_comboBoxGenre.SelectedItem	= Mp3TagModel.ID3v1Genres[0];
			_textBoxYear.Text			= string.Empty;			
		}

		/// <summary>
		/// Handles the Click event of the _buttonReloadDictionary control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _buttonReloadDictionary_Click(object sender, EventArgs e)
		{
			try
			{
				_formatter.LoadDictionary();
				MessageBox.Show(this, "The XML dictionary has been reloaded successfully.", "Reload Dictionary", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				_formatter.HandleException(ex);
				MessageBox.Show(this, "An error has occurred reloading the XML dictionary. Please check the output log window for the error details.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
		}
		
		/// <summary>
		/// Handles the Click event of the _buttonClose control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _buttonClose_Click(object sender, EventArgs e)
		{
			if (DialogResult.Yes == MessageBox.Show(this, "Are you sure you wish to exit the application?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
			{
				this.Close();
			}
		}		

		#region Manual Override Checkbox Logic

		/// <summary>
		/// Handles the CheckedChanged event of the _checkBoxManualOverride control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _checkBoxManualOverride_CheckedChanged(object sender, EventArgs e)
		{
			if (_checkBoxManualOverride.Checked)
			{
				_radioButtonSetIndividually.Enabled	= true;
				_radioButtonSetAll.Enabled			= true;
				_checkBoxAutoFormat.Enabled			= true;
				
				if (_radioButtonSetAll.Checked)
				{
					ChangeCheckBoxEnabledStates(true);
					ChangeCheckBoxCheckedStates(true);
				}
				else if (_radioButtonSetIndividually.Checked)
				{
					ChangeCheckBoxEnabledStates(true);
				}
			}
			else
			{
				_radioButtonSetIndividually.Enabled	= false;
				_radioButtonSetAll.Enabled			= false;
				_checkBoxAutoFormat.Enabled			= false;
				
				ChangeCheckBoxEnabledStates(false);
				ChangeCheckBoxCheckedStates(false);
			}
		}

		/// <summary>
		/// Handles the CheckedChanged event of the _radioButtonSetIndividually control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _radioButtonSetIndividually_CheckedChanged(object sender, EventArgs e)
		{
			if (_radioButtonSetIndividually.Checked)
			{
				ChangeCheckBoxCheckedStates(false);
				ChangeCheckBoxEnabledStates(true);
			}			
		}

		/// <summary>
		/// Handles the CheckedChanged event of the _radioButtonSetAll control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _radioButtonSetAll_CheckedChanged(object sender, EventArgs e)
		{
			if (_radioButtonSetAll.Checked)
			{
				ChangeCheckBoxEnabledStates(true);
				ChangeCheckBoxCheckedStates(true);
			}
		}		

		/// <summary>
		/// Handles the CheckedChanged event of the _checkBoxFileName control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _checkBoxFileName_CheckedChanged(object sender, EventArgs e)
		{
			if (_checkBoxFileName.Checked)
			{
				_textBoxFileName.Enabled = true;
			}
			else
			{
				_textBoxFileName.Enabled = false;
			}
		}

		/// <summary>
		/// Handles the CheckedChanged event of the _checkBoxTrackNumber control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _checkBoxTrackNumber_CheckedChanged(object sender, EventArgs e)
		{
			if (_checkBoxTrackNumber.Checked)
			{
				_textBoxTrackNumber.Enabled = true;
			}
			else
			{
				_textBoxTrackNumber.Enabled = false;
			}
		}

		/// <summary>
		/// Handles the CheckedChanged event of the _checkBoxTitle control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _checkBoxTitle_CheckedChanged(object sender, EventArgs e)
		{
			if (_checkBoxTitle.Checked)
			{
				_textBoxTitle.Enabled = true;
			}
			else
			{
				_textBoxTitle.Enabled = false;
			}
		}

		/// <summary>
		/// Handles the CheckedChanged event of the _checkBoxAlbum control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _checkBoxAlbum_CheckedChanged(object sender, EventArgs e)
		{
			if (_checkBoxAlbum.Checked)
			{				
				_textBoxAlbum.Enabled = true;
			}
			else
			{
				_textBoxAlbum.Enabled = false;
			}
		}

		/// <summary>
		/// Handles the CheckedChanged event of the _checkBoxArtist control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _checkBoxArtist_CheckedChanged(object sender, EventArgs e)
		{
			if (_checkBoxArtist.Checked)
			{				
				_textBoxArtist.Enabled = true;
			}
			else
			{
				_textBoxArtist.Enabled = false;
			}
		}

		/// <summary>
		/// Handles the CheckedChanged event of the _checkBoxComments control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _checkBoxComments_CheckedChanged(object sender, EventArgs e)
		{
			if (_checkBoxComments.Checked)
			{				
				_textBoxComments.Enabled = true;
			}
			else
			{
				_textBoxComments.Enabled = false;
			}
		}

		/// <summary>
		/// Handles the CheckedChanged event of the _checkBoxGenre control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _checkBoxGenre_CheckedChanged(object sender, EventArgs e)
		{
			if (_checkBoxGenre.Checked)
			{			
				_comboBoxGenre.Enabled = true;
			}
			else
			{
				_comboBoxGenre.Enabled = false;
			}
		}

		/// <summary>
		/// Handles the CheckedChanged event of the _checkBoxYear control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void _checkBoxYear_CheckedChanged(object sender, EventArgs e)
		{
			if (_checkBoxYear.Checked)
			{				
				_textBoxYear.Enabled = true;
			}
			else
			{
				_textBoxYear.Enabled = false;
			}
		}

		#endregion

		#endregion

		#region Private Helper Methods

		private ID3Version SelectId3Version()
		{
			if (_radioButtonID3v1.Checked)
			{
				return ID3Version.ID3v1;
			}
			else if (_radioButtonID3v2.Checked)
			{
				return ID3Version.ID3v2;
			}

			throw new InvalidOperationException("The method SelectId3Version has not been updated with new ID3 tag versions.");
		} 
		
		private DesiredFileNameOutputFormat SelectDesiredFileNameOutputFormat()
		{
			if (_radioButtonDesiredFileNameFormat1.Checked)
			{
				return DesiredFileNameOutputFormat.DesiredFileNameOutputFormat1;
			}
			else if (_radioButtonDesiredFileNameFormat2.Checked)
			{
				return DesiredFileNameOutputFormat.DesiredFileNameOutputFormat2;
			}
			else if (_radioButtonDesiredFileNameFormat3.Checked)
			{
				return DesiredFileNameOutputFormat.DesiredFileNameOutputFormat3;
			}
			else if (_radioButtonDesiredFileNameFormat4.Checked)
			{
				return DesiredFileNameOutputFormat.DesiredFileNameOutputFormat4;
			}
			else if (_radioButtonDesiredFileNameFormat5.Checked)
			{
				return DesiredFileNameOutputFormat.DesiredFileNameOutputFormat5;
			}

			throw new InvalidOperationException("The method SelectDesiredFileNameOutputFormat() has not been updated with new track formats.");
		}

		private FileNameTitleOptions SelectFileNameTitleOption()
		{
			if (_radioButtonUseTitleAsNewFileNameUseNewFileNameAsTitle.Checked)
			{
				return FileNameTitleOptions.UseTitleAsNewFileNameUseNewFileNameAsTitle;
			}
			else if (_radioButtonUseOriginalFileNameAndTitle.Checked)
			{
				return FileNameTitleOptions.UseOriginalFileNameAndTitle;
			}
			else if (_radioButtonUseOriginalFileNameAsTitle.Checked)
			{
				return FileNameTitleOptions.UseOriginalFileNameAsTitle;
			}
			else if (_radioButtonUseTitleAsNewFileName.Checked)
			{
				return FileNameTitleOptions.UseTitleAsNewFileName;
			}

			throw new InvalidOperationException("The method SelectFileNameTitleOption() has not been updated with new File Name/Title options.");
		}

		private void SetManualOverrideValues(IMp3TagModel mp3TagModel, IMp3FormatterOptions mp3FormatterOptions)
		{
			if (_checkBoxAutoFormat.Enabled)
			{
				mp3FormatterOptions.AutoFormatTags = _checkBoxAutoFormat.Checked;
			}

			PopulateMp3TagModel(mp3TagModel);
		}
		
		private void PopulateMp3TagModel(IMp3TagModel mp3TagModel)
		{
			if ((_checkBoxFileName.Enabled) && (_checkBoxFileName.Checked) && (_textBoxFileName.Enabled))
			{
				mp3TagModel.FileName = _textBoxFileName.Text;
			}

			if ((_checkBoxTrackNumber.Enabled) && (_checkBoxTrackNumber.Checked) && (_textBoxTrackNumber.Enabled))
			{
				mp3TagModel.TrackNumber = _textBoxTrackNumber.Text;
			}

			if ((_checkBoxTitle.Enabled) && (_checkBoxTitle.Checked) && (_textBoxTitle.Enabled))
			{
				mp3TagModel.Title = _textBoxTitle.Text;
			}

			if ((_checkBoxAlbum.Enabled) && (_checkBoxAlbum.Checked) && (_textBoxAlbum.Enabled))
			{
				mp3TagModel.Album = _textBoxAlbum.Text;
			}

			if ((_checkBoxArtist.Enabled) && (_checkBoxArtist.Checked) && (_textBoxArtist.Enabled))
			{
				mp3TagModel.Artist = _textBoxArtist.Text;
			}

			if ((_checkBoxComments.Enabled) && (_checkBoxComments.Checked) && (_textBoxComments.Enabled))
			{
				mp3TagModel.Comments = _textBoxComments.Text;
			}

			if ((_checkBoxGenre.Enabled) && (_checkBoxGenre.Checked) && (_comboBoxGenre.Enabled))
			{
				mp3TagModel.Genre = _comboBoxGenre.Text;
			}

			if ((_checkBoxYear.Enabled) && (_checkBoxYear.Checked) && (_textBoxYear.Enabled))
			{
				mp3TagModel.Year = _textBoxYear.Text;
			}
		}	
		
		/// <summary>
		/// Changes the check box enabled states.
		/// </summary>
		/// <param name="enabled">if set to <c>true</c> [enabled].</param>
		private void ChangeCheckBoxEnabledStates(bool enabled)
		{
			_checkBoxFileName.Enabled		= enabled;
			_checkBoxTrackNumber.Enabled	= enabled;
			_checkBoxTitle.Enabled			= enabled;
			_checkBoxAlbum.Enabled			= enabled;
			_checkBoxArtist.Enabled			= enabled;
			_checkBoxComments.Enabled		= enabled;
			_checkBoxGenre.Enabled			= enabled;
			_checkBoxYear.Enabled			= enabled;
		}

		/// <summary>
		/// Changes the check box checked states.
		/// </summary>
		/// <param name="check">if set to <c>true</c> [check].</param>
		private void ChangeCheckBoxCheckedStates(bool check)
		{
			_checkBoxFileName.Checked		= check;
			_checkBoxTrackNumber.Checked	= check;
			_checkBoxTitle.Checked			= check;
			_checkBoxAlbum.Checked			= check;
			_checkBoxArtist.Checked			= check;
			_checkBoxComments.Checked		= check;
			_checkBoxGenre.Checked			= check;
			_checkBoxYear.Checked			= check;
		}

		private IMp3FormatterOptions GetFormattingOptions()
		{
			IMp3FormatterOptions mp3FormatterOptions			= new Mp3FormatterOptions();
			
			mp3FormatterOptions.ID3Version						= SelectId3Version();
			mp3FormatterOptions.DesiredFileNameOutputFormat		= SelectDesiredFileNameOutputFormat();
			mp3FormatterOptions.FileNameTitleOption				= SelectFileNameTitleOption();
			mp3FormatterOptions.PrefixZero						= _checkBoxPrefix0.Checked;
			mp3FormatterOptions.UpperCaseAfterBrackets			= _checkBoxBrackets.Checked;
			mp3FormatterOptions.UpperCaseAfterUnderscore		= _checkBoxUnderscore.Checked;
			mp3FormatterOptions.ReplaceUnderscoreWithSpace		= _checkBoxReplaceUnderscoreWithSpace.Checked;
			mp3FormatterOptions.UseDictionaryXML				= _checkBoxUseDictionaryXml.Checked;
			mp3FormatterOptions.AutoFormatOriginalFileName		= _checkBoxAutoFormatOriginalFileName.Checked;

			return mp3FormatterOptions;
		}

		#endregion				
	}
}
