using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mp3Formatter.Model
{
	/// <summary>
	/// Dictionary provides the Word/Replacement collections for the Dictionary XML file.
	/// </summary>
	public class Dictionary : IDictionary
	{
		#region Private Members

		private IList<IReplacement> _replacements	= new List<IReplacement>();

		#endregion
		
		#region IDictionary Members

		/// <summary>
		/// Gets the replacements.
		/// </summary>
		/// <value>The replacements.</value>
		public IList<IReplacement> Replacements
		{
			get { return _replacements; }
		}

		#endregion
	}
}
