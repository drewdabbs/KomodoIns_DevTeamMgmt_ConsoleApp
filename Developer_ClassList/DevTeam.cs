using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_ClassList
{
    public class DevTeam
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public List<Developer> TeamMembers { get; set;}
    }
}
