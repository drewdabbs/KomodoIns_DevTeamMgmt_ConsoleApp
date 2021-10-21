using Developer_ClassList;
using Developer_Repository;
using DeveloperTeam_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoIns_DevTeamMgmt_ConsoleApp
{
    public class ProgramUI
    {
        private readonly Developer_Repo _developerRepo = new Developer_Repo();
        public void Run()
        {
            Display();
            _developerRepo.SeedDevListRepo();
            RunMenu();

        }
        private void Display()
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

        // Main Run Menu
        public void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("\n\nWelcome to the Komodo Insurance Developer Team Application.\n" +
                    "\nBelow are a few options to choose from.\n\n\n" +
                    "If you are a Project Manager and need to Add, Remove, Modify, or Find a Developer in our database, Press 1.\n\n\n" +
                    "If you are a Developer and would like to see a list showing your peers and what teams they are on, Press 2.\n\n\n" +
                    "If you are a member of Human Resources and need an updated list of developers \n" +
                    "and project manager that still need a Pluralsight license, Press 3.\n\n\n" +
                    "To exit the application, press 4.");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        ProjectManagerOptions();
                        continueToRun = false;
                        break;
                    case "2":
                        Display();
                        ReadListOfDevs();
                        break;
                    case "3":
                        HumanResourcesMenu();
                        continueToRun = false;
                        break;
                    case "4":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter in a valid number between 1 and 4.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }

        }
        public void ReadListOfDevs()
        {
            Console.Clear();
            List<Developer> displayDevList = _developerRepo.ReadListOfDevsRepo();
            foreach (Developer developer in displayDevList)
            {
                DisplayDev(developer);
                Console.WriteLine("__________________________\n");

            }
        }
        public void DisplayDev(Developer developer)
        {
            Console.WriteLine($"Employee ID #: {developer.EmployeeID}");
            Console.WriteLine($"Employee Name #: {developer.FullName} ");
            Console.WriteLine("Has Pluralsight License: " + (developer.PluralsightAccess));
        }


        // Program Manager's Main Menu
        public void ProjectManagerOptions()
        {
            bool runManagerUI = true;
            while (runManagerUI)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Project Manager's UI. From here you can:\n\n" +
                    "1. Add a new developer including ID, Name, License status, and Team assignment.\n\n\n" +
                    "2. Update an existing developer.\n\n\n" +
                    "3. Remove a developer using employee ID #\n\n\n" +
                    "4. View a list of current developers, their Employee ID, Name, License status, and Team assignment\n\n\n" +
                    "5. Find a developer by employee ID #\n\n\n" +
                    "6. Modify Teams including view all teams and its members, view an individual team and its members, and move one developer from a team and assign them to another.\n\n\n" +
                    "7. Exit this application.");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddNewDeveloper();
                        break;
                    case "2":
                        UpdateDeveloper();
                        break;
                    case "3":
                        _developerRepo.DeleteExistingDeveloper();
                        break;
                    case "4":
                        //Read
                        break;
                    case "5":
                        _developerRepo.FindDeveloperEmpID();
                        break;
                    case "6":
                        TeamManagementUI();
                        break;
                    case "7":
                        runManagerUI = false;
                        break;
                    default:
                        Console.WriteLine("Please enter in a valid number between 1 and 7.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        public void UpdateDeveloper()
        {
            Console.Clear();
            Developer updateDev = new Developer();
            Console.WriteLine("Below are a few options for updating a developer\n\n" +
                "Please choose one from the following:\n\n" +
                "1. Update the developer's name.\n\n" +
                "2. Update the employee id #.\n\n" +
                "3. Update as to whether or not the developer has a Pluralsight License.\n\n");

            string update = Console.ReadLine();
            switch (update)
            {
                case "1":
                    UpdateDevName();
                    break;
                case "2":
                    UpdateEmployeeNumber();
                    break;
                case "3":
                    UpdatePluralsightLicense();
                    break;
                default:
                    Console.WriteLine("Not a valid entry. Please enter in a 1, 2, or a 3.");
                    break;
            }
        }
        public void UpdateDevName()
        {
            List<Developer> developerList = _developerRepo.ReadListOfDevsRepo();
            Console.Clear();
            Console.WriteLine("These entries are case sensitive.\n\n");
            Console.WriteLine("\n\nPlease enter the Developer's employee ID #:\n\n");
            string empID = Console.ReadLine();
            int empIDInt = Int32.Parse(empID);
            Console.WriteLine("\n\nPlease enter the Developer's new full name:\n\n");
            string updatedName = Console.ReadLine();

            foreach (Developer developer in developerList)
            {
                if (developer.EmployeeID == empIDInt)
                {
                    developer.FullName = updatedName;
                }
            }
        }

        public void UpdateEmployeeNumber()
        {
            List<Developer> developerList = _developerRepo.ReadListOfDevsRepo();
            Console.Clear();
            Console.WriteLine("\n\nPlease enter the Developer's employee ID #:\n\n");
            string empID = Console.ReadLine();
            int empIDInt = Int32.Parse(empID);
            Console.WriteLine("\n\nPlease enter the Developer's new employee ID #:\n\n");
            string updatedNum = Console.ReadLine();
            int updatedNumInt = Int32.Parse(updatedNum);

            foreach (Developer developer in developerList)
            {
                if (developer.EmployeeID == empIDInt)
                {
                    developer.EmployeeID = updatedNumInt;
                }
            }
        }

        public void UpdatePluralsightLicense()
        {
            List<Developer> developerList = _developerRepo.ReadListOfDevsRepo();
            Console.Clear();
            Console.WriteLine("\n\nPlease enter the Developer's employee ID #:\n\n");
            string empID = Console.ReadLine();
            int empIDInt = Int32.Parse(empID);

            foreach (Developer developer in developerList)
            {
                if (developer.EmployeeID == empIDInt)
                {
                    Console.WriteLine($"Employee ID #: {developer.EmployeeID}, with the name: {developer.FullName}" + $" has a Pluralsight License status of: {developer.PluralsightAccess} \n\n");
                    Console.WriteLine("Let us update this developer:\n\n" +
                        "Type 1 if the developer now has a license.\n\n" +
                        "Type 2 if the developer now does not have a license.\n\n");

                    string pSL = Console.ReadLine();
                    switch (pSL)
                    {
                        case "1":
                            developer.PluralsightAccess = true;
                            break;
                        case "2":
                            developer.PluralsightAccess = false;
                            break;
                        default:
                            Console.WriteLine("Option not recognized. Please select 1 if the developer has a Pluralsight license or 2 if they do not.");
                            break;
                    }
                }
            }
        }

                public void AddNewDeveloper()
                {
                    Developer developer = new Developer();
                    Console.WriteLine("\nPlease enter the developer's full name:");
                    developer.FullName = Console.ReadLine();
                    Console.WriteLine("\nPlease enter the new developer's employee ID:");
                    string empID = Console.ReadLine();
                    try
                    {
                        developer.EmployeeID = Convert.ToInt32(empID);
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
                            developer.PluralsightAccess = true;
                            break;
                        case "2":
                            developer.PluralsightAccess = false;
                            break;
                        default:
                            Console.WriteLine("Option not recognized. Please select 1 if the developer has a Pluralsight license or 2 if they do not.");
                            break;
                    }
                    _developerRepo.AddDeveloperToRepo(developer);
                }


                // Human Resources Main Menu
                public void HumanResourcesMenu()
                {
                    bool runHRUI = true;
                    while (runHRUI)
                    {
                        Console.Clear();
                        Console.WriteLine("Welcoe to your monthly check on developrs that are in need\n" +
                            " of a Pluralsight License.\n\n" +
                            "Below are options to generate the list or exit:\n\n\n" +
                            "Press 1 to generate a list of developers in need of a license.\n\n" +
                            "Press 2 to exit.");
                        string optionHR = Console.ReadLine();
                        switch (optionHR)
                        {
                            case "1":
                                _developerRepo.ListDevelopersWithoutPluralsightLicense();
                                break;
                            case "2":
                                runHRUI = false;
                                break;
                            default:
                                Console.WriteLine("Please enter either the number 1 or number 2.\n" +
                                    "Press any key to continue...");
                                Console.ReadKey();
                                break;
                        }
                    }
                }

                // Team Management UI
                public void TeamManagementUI()
                {
                    bool runTeamUI = true;
                    while (runTeamUI)
                    {
                        Console.Clear();
                        Console.WriteLine("Greetings Team Managers.\n" +
                            "Below are options to generate the list or exit:\n\n\n" +
                            "Press 1 to show a list of teams with their team name and team ID #.\n\n" +
                            "Press 2 to exit.");
                        string option = Console.ReadLine();
                        switch (option)
                        {
                            case "1":
                                TeamManagementOptionsUI();
                                break;
                            case "2":
                                runTeamUI = false;
                                break;
                            default:
                                Console.WriteLine("Please enter either the number 1 or number 2.\n" +
                                    "Press any key to continue...");
                                Console.ReadKey();
                                break;
                        }
                    }
                }

                // Team Management Options UI
                public void TeamManagementOptionsUI()
                {
                    bool runTeamOptions = true;
                    while (runTeamOptions)
                    {
                        Console.Clear();
                        Console.WriteLine("Greetings Again Team Managers.\n\n\n" +
                            "Press 1 for Team One" +
                            "Press 2 for Team Two" +
                            "Press 3 for Team Three" +
                            "Press 4 for Team Four" +
                            "Press 5 for Team Five" +
                            "Press 6 to exit.");
                        string input = Console.ReadLine();
                        switch (input)
                        {
                            case "1":
                                // Team One
                                break;
                            case "2":
                                // Team Two
                                break;
                            case "3":
                                // Team Three
                                break;
                            case "4":
                                // Team Four
                                break;
                            case "5":
                                // Team Five
                                break;
                            case "6":
                                runTeamOptions = false;
                                break;
                            default:
                                Console.WriteLine("Please enter either the number 1 or number 2.\n" +
                                    "Press any key to continue...");
                                Console.ReadKey();
                                break;
                        }
                    }
                }



            }
        }

