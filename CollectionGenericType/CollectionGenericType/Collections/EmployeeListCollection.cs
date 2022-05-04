using CollectionGenericType.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionGenericType.Collections
{
    class EmployeeListCollection
    {
        Employee[] Employees;

        public EmployeeListCollection()
        {
            Employees = new Employee[0];
        }

        public void Add(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;
        }

        public Employee Get(int index)
        {
            return Employees[index];
        }
    }
}
