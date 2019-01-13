using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Mp3Formatter.Model;

namespace Mp3Formatter.Formatting
{
	/// <summary>
	/// IFormatter provides an interface for formatting and processing methods.
	/// </summary>
	public interface IFormatter
	{
		/// <summary>
		/// Processes the MP3.
		/// </summary>
		/// <param name="mp3File">The MP3 file.</param>
		/// <param name="mp3TagMpdel">The MP3 tag mpdel.</param>
		/// <param name="mp3FormatterOptions">The MP3 formatter options.</param>
		/// <returns></returns>
		IFormatterStatus ProcessMp3(string mp3File, IMp3TagModel mp3TagMpdel, IMp3FormatterOptions mp3FormatterOptions);

		/// <summary>
		/// Handles the exception.
		/// </summary>
		/// <param name="ex">The ex.</param>
		void HandleException(Exception ex);

		/// <summary>
		/// Loads the dictionary.
		/// </summary>
		void LoadDictionary();
	}
}
