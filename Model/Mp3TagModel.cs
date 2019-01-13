using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HundredMilesSoftware.UltraID3Lib;

namespace Mp3Formatter.Model
{
	/// <summary>
	/// Mp3TagModel provides a model for ID3v1 MP3 tags.
	/// </summary>
	public class Mp3TagModel : IMp3TagModel
	{
		#region Private Members

		private static IList<string>	_genres;
		private string					_fileName;
		private string					_trackNumber;
		private string					_title;
		private string					_album;
		private string					_artist;
		private string					_comments;
		private string					_genre;
		private string					_year;

		#endregion

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="Mp3TagModel"/> class.
		/// </summary>
		public Mp3TagModel()
		{		
			_fileName		= TAG_NOT_SET;
			_trackNumber	= TAG_NOT_SET;
			_title			= TAG_NOT_SET;
			_album			= TAG_NOT_SET;
			_artist			= TAG_NOT_SET;
			_comments		= TAG_NOT_SET;
			_genre			= TAG_NOT_SET;
			_year			= TAG_NOT_SET;
		}

		#endregion

		#region Public Members

		/// <summary>
		/// TAG_NOT_SET is used to represent tags that are not required or set.
		/// </summary>
		public const string TAG_NOT_SET = "Mp3Formatter.Mp3TagModel.TAG_NOT_SET";		

		/// <summary>
		/// Gets the compatible genre values.
		/// </summary>
		/// <returns></returns>
		public static IList<string> ID3v1Genres
		{
			get
			{
				if (_genres == null)
				{
					UltraID3 ultraID3	= new UltraID3();
					_genres				= new List<string>();
					
					for (int x = 0; x < ultraID3.GenreInfos.Count; x++)
					{
						_genres.Add(ultraID3.GenreInfos[x].Name);
					}

					ultraID3 = null;
				}
			
				return _genres;
			}
		}

		#endregion
		
		#region IMp3TagModel Members
					
		/// <summary>
		/// Gets or sets the name of the file.
		/// </summary>
		/// <value>The name of the file.</value>
		public string FileName
		{
			get
			{
				return _fileName;
			}
			set
			{
				_fileName = value;
			}
		}

		/// <summary>
		/// Gets or sets the track number.
		/// </summary>
		/// <value>The track number.</value>
		public string TrackNumber
		{
			get
			{
				return _trackNumber;
			}
			set
			{
				_trackNumber = value;
			}
		}

		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
		public string Title
		{
			get
			{
				return _title;
			}
			set
			{
				_title = value;
			}
		}

		/// <summary>
		/// Gets or sets the album.
		/// </summary>
		/// <value>The album.</value>
		public string Album
		{
			get
			{
				return _album;
			}
			set
			{
				_album = value;
			}
		}

		/// <summary>
		/// Gets or sets the artist.
		/// </summary>
		/// <value>The artist.</value>
		public string Artist
		{
			get
			{
				return _artist;
			}
			set
			{
				_artist = value;
			}
		}

		/// <summary>
		/// Gets or sets the comments.
		/// </summary>
		/// <value>The comments.</value>
		public string Comments
		{
			get
			{
				return _comments;
			}
			set
			{
				_comments = value;
			}
		}

		/// <summary>
		/// Gets or sets the genre.
		/// </summary>
		/// <value>The genre.</value>
		public string Genre
		{
			get
			{
				return _genre;
			}
			set
			{
				_genre = value;
			}
		}

		/// <summary>
		/// Gets or sets the year.
		/// </summary>
		/// <value>The year.</value>
		public string Year
		{
			get
			{
				return _year;
			}
			set
			{
				_year = value;
			}
		}

		#endregion
	}
}
