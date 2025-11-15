using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Service
    {
        public int Id { get; set; }
        public String Main { get; set; } = string.Empty;
        public String Sub { get; set; } = string.Empty;
        public int? CompanyId { get; set; }
        // Navigation
        public Company? Company { get; set; }
    }
}