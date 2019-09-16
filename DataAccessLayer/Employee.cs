using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
	public class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		
		// Navigation Property
		public Department Department { get; set; }

	}
}
