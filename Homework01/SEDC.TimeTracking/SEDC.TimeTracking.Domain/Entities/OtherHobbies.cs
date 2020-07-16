using SEDC.TimeTracking.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTracking.Domain.Entities
{
    public class OtherHobbies : BaseActivity
    {
        public string HobbyName { get; set; }
        public OtherHobbies()
        {
            ActivityType = ActivityType.OtherHobbies;
        }
    }
}
