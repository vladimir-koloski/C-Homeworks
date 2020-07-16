using SEDC.TimeTracking.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTracking.Domain.Entities
{
    public class Working : BaseActivity
    {
        public WorkingType WorkingType { get; set; }

        public Working()
        {
            ActivityType = ActivityType.Working;
        }
    }
}
