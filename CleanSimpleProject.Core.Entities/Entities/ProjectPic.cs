using System;
using System.ComponentModel.DataAnnotations;

namespace shaffaf.Models {
    public class ProjectPic {
      
        
        public int Id { get; set; }
        public Byte Type { get; set; }
        public string Date { get; set; }
        public byte[] Pic { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
