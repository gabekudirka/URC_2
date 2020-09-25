using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace URC_2.Models
{
    public class Opportunity
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public string ProfessorFirstName { get; set; }
        public string ProfessorLastName { get; set; }
        public string Image { get; set; }
        public string Mentor { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Pay { get; set; }
        public Boolean Filled { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<Skill> RequiredSkills { get; set; }
    }
}