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
            Console.WriteLine("Was möchtest Du der Datenbank hinzufügen? (Mitarbeiter,Bewohner)");
            string entsch = Console.ReadLine();

            switch (entsch)
            {
                case ("Mitarbeiter"): // Möchte Mitarbeiter erstellen
                    string rolle = "Mitarbeiter";
                    Console.WriteLine("Vorname:");
                    string vname = Console.ReadLine();
                    Console.WriteLine("Nachname:");
                    string nnachname = Console.ReadLine();
                    Person.CreateMitarbeiter(vname, nnachname);
                    break;
                case ("Bewohner"): // Möchte Bewohner erstellen
                    string rolle_b = "Bewohner";
                    Console.WriteLine("Vorname:");
                    string vname_b = Console.ReadLine();
                    Console.WriteLine("Nachname:");
                    string nnachname_b = Console.ReadLine();
                    Person.CreateBewohner(vname_b, nnachname_b);
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl"); // ungültige Auswahl getroffen
                    break;
                    
            }
            Console.ReadKey();

            
        }
    }
}
