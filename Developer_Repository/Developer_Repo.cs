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
        public List<Developer> ReadListOfDevsRepo()
        {
            return _devDirectory;
        }
        //Developers not on a team
        public List<Developer> DeveloperNotOnATeam()
        {
            List<Developer> devList = new List<Developer>();
            foreach (Developer developer in _devDirectory)
            {
                if (developer.Team == null)
                {
                    devList.Add(developer);
                }
            }
            return devList;
        } // Needs population
        // Update an existing developer
        public bool UpdateExistingDev(int empIDInt, Developer newDeveloper)
        {
            Developer developer = FindDeveloperEmpID(empIDInt);
            //returns null or streamingcontent object with value
            if (developer != null)
            {
                developer.EmployeeID = newDeveloper.EmployeeID;
                developer.FullName = newDeveloper.FullName;
                developer.PluralsightAccess = newDeveloper.PluralsightAccess;
                return true;
            }
            else
            {
                return false;
            }
        } //Full update, minus teams, can be a bonus
        //HR to update Pluralsight License
        public void ListDevelopersWithoutPluralsightLicense()
        {
            Console.Clear();
            Console.WriteLine("\n\nA generated list of developers still in need of a Pluralsight License:\n\n");

            foreach (Developer developer in _devDirectory)
            {
                if (developer.PluralsightAccess != true)
                {
                    Console.WriteLine($"Employee ID #: {developer.EmployeeID}, with the name: {developer.FullName}" + $" has a Pluralsight License status of: {developer.PluralsightAccess} \n\n");
                }
            }
            Console.ReadKey();
        }
        // Remove a developer
        public bool DeleteExistingDeveloperRepo(Developer developer)
        {
            bool deleteResult = _devDirectory.Remove(developer);
            return deleteResult;
        }
        // find developer by id
        public Developer FindDeveloperEmpID(int empIDInt)
        {
            foreach (Developer developer in _devDirectory)
            {
                if (developer.EmployeeID == empIDInt)
                {
                    return developer;
                }
            }

            return null;
        }
        public void SeedDevListRepo()
        {
            Developer dev1 = new Developer(001, "Amanda Knight", true);
            Developer dev2 = new Developer(002, "Colin Dunn", false);
            Developer dev3 = new Developer(003, "Danny Redden", true);
            Developer dev4 = new Developer(004, "Dillan Groce", false);
            Developer dev5 = new Developer(005, "Andrew Dabbs", true);
            Developer dev6 = new Developer(006, "Fabiola Aguilera", false);
            Developer dev7 = new Developer(007, "Forrest Ryan", true);
            Developer dev8 = new Developer(008, "Garry Banks", false);
            Developer dev9 = new Developer(009, "Isiah Elder", true);
            Developer dev10 = new Developer(010, "Jade Neff", false);
            Developer dev11 = new Developer(011, "Jamar Watkins", true);
            Developer dev12 = new Developer(012, "Jeremy Francoeur", false);
            Developer dev13 = new Developer(013, "Joshua Middleton", true);
            Developer dev14 = new Developer(014, "Keith Ping", false);
            Developer dev15 = new Developer(015, "Leslie Counterman", true);
            Developer dev16 = new Developer(016, "Mason Mobley", false);
            Developer dev17 = new Developer(017, "Nabil Diaf", true);
            Developer dev18 = new Developer(018, "Nathan Foreman", false);
            Developer dev19 = new Developer(019, "Peter Nikolov", true);
            Developer dev20 = new Developer(020, "Rex Meyer", false);
            Developer dev21 = new Developer(021, "Samuel Rodriguez", true);
            Developer dev22 = new Developer(022, "Savanah Jackson", false);
            Developer dev23 = new Developer(023, "LaToya Harvell", true);
            Developer dev24 = new Developer(024, "Tristan Auer", false);
            Developer dev25 = new Developer(025, "Vanessa Nance", true);


            AddDeveloperToRepo(dev1);
            AddDeveloperToRepo(dev2);
            AddDeveloperToRepo(dev3);
            AddDeveloperToRepo(dev4);
            AddDeveloperToRepo(dev5);
            AddDeveloperToRepo(dev6);
            AddDeveloperToRepo(dev7);
            AddDeveloperToRepo(dev8);
            AddDeveloperToRepo(dev9);
            AddDeveloperToRepo(dev10);
            AddDeveloperToRepo(dev11);
            AddDeveloperToRepo(dev12);
            AddDeveloperToRepo(dev13);
            AddDeveloperToRepo(dev14);
            AddDeveloperToRepo(dev15);
            AddDeveloperToRepo(dev16);
            AddDeveloperToRepo(dev17);
            AddDeveloperToRepo(dev18);
            AddDeveloperToRepo(dev19);
            AddDeveloperToRepo(dev20);
            AddDeveloperToRepo(dev21);
            AddDeveloperToRepo(dev22);
            AddDeveloperToRepo(dev23);
            AddDeveloperToRepo(dev24);
            AddDeveloperToRepo(dev25);
        }
    }
}


