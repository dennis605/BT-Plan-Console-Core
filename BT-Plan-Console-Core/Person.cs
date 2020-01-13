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

                //if (!db.Personen.Any(x => x.Nachname == p1.Nachname))
                //{
                //    db.Personen.Add(p1);
                //    var result = db.SaveChanges();
                //    Console.WriteLine("Check:Nachname: " + result);
                //}
                //else if (!db.Personen.Any(x => x.Vorname == p1.Vorname))
                //{
                //    db.Personen.Add(p1);
                //    var result = db.SaveChanges();
                //    Console.WriteLine("Check:Vname: " + result);

                //}
                //else if (!db.Personen.Any(x => x.Rolle == p1.Rolle))
                //{
                //    db.Personen.Add(p1);
                //    var result = db.SaveChanges();
                //    Console.WriteLine("Check:Rolle: " + result);

                //}
                //// hier wenn Rolle, Nachname und Vorname in dieser Kombination bereits existiert
                //else
                //{
                //    Console.WriteLine("Kombination aus Rolle, Nachname, und Vorname bereits vorhanden");
                //}

            }
        }
        /// <summary>
        /// Erfragt Daten für einen neuen Bewohner und gibt Parameter an SavePersontoDB weiter
        /// </summary>
        public static void CreateBewohner()
        {
            string rolle = "Bewohner";
            Console.WriteLine("Vorname:");
            string vname = Console.ReadLine();
            Console.WriteLine("Nachname:");
            string nnachname = Console.ReadLine();

            //Implementierung ob Mitarbeiter schon existiert
            //TODO: Prüfung implementieren ob Mitarebiter schon existiert notwendig 

            if (CheckDBforDuplicate(vname, nnachname, rolle))
            {
                Person.SavePersontoDBB(vname, nnachname, rolle);
            }



        }
        /// <summary>
        ///         /// Erfragt Daten für einen neuen Mitarbeiter und gibt Parameter an SavePersontoDB weiter
        /// </summary>
        public static void CreateMitarbeiter()
        {
            string rolle = "Mitarbeiter";
            Console.WriteLine("Vorname:");
            string vname = Console.ReadLine();
            Console.WriteLine("Nachname:");
            string nnachname = Console.ReadLine();

            //Implementierung ob Mitarebiter schon existiert
            //TODO: Prüfung implementieren ob Mitarebiter schon existiert notwendig 

            if (CheckDBforDuplicate(vname, nnachname, rolle))
            {
                Person.SavePersontoDBB(vname, nnachname, rolle);
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
                            Console.WriteLine("Person mit dieser Rolle existiert schon in DB");
                            return false;

                        }
                    }

                }
                Console.WriteLine("Person kann hinzugefügt werden");
                return true;
            }

        }

    }
}
        
    


 


