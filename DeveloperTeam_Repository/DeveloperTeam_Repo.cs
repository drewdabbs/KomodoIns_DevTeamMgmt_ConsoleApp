using Developer_ClassList;
using Developer_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeam_Repository
{
    public class DeveloperTeam_Repo
    {
        //public void SeedTeamLists() // May not be needed
        //{

        //}
        private readonly Developer_Repo _devTeamRepo = new Developer_Repo();
        // Team One: The Ravens.
        public void TeamOneListDevelopers()
        {
            Console.Clear();
            Console.WriteLine("");

            foreach (Developer developer in _devTeamRepo)
            {
                if (developer.PluralsightAccess != true)
                {
                    Console.WriteLine($"Employee ID #: {developer.EmployeeID}, with the name: {developer.FullName}" + $" has a Pluralsight License status of: {developer.PluralsightAccess} \n\n");
                }
            }
            Console.ReadKey();
        }

        // Team Two: The Bedouins.
        // Team Three: The Oracles.
        // Team Four: A Tribe Called Dev.
        // Team Five: The Night Owls.
    }
}
