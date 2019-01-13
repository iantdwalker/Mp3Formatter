using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mp3Formatter.Formatting
{
	/// <summary>
	/// DesiredFileNameOutputFormat.
	/// </summary>
	public enum DesiredFileNameOutputFormat
	{
		/// <summary>
		/// DesiredFileNameOutputFormat1 gives the format: 01-File Name
		/// </summary>
		DesiredFileNameOutputFormat1,

		/// <summary>
		/// DesiredFileNameOutputFormat2 gives the format: 01.File Name
		/// </summary>
		DesiredFileNameOutputFormat2,

		/// <summary>
		/// DesiredFileNameOutputFormat3 gives the format: 01 - File Name
		/// </summary>
		DesiredFileNameOutputFormat3,

		/// <summary>
		/// DesiredFileNameOutputFormat4 gives the format: 01 File Name
		/// </summary>
		DesiredFileNameOutputFormat4,

		/// <summary>
		/// DesiredFileNameOutputFormat5 gives the format: File Name
		/// </summary>
		DesiredFileNameOutputFormat5
	}
}
