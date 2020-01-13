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
                pers.Rolle = "Mitarbeiter";
                db.Personen.Add(pers);
                var result = db.SaveChanges();
                Console.WriteLine("Check:Nachname: " + result);
}
        }
        /// <summary>
        /// Erfragt Daten für einen neuen Bewohner und gibt Parameter an SavePersontoDB weiter
        /// </summary>
        public static void CreateBewohner(string vname, string nname)
        {
            string rolle = "Bewohner";
      
            //Implementierung ob Mitarbeiter schon existiert

            if (CheckDBforDuplicate(vname, nname, rolle))
            {
                Person.SavePersontoDBB(vname, nname, rolle);
            }



        }
        /// <summary>
        ///         /// Erfragt Daten für einen neuen Mitarbeiter und gibt Parameter an SavePersontoDB weiter
        /// </summary>
        public static void CreateMitarbeiter(string vname, string nname)
        {
            string rolle = "Mitarbeiter";

            if (CheckDBforDuplicate(vname, nname, rolle))
            {
                Person.SavePersontoDBB(vname, nname, rolle);
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

        public void getMitarbeiter()
        {
            //TODO: alle Mitarbeiter ausgeben
        }
        public void getMitarbeiterzuPlan ()
        {
            //TODO: alle Mitarbeiter für Event X ausgeben
        }

        public void getEventsforMitarbeiter ()
        {
            //TODO: alle Events für Mitarbeiter X ausgeben

        }

    }
}
        
    


 


