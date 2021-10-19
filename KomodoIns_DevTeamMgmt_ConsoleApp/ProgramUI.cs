using Developer_ClassList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoIns_DevTeamMgmt_ConsoleApp
{
    public class ProgramUI
    {
        private readonly List<Developer> _devList = new List<Developer>();
        public void Run()
        {
            Display();
            SeedDevList();
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
        public void RunMenu()
        {

            bool continueToRun = true;
            while (continueToRun)
            {


                Console.WriteLine("\n\n\nPlease log in with your Employee ID:");
                int logIn = Convert.ToInt32(Console.ReadLine());

                foreach (int logIn in _devList.EmployeeID)
                {

                }


                //Console.WriteLine("\n\n\nPlease log in with your first and last name:");
                //string empName = Console.ReadLine();
                //foreach(string empName in _devList.)
                //{

                //}
            }

        }
        private void AddNewDeveloper()
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
            Console.WriteLine("\nFinally, which team should the new deeloper be assigned to:\n" +
                "1. For Team One." +
                "2. For Team Two." +
                "3. For Team Three." +
                "4. For Team Four." +
                "5. For Team Five." +
                " or 6. For Team Six.");
            string teamAssignment = Console.ReadLine();
            switch (teamAssignment)
            {
                case "1":
                    newDev.TeamNum = TeamNumber.Team1;
                    Console.WriteLine("New developer has been assigned to Team One.");
                    break;
                case "2":
                    newDev.TeamNum = TeamNumber.Team2;
                    Console.WriteLine("New developer has been assigned to Team Two.");
                    break;
                case "3":
                    newDev.TeamNum = TeamNumber.Team3;
                    Console.WriteLine("New developer has been assigned to Team Three.");
                    break;
                case "4":
                    newDev.TeamNum = TeamNumber.Team4;
                    Console.WriteLine("New developer has been assigned to Team Four.");
                    break;
                case "5":
                    newDev.TeamNum = TeamNumber.Team5;
                    Console.WriteLine("New developer has been assigned to Team Five.");
                    break;
                case "6":
                    newDev.TeamNum = TeamNumber.Team6;
                    Console.WriteLine("New developer has been assigned to Team Six.");
                    break;
                default:
                    Console.WriteLine("Please enter in a valid number between 1-6");
                    break;
            }
            _devList.Add(newDev);
        }
        private void SeedDevList()
        {
            Developer dev1 = new Developer(001, "Amanda Knight", true, TeamNumber.Team1);

            _devList.Add(dev1);
        }
    }
}
