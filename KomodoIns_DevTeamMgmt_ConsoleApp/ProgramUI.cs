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
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("\n\n\nPlease log in with your Employee ID:");
                int logIn = Convert.ToInt32(Console.ReadLine());
                if (logIn == )
                {

                }

            }
            //Console.WriteLine("\n\n\nPlease log in with your first and last name:");
            //Console.ReadLine();
        }
        private void SeedDevList()
        {
            Developer dev1 = new Developer(001, "Amanda Knight", true, TeamNumber.Team1);

            _devList.Add(dev1);
        }
    }
}
