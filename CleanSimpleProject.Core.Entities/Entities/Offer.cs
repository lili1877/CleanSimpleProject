using System;
using System.ComponentModel.DataAnnotations;

namespace CleanSimpleProject.Core.Entities.Entities
{
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
