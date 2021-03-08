using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TeamMember> teamMembers = new List<TeamMember>()
            {
               new TeamMember("Austin", 10, 2),
               new TeamMember("Emily", 5, 0.8),
               new TeamMember("Maya", 8, 1.1)
            };

            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("Enter a Team Member's Name");
            string memberName = Console.ReadLine();
            Console.WriteLine("Enter a Team Member's Skill Level");
            string memberSkillLevel = Console.ReadLine();
            Console.WriteLine("Enter a Team Member's Courage Level");
            string memberCourageLevel = Console.ReadLine();
            Console.WriteLine($"{memberName}, {memberSkillLevel}, {memberCourageLevel}");
        }
    }
}
