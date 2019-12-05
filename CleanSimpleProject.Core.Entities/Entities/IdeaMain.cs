using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CleanSimpleProject.Core.Entities.Entities
{
    public class IdeaMain {
      
        
        public int Id { get; set; }
        public string Idea{ get; set; }
        public int Priority{ get; set; }
        public bool Active{ get; set; }
        public ICollection<IdeaItem> Items{ get; set; }
    }

   
}
