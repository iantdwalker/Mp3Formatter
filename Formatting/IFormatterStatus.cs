using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mp3Formatter.Formatting
{
	/// <summary>
	/// Provides an interface for objects returning
	/// state information gathered during the MP3 file processing.
	/// </summary>
	public interface IFormatterStatus
	{
		/// <summary>
		/// Gets or sets a value indicating whether [read exceptions].
		/// </summary>
		/// <value><c>true</c> if [read exceptions]; otherwise, <c>false</c>.</value>
		bool ReadExceptions { get; set; }

		/// <summary>
		/// Gets or sets the original name of the file.
		/// </summary>
		/// <value>The original name of the file.</value>
		string OriginalFileName { get; set; }
		
		/// <summary>
		/// Gets or sets the new name of the file.
		/// </summary>
		/// <value>The new name of the file.</value>
		string NewFileName { get; set; }
	}
}
