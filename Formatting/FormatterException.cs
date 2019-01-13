using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mp3Formatter.Formatting
{
	/// <summary>
	/// FormatterException for exceptions thrown from IFormatter instance classes.
	/// </summary>
	public class FormatterException : Exception
	{
		#region Construction
		
		/// <summary>
		/// Initializes a new instance of the <see cref="FormatterException"/> class.
		/// </summary>
		/// <param name="message">The message.</param>
		/// <param name="innerException">The inner exception.</param>
		public FormatterException(string message, Exception innerException) : base(message, innerException)
		{}

		#endregion
	}
}
