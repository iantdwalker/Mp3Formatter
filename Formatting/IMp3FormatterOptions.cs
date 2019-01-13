using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mp3Formatter.Formatting
{
	/// <summary>
	/// An interface for objects that can provide MP3 formatting options.
	/// </summary>
	public interface IMp3FormatterOptions
	{
		/// <summary>
		/// Gets or sets the ID3 tag version to update.
		/// </summary>
		/// <value>The ID3 version.</value>
		ID3Version ID3Version { get; set; }

		/// <summary>
		/// Gets or sets the desired file name output format.
		/// </summary>
		/// <value>The desired track format.</value>
		DesiredFileNameOutputFormat DesiredFileNameOutputFormat { get; set; }

		/// <summary>
		/// Gets or sets the file name title option.
		/// </summary>
		/// <value>The file name title option.</value>
		FileNameTitleOptions FileNameTitleOption { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to auto format the manual override tags.
		/// </summary>
		/// <value><c>true</c> if [auto format tags]; otherwise, <c>false</c>.</value>
		bool AutoFormatTags { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether track numbers 1-9 should be prefixed with 0.
		/// </summary>
		/// <value><c>true</c> if prefix0; otherwise, <c>false</c>.</value>
		bool PrefixZero { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to set the next character to uppercase after a bracket (, [ or {
		/// </summary>
		/// <value>
		/// 	<c>true</c> if [upper case after brackets]; otherwise, <c>false</c>.
		/// </value>
		bool UpperCaseAfterBrackets { get; set; }
		
		/// <summary>
		/// Gets or sets a value indicating whether [upper case after underscore].
		/// </summary>
		/// <value>
		/// 	<c>true</c> if [upper case after underscore]; otherwise, <c>false</c>.
		/// </value>
		bool UpperCaseAfterUnderscore { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [replace underscore with space].
		/// </summary>
		/// <value>
		/// 	<c>true</c> if [replace underscore with space]; otherwise, <c>false</c>.
		/// </value>
		bool ReplaceUnderscoreWithSpace { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [use dictionary XML].
		/// </summary>
		/// <value><c>true</c> if [use dictionary XML]; otherwise, <c>false</c>.</value>
		bool UseDictionaryXML { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether [auto format original file name].
		/// </summary>
		/// <value>
		/// 	<c>true</c> if [auto format original file name]; otherwise, <c>false</c>.
		/// </value>
		bool AutoFormatOriginalFileName { get; set; }
	}
}
