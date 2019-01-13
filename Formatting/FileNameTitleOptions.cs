using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mp3Formatter.Formatting
{
	/// <summary>
	/// FileNameTitleOptions.
	/// </summary>
	public enum FileNameTitleOptions
	{
		/// <summary>
		/// UseTitleAsNewFileNameUseNewFileNameAsTitle will use the formatted Title value as the
		/// new File Name and will then format it according to the selected options. Then, the
		/// formatted new File Name is used as the new Title.
		/// E.G: File Name: 01-My Track.mp3, Title: 01-My Track
		/// </summary>
		UseTitleAsNewFileNameUseNewFileNameAsTitle,
		
		/// <summary>
		/// UseOriginalFileNameAndTitle will maintain the track's original
		/// File Name and Title. Both will still be formatted according to the selected options.
		/// E.G: File Name: 01-My Original File Name.mp3, Title: My Track
		/// </summary>
		UseOriginalFileNameAndTitle,

		/// <summary>
		/// UseOriginalFileNameAsTitle will maintain the track's original File Name,
		/// format it according to the selected options and will then set the Title to be the same value.
		/// E.G: File Name: 01-My Original File Name.mp3, Title: 01-My Original File Name
		/// </summary>
		UseOriginalFileNameAsTitle,

		/// <summary>
		/// UseTitleAsNewFileName will use the formatted Title value as the new File Name and
		/// will then format it according to the selected options.
		/// E.G: File Name: 01-My Track.mp3, Title: My Track
		/// </summary>
		UseTitleAsNewFileName		
	}
}
