﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    internal class EmployeeList
    {
        List<Employee> employeeL = new List<Employee>();
        public void addEmployee(Employee emp)
        {
            employeeL.Add(emp);
        }
    }
}
