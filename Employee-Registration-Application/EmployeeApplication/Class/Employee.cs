using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace
{
    internal class Employee
    {
        private int empID;
        private string fname, lname, position;

        public Employee() { }
        public Employee(int employeeId, string name, string surname, string pos)
        {
            this.empID = employeeId;
            this.fname = name;
            this.lname = surname;
            this.position = pos;

        }

        public int EmployeeId { get {  return empID; } }
        public string FirstName { get { return fname; } }
        public string LastName { get { return lname; } }
        public string Position { get { return position; } }

    }
}
