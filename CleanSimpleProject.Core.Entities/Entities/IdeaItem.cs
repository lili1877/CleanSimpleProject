using System;
using System.Collections.Generic;
using System.Text;

namespace CleanSimpleProject.Core.Entities.Entities
{
    public class IdeaItem
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Order { get; set; }
        public int Number { get; set; }
        public int IdeaMainId { get; set; }
        public IdeaMain IdeaMain;

    }
}
