using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mp3Formatter.Model
{
	/// <summary>
	/// Replacement.
	/// </summary>
	public class Replacement : IReplacement
	{
		#region Private Members

		private string _before;
		private string _after;
		private string _replacementType;

		#endregion

		#region Construction

		/// <summary>
		/// Initializes a new instance of the <see cref="Replacement"/> class.
		/// </summary>
		/// <param name="before">The before.</param>
		/// <param name="after">The after.</param>
		/// <param name="replacementType">Type of the replacement.</param>
		public Replacement(string before, string after, string replacementType)
		{
			if (string.IsNullOrEmpty(before)) throw new ArgumentException("The before parameter is null or empty.", "before");
			if (string.IsNullOrEmpty(after)) throw new ArgumentException("The after parameter is null or empty.", "after");
			if (string.IsNullOrEmpty(replacementType)) throw new ArgumentException("The replacementType parameter is null or empty.", "replacementType");

			_before				= before;
			_after				= after;
			_replacementType	= replacementType;
		}

		#endregion
		
		#region IReplacement Members

		/// <summary>
		/// Gets or sets the before.
		/// </summary>
		/// <value>The before.</value>
		public string Before
		{
			get
			{
				return _before;
			}
			set
			{
				_before = value;
			}
		}

		/// <summary>
		/// Gets or sets the after.
		/// </summary>
		/// <value>The after.</value>
		public string After
		{
			get
			{
				return _after;
			}
			set
			{
				_after = value;
			}
		}

		/// <summary>
		/// Gets or sets the type of the replacement.
		/// </summary>
		/// <value>The type of the replacement.</value>
		public string ReplacementType
		{
			get
			{
				return _replacementType;
			}
			set
			{
				_replacementType = value;
			}
		}

		#endregion
	}
}
