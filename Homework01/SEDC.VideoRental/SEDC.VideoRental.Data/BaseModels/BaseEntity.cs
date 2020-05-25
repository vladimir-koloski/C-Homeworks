using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.VideoRental.Data.BaseModels
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }

        public BaseEntity()
        {
            CreatedOn = DateTime.Now;
        }
    }
}
