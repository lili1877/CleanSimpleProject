using System;
using System.ComponentModel.DataAnnotations;

namespace CleanSimpleProject.Core.Entities.Entities
{
    /// <summary>
    /// <para>The Offer specify Angebot </para>
    /// <param name="Id">Primary Key</param>
    /// <param name="subject">The main subject</param
    /// <param name="source">The source of Angebot. maybe it be anorganization </param>
    /// <param name="type">there are 2 type 1-minimum_price fur buying 2-maximum_price for selling </param>
    /// <param name="startDate">start date for participating in Angebot</param>
    /// <param name="endDate">final date for participating in Angebot</param>
    /// <param name="fileName">the name of angebot file</param>
    /// <param name="file">the file of Angebot that usually present to determine all properties of angebot</param>
    /// </summary
    public class Offer
    {
        public int Id { get; set; }
        public string subject { get; set; }
        public string source { get; set; }
        public string type { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string fileName { get; set; }
        public byte[] file { get; set; }
    }
}
