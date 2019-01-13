using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mp3Formatter.Formatting
{
	/// <summary>
	/// Mp3FormatterOptions provides MP3 formatting options.
	/// </summary>
	public class Mp3FormatterOptions : IMp3FormatterOptions
	{
		#region Private Members

		private ID3Version						_id3TagVersion;
		private DesiredFileNameOutputFormat		_desiredFileNameOutputFormat;
		private FileNameTitleOptions			_fileNameTitleOption;
		private bool							_autoFormatTags;
		private bool							_prefixZero;
		private bool							_upperCaseAfterBrackets;
		private bool							_upperCaseAfterUnderscore;
		private bool							_replaceUnderscoreWithSpace;
		private bool							_useDictionaryXML;
		private bool							_autoFormatOriginalFileName;

		#endregion

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="Mp3FormatterOptions"/> class.
		/// </summary>
		public Mp3FormatterOptions()
		{
			_id3TagVersion					= ID3Version.ID3v2;
			_desiredFileNameOutputFormat	= DesiredFileNameOutputFormat.DesiredFileNameOutputFormat1;
			_fileNameTitleOption			= FileNameTitleOptions.UseTitleAsNewFileNameUseNewFileNameAsTitle;
			_autoFormatTags					= false;
			_prefixZero						= false;
			_upperCaseAfterBrackets			= false;
			_upperCaseAfterUnderscore		= false;
			_replaceUnderscoreWithSpace		= false;
			_useDictionaryXML				= false;
			_autoFormatOriginalFileName		= false;
		}

		#endregion
		
		#region IMp3FormatterOptions Members

		/// <summary>
		/// Gets or sets the ID3 tag version to update.
		/// </summary>
		/// <value>The ID3 version.</value>
		public ID3Version ID3Version
		{
			get
			{
				return _id3TagVersion;
			}

			set
			{
				_id3TagVersion = value;
			}
		}

		/// <summary>
		/// Gets or sets the desired file name output format.
		/// </summary>
		/// <value>The desired file name output format.</value>
		public DesiredFileNameOutputFormat DesiredFileNameOutputFormat
		{
			get
			{
				return _desiredFileNameOutputFormat;
			}
			set
			{
				_desiredFileNameOutputFormat = value;
			}
		}

		/// <summary>
		/// Gets or sets the file name title option.
		/// </summary>
		/// <value>The file name title option.</value>
		public FileNameTitleOptions FileNameTitleOption
		{
			get
			{
				return _fileNameTitleOption;
			}

			set
			{
				_fileNameTitleOption = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether or not to auto format the manual override tags.
		/// </summary>
		/// <value><c>true</c> if [auto format tags]; otherwise, <c>false</c>.</value>
		public bool AutoFormatTags
		{
			get
			{
				return _autoFormatTags;
			}
			set
			{
				_autoFormatTags = value;
			}
		}
		
		/// <summary>
		/// Gets or sets a value indicating whether track numbers 1-9 should be prefixed with 0.
		/// </summary>
		/// <value><c>true</c> if prefix0; otherwise, <c>false</c>.</value>
		public bool PrefixZero
		{
			get
			{
				return _prefixZero;
			}
			set
			{
				_prefixZero = value;
			}
		}		
		
		/// <summary>
		/// Gets or sets a value indicating whether or not to set the next character to uppercase after a bracket (, [ or {
		/// </summary>
		/// <value>
		/// 	<c>true</c> if [upper case after brackets]; otherwise, <c>false</c>.
		/// </value>
		public bool UpperCaseAfterBrackets
		{
			get
			{
				return _upperCaseAfterBrackets;
			}
			set
			{
				_upperCaseAfterBrackets = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [upper case after underscore].
		/// </summary>
		/// <value>
		/// 	<c>true</c> if [upper case after underscore]; otherwise, <c>false</c>.
		/// </value>
		public bool UpperCaseAfterUnderscore
		{
			get
			{
				return _upperCaseAfterUnderscore;
			}
			set
			{
				_upperCaseAfterUnderscore = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [replace underscore with space].
		/// </summary>
		/// <value>
		/// 	<c>true</c> if [replace underscore with space]; otherwise, <c>false</c>.
		/// </value>
		public bool ReplaceUnderscoreWithSpace
		{
			get
			{
				return _replaceUnderscoreWithSpace;
			}
			set
			{
				_replaceUnderscoreWithSpace = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [use dictionary XML].
		/// </summary>
		/// <value><c>true</c> if [use dictionary XML]; otherwise, <c>false</c>.</value>
		public bool UseDictionaryXML
		{
			get
			{
				return _useDictionaryXML;
			}
			set
			{
				_useDictionaryXML = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [auto format original file name].
		/// </summary>
		/// <value>
		/// 	<c>true</c> if [auto format original file name]; otherwise, <c>false</c>.
		/// </value>
		public bool AutoFormatOriginalFileName
		{
			get
			{
				return _autoFormatOriginalFileName;
			}
			set
			{
				_autoFormatOriginalFileName = value;
			}
		}

		#endregion
	}
}
