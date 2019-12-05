using System;
using System.ComponentModel.DataAnnotations;

namespace CleanSimpleProject.Core.Entities.Entities
{
    /// <summary>
    /// <para>this Entity determine each static page </para>
    /// /// <param name="Id">Primary Key</param>
    /// <param name="MenuName">The name of static page in menu in mainpage</param
    /// <param name="PageName">The name of static page that specify in the header of the page</param>
    /// <param name="PageText">Main text of the page</param>
    /// </summary>
    public class StaticPage {

        public int Id { get; set; }
        public string MenuName { get; set; }
        public string PageName { get; set; }
        public string PageText { get; set; }
    }
}
