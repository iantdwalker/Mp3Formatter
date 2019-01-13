using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mp3Formatter.Model
{
	/// <summary>
	/// IReplacement is an interface for Replacement string objects.
	/// </summary>
	public interface IReplacement
	{
		/// <summary>
		/// Gets or sets the before.
		/// </summary>
		/// <value>The before.</value>
		string Before { get; set; }

		/// <summary>
		/// Gets or sets the after.
		/// </summary>
		/// <value>The after.</value>
		string After { get; set; }

		/// <summary>
		/// Gets or sets the type of the replacement.
		/// </summary>
		/// <value>The type of the replacement.</value>
		string ReplacementType { get; set; }
	}
}
