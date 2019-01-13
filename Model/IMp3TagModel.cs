using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mp3Formatter.Model
{
	/// <summary>
	/// IMp3TagModel is an interface for ID3v1 MP3 tag model classes.
	/// </summary>
	public interface IMp3TagModel
	{
		/// <summary>
		/// Gets or sets the name of the file.
		/// </summary>
		/// <value>The name of the file.</value>
		string FileName { get; set; }

		/// <summary>
		/// Gets or sets the track number.
		/// </summary>
		/// <value>The track number.</value>
		string TrackNumber { get; set; }

		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
		string Title { get; set; }

		/// <summary>
		/// Gets or sets the album.
		/// </summary>
		/// <value>The album.</value>
		string Album { get; set; }

		/// <summary>
		/// Gets or sets the artist.
		/// </summary>
		/// <value>The artist.</value>
		string Artist { get; set; }

		/// <summary>
		/// Gets or sets the comments.
		/// </summary>
		/// <value>The comments.</value>
		string Comments { get; set; }

		/// <summary>
		/// Gets or sets the genre.
		/// </summary>
		/// <value>The genre.</value>
		string Genre { get; set; }

		/// <summary>
		/// Gets or sets the year.
		/// </summary>
		/// <value>The year.</value>
		string Year { get; set; }
	}
}
