using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoIns_DevTeamMgmt_ConsoleApp
{
    public interface IEmployee
    {
        int EmployeeID { get; set; }
        string FullName { get; set; }
    }
}
