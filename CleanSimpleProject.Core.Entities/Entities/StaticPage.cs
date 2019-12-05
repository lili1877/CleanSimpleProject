using System;
using System.ComponentModel.DataAnnotations;

namespace shaffaf.Models {
    public class StaticPage {
      
        
        public int Id { get; set; }
        public string MenuName { get; set; }
         public string PageName { get; set; }
          public string PageText { get; set; }
    }
}
