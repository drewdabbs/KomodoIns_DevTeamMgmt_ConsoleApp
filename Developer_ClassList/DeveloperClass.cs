using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_ClassList
{
    public class Developer : IEmployee
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public bool PluralsightAccess { get; set; }
        public DevTeam Team { get; set; }
        public Developer() { }
        public Developer(int employeeID, string fullName, bool pluralAccess)
        {
            EmployeeID = employeeID;
            FullName = fullName;
            PluralsightAccess = pluralAccess;
            
        }
    }
}
