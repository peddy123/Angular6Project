using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
	public class EmployeeDBContext: DbContext
	{
		public DbSet<Department> Departments { get; set; }
		public DbSet<Employee> Employees { get; set; }

	}
}
