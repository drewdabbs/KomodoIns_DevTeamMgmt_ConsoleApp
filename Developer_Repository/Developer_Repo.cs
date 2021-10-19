using Developer_ClassList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Repository
{
    public class Developer_Repo
    {
        private readonly List<Developer> _devDirectory = new List<Developer>();

        // Create a new developer
        public bool AddDeveloperToRepo(Developer developer)
        {
            int startingCount = _devDirectory.Count;
            _devDirectory.Add(developer);
            bool wasAdded = _devDirectory.Count > startingCount ? true : false;
            return wasAdded;
        }
        // Read or access the database
        public List<Developer> ReadListOfDevs()
        {
            return _devDirectory;
        }
        // Update an existing developer


        // Remove an employee/developer

        // Find Developer by ID
        public Developer FindDeveloperEmpID(int employeeID)
        {
            foreach (Developer developer in _devDirectory)
                if (developer == )
        }
    }
}
