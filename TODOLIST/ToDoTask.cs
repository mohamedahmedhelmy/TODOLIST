using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo;

namespace ToDo
{
    public class ToDoTask
    {
        public ToDoTask() { }
        public ToDoTask(string details, Priority priority)
        {
            Details = details;
            Priority = priority;
        }
        public Guid GuidId { get; set; }

        public string Details { get; set; } = string.Empty;
        public Priority Priority { get; set; }


    }
}
