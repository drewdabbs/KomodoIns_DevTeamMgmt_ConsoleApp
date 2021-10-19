using KomodoIns_DevTeamMgmt_ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Repository
{
    public class Developer_Repo
    {
        public List<Developer> _devList = new List<Developer>();

        // Create a new developer
        public bool AddDeveloperToRepo(Developer developer)
        {
            int startingCount = _devList.Count;
            _devList.Add(developer);
            bool wasAdded = _devList.Count > startingCount ? true : false;
            return wasAdded;
        }
        // Read or access the database
        public List<Developer> ReadListOfDevs()
        {
            return _devList;
        }
        // Update an existing developer


        // Remove an employee/developer
    }
}
