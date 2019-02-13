using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
	/// <summary>
	/// Represent one specific person
	/// </summary>
	public class Person
	{
		/// <summary>
		/// Id form sql
		/// </summary>
		public int Id { get; set; } = 0;
		/// <summary>
		/// The user's first name.
		/// </summary>
		public string FirstName { get; set; } = "";
		/// <summary>
		/// The usr´s last name.
		/// </summary>
		public string LastName { get; set; } = "";
	}
}