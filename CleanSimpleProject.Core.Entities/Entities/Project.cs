using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CleanSimpleProject.Core.Entities.Entities
{
    public class Project {

        public Project()
        {
            Pictures = new HashSet<ProjectPic>();
        }
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string FirstPrice{ get; set; }
          public string Place{ get; set; }
         public string Address { get; set; }
          public string Employer{ get; set; }
           public string Contractor{ get; set; }
          public string Supervisor{ get; set; }
           public string Consultant{ get; set; }
          public string DelayReason{ get; set; }
         public string StartDate{ get; set; }
          public string EndDate { get; set; }
          public string ProgressPersent{ get; set; }
        public ICollection<ProjectPic> Pictures{ get; private set; }
    }
}
