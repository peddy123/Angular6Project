using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
	public interface IEmployeeRepository
	{
		List<Employee> GetEmployees();
	}
}
