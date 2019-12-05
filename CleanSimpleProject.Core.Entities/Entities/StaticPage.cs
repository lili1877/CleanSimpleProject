using System;
using System.ComponentModel.DataAnnotations;

namespace CleanSimpleProject.Core.Entities.Entities
{
    public class StaticPage {
      
        
        public int Id { get; set; }
        public string MenuName { get; set; }
         public string PageName { get; set; }
          public string PageText { get; set; }
    }
}
