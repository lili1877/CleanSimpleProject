using System;
using System.ComponentModel.DataAnnotations;

namespace CleanSimpleProject.Core.Entities.Entities
{
    /// <summary>
    /// <para>the pictures which are related to each project the is detemined with <paramref name="ProjectId"/></para>
    /// /// <param name="Id">Primary Key</param>
    /// <param name="Type">it has 2 type 2D,3D</param
    /// <param name="Date">the date that photo is taken</param>
    /// <param name="Pic">save the file of pic in binary</param>
    /// </summary>
    public class ProjectPic {
      
        
        public int Id { get; set; }
        public Byte Type { get; set; }
        public string Date { get; set; }
        public byte[] Pic { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
