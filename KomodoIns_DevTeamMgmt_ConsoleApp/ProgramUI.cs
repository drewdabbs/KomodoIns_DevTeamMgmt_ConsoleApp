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
            _developerRepo.DisplayRepo();
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
                        _developerRepo.DisplayListOfDevelopers();
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
                        _developerRepo.AddNewDeveloper();
                        break;
                    case "2":
                        _developerRepo.UpdateDeveloper();
                        break;
                    case "3":
                        _developerRepo.DeleteExistingDeveloper();
                        break;
                    case "4":
                        _developerRepo.DisplayListOfDevelopers();
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
        
        
        // Seed to field method
        //private void SeedDevList()
        //{
        //    _developerRepo.SeedDevListRepo();

        //    Developer dev1 = new Developer(001, "Amanda Knight", true, TeamNumber.Team1);
        //    Developer dev2 = new Developer(002, "Colin Dunn", false, TeamNumber.Team2);
        //    Developer dev3 = new Developer(003, "Danny Redden", true, TeamNumber.Team3);
        //    Developer dev4 = new Developer(004, "Dillan Groce", false, TeamNumber.Team4);
        //    Developer dev5 = new Developer(005, "Andrew Dabbs", true, TeamNumber.Team5);
        //    Developer dev6 = new Developer(006, "Fabiola Aguilera", false, TeamNumber.Team1);
        //    Developer dev7 = new Developer(007, "Forrest Ryan", true, TeamNumber.Team2);
        //    Developer dev8 = new Developer(008, "Garry Banks", false, TeamNumber.Team3);
        //    Developer dev9 = new Developer(009, "Isiah Elder", true, TeamNumber.Team4);
        //    Developer dev10 = new Developer(010, "Jade Neff", false, TeamNumber.Team5);
        //    Developer dev11 = new Developer(011, "Jamar Watkins", true, TeamNumber.Team1);
        //    Developer dev12 = new Developer(012, "Jeremy Francoeur", false, TeamNumber.Team2);
        //    Developer dev13 = new Developer(013, "Joshua Middleton", true, TeamNumber.Team3);
        //    Developer dev14 = new Developer(014, "Keith Ping", false, TeamNumber.Team4);
        //    Developer dev15 = new Developer(015, "Leslie Counterman", true, TeamNumber.Team5);
        //    Developer dev16 = new Developer(016, "Mason Mobley", false, TeamNumber.Team1);
        //    Developer dev17 = new Developer(017, "Nabil Diaf", true, TeamNumber.Team2);
        //    Developer dev18 = new Developer(018, "Nathan Foreman", false, TeamNumber.Team3);
        //    Developer dev19 = new Developer(019, "Peter Nikolov", true, TeamNumber.Team4);
        //    Developer dev20 = new Developer(020, "Rex Meyer", false, TeamNumber.Team5);
        //    Developer dev21 = new Developer(021, "Samuel Rodriguez", true, TeamNumber.Team1);
        //    Developer dev22 = new Developer(022, "Savanah Jackson", false, TeamNumber.Team2);
        //    Developer dev23 = new Developer(023, "LaToya Harvell", true, TeamNumber.Team3);
        //    Developer dev24 = new Developer(024, "Tristan Auer", false, TeamNumber.Team4);
        //    Developer dev25 = new Developer(025, "Vanessa Nance", true, TeamNumber.Team5);


        //    _developerRepo.AddDeveloperToRepo(dev1);
        //    _developerRepo.AddDeveloperToRepo(dev2);
        //    _developerRepo.AddDeveloperToRepo(dev3);
        //    _developerRepo.AddDeveloperToRepo(dev4);
        //    _developerRepo.AddDeveloperToRepo(dev5);
        //    _developerRepo.AddDeveloperToRepo(dev6);
        //    _developerRepo.AddDeveloperToRepo(dev7);
        //    _developerRepo.AddDeveloperToRepo(dev8);
        //    _developerRepo.AddDeveloperToRepo(dev9);
        //    _developerRepo.AddDeveloperToRepo(dev10);
        //    _developerRepo.AddDeveloperToRepo(dev11);
        //    _developerRepo.AddDeveloperToRepo(dev12);
        //    _developerRepo.AddDeveloperToRepo(dev13);
        //    _developerRepo.AddDeveloperToRepo(dev14);
        //    _developerRepo.AddDeveloperToRepo(dev15);
        //    _developerRepo.AddDeveloperToRepo(dev16);
        //    _developerRepo.AddDeveloperToRepo(dev17);
        //    _developerRepo.AddDeveloperToRepo(dev18);
        //    _developerRepo.AddDeveloperToRepo(dev19);
        //    _developerRepo.AddDeveloperToRepo(dev20);
        //    _developerRepo.AddDeveloperToRepo(dev21);
        //    _developerRepo.AddDeveloperToRepo(dev22);
        //    _developerRepo.AddDeveloperToRepo(dev23);
        //    _developerRepo.AddDeveloperToRepo(dev24);
        //    _developerRepo.AddDeveloperToRepo(dev25);
        //}

    }
}

