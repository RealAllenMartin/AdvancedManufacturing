using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public decimal Rating { get; set; }
        [Column(TypeName = "decimal(1,1)")]
        public int Reviews { get; set; }
        public string Pitch { get; set; } = string.Empty;
        public List<Service> Comments { get; set; } = new List<Service>();
        public int Cost { get; set; }
        public string CostPer { get; set; } = string.Empty;
    }
}