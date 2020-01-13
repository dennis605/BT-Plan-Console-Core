using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_core
{
    public class Person
    {
        public Person() { }



        public int PersonId { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Rolle { get; set; }

        // Navigation Property für Event 

        //public ICollection<Event> Events { get; set; }
        public virtual List<PersonenEvent> PersonenEvents { get; set; }





        // Speichere Mitarbeiter oder Bewohner in Datenbank
        public static void SavePersontoDBB(string vname, string nname, string rolle)
        {
            using (Context db = new Context())
            {
                Person pers = new Person();
                pers.Vorname = vname;
                pers.Nachname = nname;
                pers.Rolle = rolle;
                db.Personen.Add(pers);
                var result = db.SaveChanges();
                Console.WriteLine("Check:Nachname: " + result);
}
        }
        /// <summary>
        /// Erfragt Daten für einen neue Person und gibt Parameter an SavePersontoDB weiter
        /// </summary>
        public static void CreatePerson(string vname, string nname, string rolle)
        {
            string _rolle = rolle;
      
            //Implementierung ob Mitarbeiter schon existiert

            if (CheckDBforDuplicate(vname, nname, _rolle))
            {
                Person.SavePersontoDBB(vname, nname, _rolle);
            }



        }
        
        // hier wird zu speichernde Person geprüft, ob schon in DB existiert -> gibt true zurück, wenn speichern möglich ist
        public static bool CheckDBforDuplicate(string vname, string nnachname, string rolle)

        {
            using (Context db = new Context())
            {
                if (db.Personen.Any(x => x.Nachname == nnachname))
                {
                    if (db.Personen.Any(x => x.Vorname == vname))
                    {
                        if (db.Personen.Any(x => x.Rolle == rolle))
                        {
                            Console.WriteLine($"Person ({vname} {nnachname} mit Rolle {rolle} existiert schon in DB");
                            return false;

                        }
                    }

                }
                Console.WriteLine("Person kann hinzugefügt werden");
                return true;
            }

        }

        public void getPerson() // Mitarbeiter oder Bewohner
        {
            //TODO: alle Personen mit Rolle ausgeben
        }
        public void getPersonsZuEvent () // alle Mitarbeiter und/ oder Bewohner zu Event
        {
            //TODO: alle Personen mit Rolle für Event X ausgeben
        }

        public void getEventsForPerson () // alle Events zu Mitarbeiter oder Bewohner
        {
            //TODO: alle Events für Personen X mit rolle ausgeben

        }

    }
}
        
    


 


