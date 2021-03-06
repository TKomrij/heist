using System;
using System.Collections.Generic;

namespace heist
{
    public class TeamMember
    {
        public string Name { get; set; }
        public double SkillLevel { get; set; }
        public double CourageFactor { get; set; }


        public TeamMember(string name, int skillLevel, double courageFactor)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;
        }
    }
}