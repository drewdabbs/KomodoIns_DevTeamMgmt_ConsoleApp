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
        private List<Developer> _devDirectory = new List<Developer>();





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




        //Developer's Team = null -- They should be able to see a list of existing developers to choose from and add to existing teams
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
        }

        // Update an existing developer

        //public void UpdateDeveloper()
        //{
        //    Console.Clear();
        //    Developer updateDev = new Developer();
        //    Console.WriteLine("Below are a few options for updating a developer\n\n" +
        //        "Please choose one from the following:\n\n" +
        //        "1. Update the developer's name.\n\n" +
        //        "2. Update the employee id #.\n\n" +
        //        "3. Update as to whether or not the developer has a Pluralsight License.\n\n");

        //    string update = Console.ReadLine();
        //    switch (update)
        //    {
        //        case "1":
        //            UpdateDevName();
        //            break;
        //        case "2":
        //            UpdateEmployeeNumber();
        //            break;
        //        case "3":
        //            UpdatePluralsightLicense();
        //            break;
        //        default:
        //            Console.WriteLine("Not a valid entry. Please enter in a 1, 2, or a 3.");
        //            break;
        //    }
        //}


        //public bool UpdateDevNameRepo(Developer developer)

        //{
        //    //int startingCount = _devDirectory.Count;
        //    //_devDirectory.   //Add(developer);
        //    //bool wasAdded = _devDirectory.Count > startingCount ? true : false;
        //    //return wasAdded;
        //}
        //}

        //Update developer ID - needs functionality to run a check to see if the ID is in use
        //Not sure how functional this would be in a real example as the remove method removes the dev and ID
    //public void UpdateEmployeeNumber()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("\n\nPlease enter the Developer's employee ID #:\n\n");
    //        string empID = Console.ReadLine();
    //        int empIDInt = Int32.Parse(empID);
    //        Console.WriteLine("\n\nPlease enter the Developer's new employee ID #:\n\n");
    //        string updatedNum = Console.ReadLine();
    //        int updatedNumInt = Int32.Parse(updatedNum);

    //        foreach (Developer developer in _devDirectory)
    //        {
    //            if (developer.EmployeeID == empIDInt)
    //            {
    //                developer.EmployeeID = updatedNumInt;
    //            }
    //        }
    //    }

        //public void UpdatePluralsightLicense()
        //{
        //    Console.Clear();
        //    Console.WriteLine("\n\nPlease enter the Developer's employee ID #:\n\n");
        //    string empID = Console.ReadLine();
        //    int empIDInt = Int32.Parse(empID);

        //    foreach (Developer developer in _devDirectory)
        //    {
        //        if (developer.EmployeeID == empIDInt)
        //        {
        //            Console.WriteLine($"Employee ID #: {developer.EmployeeID}, with the name: {developer.FullName}" + $" has a Pluralsight License status of: {developer.PluralsightAccess} \n\n");
        //            Console.WriteLine("Let us update this developer:\n\n" +
        //                "Type 1 if the developer now has a license.\n\n" +
        //                "Type 2 if the developer now does not have a license.\n\n");

        //            string pSL = Console.ReadLine();
        //            switch (pSL)
        //            {
        //                case "1":
        //                    developer.PluralsightAccess = true;
        //                    break;
        //                case "2":
        //                    developer.PluralsightAccess = false;
        //                    break;
        //                default:
        //                    Console.WriteLine("Option not recognized. Please select 1 if the developer has a Pluralsight license or 2 if they do not.");
        //                    break;
        //            }
        //        }
        //    }
        //}

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
    public bool DeleteExistingDeveloper()  // Remove a developer by ID
    {
        Console.Clear();
        Console.WriteLine("\n\nPlease enter the Developer's employee ID #:\n\n");
        string empID = Console.ReadLine();
        int empIDInt = Int32.Parse(empID);

        foreach (Developer developer in _devDirectory)
        {
            if (developer.EmployeeID == empIDInt)
            {
                _devDirectory.Remove(developer);
                Console.WriteLine("Developer has been removed.");
                return true;
            }
        }
        return false;
    }

    // find developer by id
    public void FindDeveloperEmpID()
    {
        Console.Clear();
        Console.WriteLine("\n\nPlease enter the Developer's employee ID #:\n\n");
        string empID = Console.ReadLine();
        int empIDInt = Int32.Parse(empID);

        foreach (Developer developer in _devDirectory)
        {
            if (developer.EmployeeID == empIDInt)
            {
                Console.WriteLine($"Employee ID #: {developer.EmployeeID}| Employee Name #: {developer.FullName} | " +
$"Has Pluralsight License: {developer.PluralsightAccess}");
                Console.ReadKey();
                break;
            }
            // Add Console.WriteLine("Employee not found.");
        }

        Console.ReadKey();
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


