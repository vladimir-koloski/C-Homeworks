using SEDC.TimeTracking.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTracking.Domain.Entities
{
    public class Reading : BaseActivity
    {
        public int Pages { get; set; }
        public ReadingType ReadingType { get; set; }
        public Reading()
        {
            ActivityType = ActivityType.Reading;
        }

    }
}
