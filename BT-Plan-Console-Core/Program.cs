using ConsoleApp_core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Plan_Console_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.CreateMA();

            //using (Context db = new Context())
            //{
            //    Person p1 = new Person();
            //    p1.Vorname = "Dennis";
            //    p1.Nachname = "Schonig";
            //    p1.Rolle = "Bewohner";
            //    db.Personen.Add(p1);
            //    db.SaveChanges();
            //}
        }
    }
}
