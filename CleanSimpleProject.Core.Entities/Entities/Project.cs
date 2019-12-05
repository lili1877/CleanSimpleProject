using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CleanSimpleProject.Core.Entities.Entities
{
    /// <summary>
    /// <para>This class present all properties for a construction project.
    /// actually all properties for a building during construction time</para>
    /// <param name="ProjectName">the name of the project</param>
    /// <param name="FirstPrice">the price that specified at the first</param>
    /// <param name="Place">distriction of the project</param
    /// <param name="Address">the address of the project</param>
    /// <param name="Employer">who is actually owner</param>
    /// <param name="Contractor">who is responsible for construction</param>
    /// <param name="Supervisor">who is supervisor and prepare progress report</param>
    /// <param name="Consultant">who consult the project</param>
    /// <param name="DelayReason">Delay Reason for sometimes project goes not in normal progress path</param>
    /// <param name="StartDate">the Data of Start</param>
    /// <param name="EndDate">the Date of the end of the project</param>
    /// <param name="ProgressPersent">the progress amount <example>30%</example></param>
    /// <param name="Pictures">a collection of Pictures which are relatedto the project</param>
    /// </summary>
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
