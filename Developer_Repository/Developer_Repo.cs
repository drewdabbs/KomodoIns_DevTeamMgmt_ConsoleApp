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
        
        public void DisplayRepo()
        {
            Console.Clear();
            Console.WriteLine("#    #                                       ###                                                         \n" +
                "#   #   ####  #    #  ####  #####   ####      #  #    #  ####  #    # #####    ##   #    #  ####  ###### \n" +
                "#  #   #    # ##  ## #    # #    # #    #     #  ##   # #      #    # #    #  #  #  ##   # #    # #      \n" +
                "###    #    # # ## # #    # #    # #    #     #  # #  #  ####  #    # #    # #    # # #  # #      #####  \n" +
                "#  #   #    # #    # #    # #    # #    #     #  #  # #      # #    # #####  ###### #  # # #      #      \n" +
                "#   #  #    # #    # #    # #    # #    #     #  #   ## #    # #    # #   #  #    # #   ## #    # #      \n" +
                "#    #  ####  #    #  ####  #####   ####     ### #    #  ####   ####  #    # #    # #    #  ####  ###### \n");
        }



        // Create a new developer
        public void AddNewDeveloper()
        {
            Developer newDev = new Developer();
            Console.WriteLine("\nPlease enter the developer's full name:");
            newDev.FullName = Console.ReadLine();

            Console.WriteLine("\nPlease enter the new developer's employee ID:");
            string empID = Console.ReadLine();
            try
            {
                newDev.EmployeeID = Convert.ToInt32(empID);
            }
            catch
            {
                Console.WriteLine("Looks like there was an error. Employee ID's are three numerals in order, ranging in vallue from 001 to 999. Please try again");
            }
            Console.WriteLine("\nDoes this new developer have a Pluralsight license?\n" +
                "Enter 1. for yes and 2. for no.");
            string pSL = Console.ReadLine();
            switch (pSL)
            {
                case "1":
                    newDev.PluralsightAccess = true;
                    break;
                case "2":
                    newDev.PluralsightAccess = false;
                    break;
                default:
                    Console.WriteLine("Option not recognized. Please select 1 if the developer has a Pluralsight license or 2 if they do not.");
                    break;
            }
            Console.WriteLine("\nFinally, which team should the new developer be assigned to:\n" +
                "1. For Team One: The Ravens.\n" +
                "2. For Team Two: The Bedouins.\n" +
                "3. For Team Three: The Oracles.\n" +
                "4. For Team Four: A Tribe Called Dev.\n" +
                "5. For Team Five: The Night Owls.\n" +
                " or 6. None at this time.\n\n");
            string teamAssignment = Console.ReadLine();
            switch (teamAssignment)
            {
                case "1":
                    newDev.TeamNum = TeamNumber.Team1;
                    Console.WriteLine("New developer has been assigned to Team One: The Ravens.");
                    break;
                case "2":
                    newDev.TeamNum = TeamNumber.Team2;
                    Console.WriteLine("New developer has been assigned to Team Two: The Bedouins.");
                    break;
                case "3":
                    newDev.TeamNum = TeamNumber.Team3;
                    Console.WriteLine("New developer has been assigned to For Team Three: The Oracles.");
                    break;
                case "4":
                    newDev.TeamNum = TeamNumber.Team4;
                    Console.WriteLine("New developer has been assigned to Team Four: A Tribe Called Dev.");
                    break;
                case "5":
                    newDev.TeamNum = TeamNumber.Team5;
                    Console.WriteLine("New developer has been assigned to Team Five: The Night Owls.");
                    break;
                case "6":
                    newDev.TeamNum = TeamNumber.Team6;
                    Console.WriteLine("The new developer has not been assigned to a team at this point.");
                    break;
                default:
                    Console.WriteLine("Please enter in a valid number between 1-6");
                    break;
            }
            _devDirectory.Add(newDev);
        }


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

        public void DisplayListOfDevelopers()
        {
            List<Developer> displayDevelopers = ReadListOfDevs();
            foreach (Developer devVariable in displayDevelopers)
            {
                DisplayDevelopers(devVariable);
                Console.WriteLine("------------------------");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public void DisplayDevelopers(Developer devData)
        {
            Console.WriteLine($"Employee ID #: {devData.EmployeeID}| Employee Name #: {devData.FullName} | " +
                $"Has Pluralsight License: {devData.PluralsightAccess} | Team #: {devData.TeamNum}");
        }

        // Update an existing developer


        // Remove an employee/developer

        // find developer by id
        public void FindDeveloperEmpID()
        {

            // Developer empList = new Developer();
            Console.WriteLine("\n\nPlease enter the Developer's employee ID #:\n\n");
            string empID = Console.ReadLine();
            int empIDInt = Int32.Parse(empID);





            foreach (Developer developer in _devDirectory)
            {
                if (developer.EmployeeID == empIDInt)
                {
                    Console.WriteLine($"Employee ID #: {developer.EmployeeID}| Employee Name #: {developer.FullName} | " +
            $"Has Pluralsight License: {developer.PluralsightAccess} | Team #: {developer.TeamNum}");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                    break;
                }
            }
            Console.ReadKey();




        }



        public void SeedDevListRepo()
        {
            Developer dev1 = new Developer(001, "Amanda Knight", true, TeamNumber.Team1);
            Developer dev2 = new Developer(002, "Colin Dunn", false, TeamNumber.Team2);
            Developer dev3 = new Developer(003, "Danny Redden", true, TeamNumber.Team3);
            Developer dev4 = new Developer(004, "Dillan Groce", false, TeamNumber.Team4);
            Developer dev5 = new Developer(005, "Andrew Dabbs", true, TeamNumber.Team5);
            Developer dev6 = new Developer(006, "Fabiola Aguilera", false, TeamNumber.Team1);
            Developer dev7 = new Developer(007, "Forrest Ryan", true, TeamNumber.Team2);
            Developer dev8 = new Developer(008, "Garry Banks", false, TeamNumber.Team3);
            Developer dev9 = new Developer(009, "Isiah Elder", true, TeamNumber.Team4);
            Developer dev10 = new Developer(010, "Jade Neff", false, TeamNumber.Team5);
            Developer dev11 = new Developer(011, "Jamar Watkins", true, TeamNumber.Team1);
            Developer dev12 = new Developer(012, "Jeremy Francoeur", false, TeamNumber.Team2);
            Developer dev13 = new Developer(013, "Joshua Middleton", true, TeamNumber.Team3);
            Developer dev14 = new Developer(014, "Keith Ping", false, TeamNumber.Team4);
            Developer dev15 = new Developer(015, "Leslie Counterman", true, TeamNumber.Team5);
            Developer dev16 = new Developer(016, "Mason Mobley", false, TeamNumber.Team1);
            Developer dev17 = new Developer(017, "Nabil Diaf", true, TeamNumber.Team2);
            Developer dev18 = new Developer(018, "Nathan Foreman", false, TeamNumber.Team3);
            Developer dev19 = new Developer(019, "Peter Nikolov", true, TeamNumber.Team4);
            Developer dev20 = new Developer(020, "Rex Meyer", false, TeamNumber.Team5);
            Developer dev21 = new Developer(021, "Samuel Rodriguez", true, TeamNumber.Team1);
            Developer dev22 = new Developer(022, "Savanah Jackson", false, TeamNumber.Team2);
            Developer dev23 = new Developer(023, "LaToya Harvell", true, TeamNumber.Team3);
            Developer dev24 = new Developer(024, "Tristan Auer", false, TeamNumber.Team4);
            Developer dev25 = new Developer(025, "Vanessa Nance", true, TeamNumber.Team5);


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


