using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_core
{
    public class Event
    {
        public int EventId { get; set; }
        private string EventName { get; set; }

        private DateTime EventDatum { get; set; }
        private DateTime EventBeginn { get; set; }
        public DateTime EventEnd { get; set; }
        public int EventVorlauf { get; set; }
        public string EventOrt { get; set; }
        public string EventBeschreibung { get; set; }
        public string EventInfo { get; set; }

        // Navigation Property für Person
        //public ICollection<Person> Persons { get; set; }
        public virtual List<PersonenEvent> PersonenEvents { get; set; }

    }
}
