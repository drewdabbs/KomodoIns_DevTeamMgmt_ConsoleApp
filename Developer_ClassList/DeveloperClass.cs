﻿using KomodoIns_DevTeamMgmt_ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_ClassList
{
    public enum TeamNumber { Team1 = 1, Team2, Team3, Team4, Team5, Team6 }
    public class Developer : KomodoIns_DevTeamMgmt_ConsoleApp.IEmployee
    {
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public bool PluralsightAccess { get; set; }
        public TeamNumber TeamNum { get; set; }
        public Developer() { }
        public Developer(int employeeID, string fullName, bool pluralAccess, TeamNumber tNum)
        {
            EmployeeID = employeeID;
            FullName = fullName;
            PluralsightAccess = pluralAccess;
            TeamNum = tNum;
        }
    }
}