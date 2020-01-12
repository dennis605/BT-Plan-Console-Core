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


        


        // Erstelle Person (Mitarebiter oder Bewohner.
        public static void SavePersontoDBB(string vname, string nname, string rolle)
        {
            using (Context db = new Context())
            {
                Person p1 = new Person();
                p1.Vorname = vname;
                p1.Nachname = nname;
                p1.Rolle = "Mitarbeiter";
                if (!db.Personen.Any(x => x.Nachname == p1.Nachname))
                {
                    db.Personen.Add(p1);
                  var result =   db.SaveChanges();
                    Console.WriteLine("Check:Nachname: " +result);
                }
                else if (!db.Personen.Any(x => x.Vorname == p1.Vorname))
                {
                    db.Personen.Add(p1);
                  var result =  db.SaveChanges();
                    Console.WriteLine("Check:Vname: " + result);

                }
                else if (!db.Personen.Any(x => x.Rolle == p1.Rolle))
                {
                    db.Personen.Add(p1);
                  var result =   db.SaveChanges();
                    Console.WriteLine("Check:Rolle: " + result);

                }

            }
        }
        /// <summary>
        /// Fragt Input für neuen Mitarbeiter ab und erstellt diesen über SaveMitarbveitertoDB.
        /// </summary>
        public static void CreateBewohner()
        {
            string rolle = "Bewohner";
            Console.WriteLine("Vorname:");
            string vname = Console.ReadLine();
            Console.WriteLine("Nachname:");
            string nnachname = Console.ReadLine();

            //Implementierung ob Mitarebiter schon existiert
            //TODO: Prüfung implementieren ob Mitarebiter schon existiert notwendig 

            if (CheckDBforDB(vname, nnachname, rolle))
            {
                Person.SavePersontoDBB(vname, nnachname, rolle);
            }



        }
        public static void CreateMitarbeiter()
        {
            string rolle = "Mitarbeiter";
            Console.WriteLine("Vorname:");
            string vname = Console.ReadLine();
            Console.WriteLine("Nachname:");
            string nnachname = Console.ReadLine();

            //Implementierung ob Mitarebiter schon existiert
            //TODO: Prüfung implementieren ob Mitarebiter schon existiert notwendig 

            if (CheckDBforDB(vname, nnachname, rolle))
            {
                Person.SavePersontoDBB(vname, nnachname, rolle);
            }



        }
        // hier wird zu speichernde Person geprüft, ob schon in DB existiert -> gibt true zurück, wenn speichern möglich ist
        public static bool CheckDBforDB(string vname, string nnachname, string rolle)
        {

           
            

            return true;
        } 
    }
    }

