using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BhoomikaSadashiva_Sprint2.Models
{
    public class TaskModel
    {
        public int TaskId { get; set; }

        public int ProjectId { get; set; }

        public int Status { get; set; }
        public int AssignedUserId { get; set; }

        public string Detail { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
