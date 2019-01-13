using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mp3Formatter.Formatting
{
	/// <summary>
	/// FormatterStatus.
	/// </summary>
	public class FormatterStatus : IFormatterStatus
	{
		#region Private Members

		private bool	_readExceptions;
		private string	_originalFileName;
		private string	_newFileName;

		#endregion
		
		#region IFormatterStatus Members

		/// <summary>
		/// Gets or sets a value indicating whether [read exceptions].
		/// </summary>
		/// <value><c>true</c> if [read exceptions]; otherwise, <c>false</c>.</value>
		public bool ReadExceptions
		{
			get
			{
				return _readExceptions;
			}
			set
			{
				_readExceptions = value;
			}
		}

		/// <summary>
		/// Gets or sets the original name of the file.
		/// </summary>
		/// <value>The original name of the file.</value>
		public string OriginalFileName
		{
			get
			{
				return _originalFileName;
			}
			set
			{
				_originalFileName = value;
			}
		}

		/// <summary>
		/// Gets or sets the new name of the file.
		/// </summary>
		/// <value>The new name of the file.</value>
		public string NewFileName
		{
			get
			{
				return _newFileName;
			}
			set
			{
				_newFileName = value;
			}
		}

		#endregion		
	}
}
