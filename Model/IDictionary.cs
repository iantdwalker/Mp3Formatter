using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mp3Formatter.Model
{
	/// <summary>
	/// IDictionary provides an interface for Dictionary objects.
	/// </summary>
	public interface IDictionary
	{
		/// <summary>
		/// Gets the replacements.
		/// </summary>
		/// <value>The replacements.</value>
		IList<IReplacement> Replacements { get; }
	}
}
