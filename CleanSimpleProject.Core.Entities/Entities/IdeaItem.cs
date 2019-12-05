using System;
using System.Collections.Generic;
using System.Text;

namespace CleanSimpleProject.Core.Entities.Entities
{
    // <summary>
    /// <para>this Entity determine Options for each Idea with <paramref name="IdeaMainId"/> </para>
    /// /// <param name="Id">Primary Key</param>
    /// <param name="ItemName">The name of Item</param
    /// <param name="Order">get a priority to each item</param>
    /// <param name="Number">determine how many people select this option </param>
    /// </summary>
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
