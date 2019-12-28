using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_core
{
    public class PersonenEvent
    {
        
        public int EventId { get; set; }
        public Event Event { get; set; }

        public Person Person { get; set; }
        public int PersonId { get; set; }
    }
}
