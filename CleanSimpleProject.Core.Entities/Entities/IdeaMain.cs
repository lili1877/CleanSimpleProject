using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CleanSimpleProject.Core.Entities.Entities
{
    /// <summary>
    /// <para>this Entity determine each Idea </para>
    /// /// <param name="Id">Primary Key</param>
    /// <param name="Idea">the main sentence of Idea</param
    /// <param name="Priority">The Idea with maximum Priority is put in the first</param>
    /// <param name="Active">each idea can be active or unactive </param>
    /// <param name="Items">options for voting</param>
    /// </summary>
    public class IdeaMain {
        public IdeaMain()
        {
            Items = new HashSet<IdeaItem>();
        }
        public int Id { get; set; }
        public string Idea{ get; set; }
        public int Priority{ get; set; }
        public bool Active{ get; set; }
        public ICollection<IdeaItem> Items{ get; private set; }
    }

   
}
