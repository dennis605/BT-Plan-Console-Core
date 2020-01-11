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


        // Erstelle Mitarbeiter.
        public int SaveMitarbeitertoDB (string vname, string nname)
        {
            using (Context db = new Context())
            {
                Person p1 = new Person();
                p1.Vorname = vname;
                p1.Nachname = nname;
                p1.Rolle = "Mitarbeiter";
                db.Personen.Add(p1);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Fragt Input für neuen Mitarbeiter ab und erstellt diesen über SaveMitarbveitertoDB.
        /// </summary>
        
        public void CreateMA()
        {
            Console.WriteLine("Vorname:");
            string vname = Console.ReadLine();
            Console.WriteLine("Nachname:");
            string nnachname = Console.ReadLine();

            //Implementierung ob Mitarebiter schon existiert
            //TODO: Prüfung implementieren ob Mitarebiter schon existiert notwendig 

            if (true)
            {
                SaveMitarbeitertoDB(vname, nnachname);
            }



        }
    }
    }

