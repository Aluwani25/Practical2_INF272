using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practical2_INF272.Models
{
	public class GroupModel
	{
		[Display(Name= "Student Number")]
		public string studentNumber { get; set; }

		[Display(Name = "First Name")]

		public string FirstName { get; set; }
		[Display(Name ="Last Name")]
		public string LastName { get; set; }

		[Display(Name= " Email Address")]
		public string EmailAddress { get; set; }

		[Display(Name = "Link to personal page")]
		public string Link { get; set; }



	}
}