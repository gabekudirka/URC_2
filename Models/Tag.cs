using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace URC_2.Models
{
    public class Tag
    {
        public int ID { get; set; }
        public string OpportunityTag { get; set; }

        public int OpportunityID { get; set; }
    }
}
