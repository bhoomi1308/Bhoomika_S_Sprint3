using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BhoomikaSadashiva_Sprint2.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        public string? Name { get; set; }

        public string? Detail { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
