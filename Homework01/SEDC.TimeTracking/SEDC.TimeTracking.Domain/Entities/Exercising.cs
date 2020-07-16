using SEDC.TimeTracking.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TimeTracking.Domain.Entities
{
    public class Exercising : BaseActivity
    {
        public ExercisingType ExercisingType { get; set; }

        public Exercising()
        {
            ActivityType = ActivityType.Exercising;
        }
        
    }
}
