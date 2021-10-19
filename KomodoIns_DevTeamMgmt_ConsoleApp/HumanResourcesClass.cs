using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoIns_DevTeamMgmt_ConsoleApp
{
    class HumanResources : IEmployee
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
    }
}
