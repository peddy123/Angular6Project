using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
namespace DataAccessLayer
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private readonly EmployeeDBContext context;

		public EmployeeRepository(EmployeeDBContext context)
		{
			this.context = context;
		}
		public List<Department> GetDepartments()
		{
			
			return context.Departments.Include("Employees").ToList();
		}

		public List<Employee> GetEmployees()
		{
			EmployeeDBContext employeeDBContext = new EmployeeDBContext();
			return context.Employees.ToList();
		}
	}
}
