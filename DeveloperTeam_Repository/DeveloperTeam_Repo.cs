using Developer_ClassList;
using Developer_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTeam_Repository

//    Our managers need to be able to add and remove members to/from a team by their unique identifier.They should be able to see a list of existing developers to choose from and add to existing teams.Odds are, the manager will create a team, and then add Developers individually from the Developer Directory to that team.

//Challenge: Our HR Department uses the software monthly to get a list of all our Developers that need a Pluralsight license. Create this functionality in the Console Application

//Challenge: Some of our managers are nitpicky and would like the functionality to add multiple Developers to a team at once, rather than one by one.Integrate this into your application.
{
    public class DeveloperTeam_Repo
    {
        //Add dev to team using Developer ID and Team ID

        //Remove dev from team using dev ID and team ID

        private readonly Developer_Repo _devRepo = new Developer_Repo();
        private readonly List<DevTeam> _teamList = new List<DevTeam>();

        public bool AddDeveloperTeamToRepo(DevTeam team)
        {
            int startingCount = _teamList.Count;
           _teamList.Add(team);
            bool wasAdded = _teamList.Count > startingCount ? true : false;
            return wasAdded;
        }
        public void TeamListRepo()
        {
            DevTeam team1 = new DevTeam(001, "The Ravens", null);
            DevTeam team2 = new DevTeam(002, "The Bedouins", null);
            DevTeam team3 = new DevTeam(003, "The Oracles", null);
            DevTeam team4 = new DevTeam(004, "The A Tribe Called Dev", null);
            DevTeam team5 = new DevTeam(005, "The Night Owls", null);

            AddDeveloperTeamToRepo(team1);
            AddDeveloperTeamToRepo(team2);
            AddDeveloperTeamToRepo(team3);
            AddDeveloperTeamToRepo(team4);
            AddDeveloperTeamToRepo(team5);
        }
        
        // Team One: The Ravens.        
        // Team Two: The Bedouins.
        // Team Three: The Oracles.
        // Team Four: A Tribe Called Dev.
        // Team Five: The Night Owls.
    }
}
