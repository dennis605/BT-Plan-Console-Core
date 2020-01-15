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
            Console.WriteLine("Was möchtest Du der Datenbank hinzufügen? (Mitarbeiter,Bewohner) oder (Ausgabe) oder (Event) oder (Löschen)");
            string entsch = Console.ReadLine().ToLower();

            switch (entsch)
            {
                case ("mitarbeiter"): // Möchte Mitarbeiter erstellen
                    string rolle = "Mitarbeiter";
                    Console.WriteLine("Vorname:");
                    string vname = Console.ReadLine();
                    Console.WriteLine("Nachname:");
                    string nnachname = Console.ReadLine();
                    Person.CreatePerson (vname, nnachname, rolle);
                    break;
                case ("bewohner"): // Möchte Bewohner erstellen
                    string rolle_b = "Bewohner";
                    Console.WriteLine("Vorname:");
                    string vname_b = Console.ReadLine();
                    Console.WriteLine("Nachname:");
                    string nnachname_b = Console.ReadLine();
                    Person.CreatePerson(vname_b, nnachname_b, rolle_b);
                    break;

                case ("ausgabe"): // Möchte Bewohner erstellen                   
                    Person.getPerson("Mitarbeiter");
                    Console.WriteLine("\n");
                    Person.getPerson("Bewohner");
                    // Ausgabe aus getPersonsAsDictionary
                    var test = Person.getPersonsAsDictionary("Mitarbeiter");
                    foreach (var pers in test)
                    {
                        Console.WriteLine($"Vorname:{ pers.Vorname } Nachname:{ pers.Nachname} Rolle:{pers.Rolle}");
                    }

                    break;

                case ("event"): // Möchte Bewohner erstellen    
                    //Person.loeschePerson("Lisa", "Henken", "Mitarbeiter");
                    //Person.getPerson("Mitarbeiter");
                    //Console.WriteLine("\n");
                    //Person.getPerson("Bewohner");
                    //// Ausgabe aus getPersonsAsDictionary
                    //var test = Person.getPersonsAsDictionary("Mitarbeiter");
                    //foreach (var pers in test)
                    //{
                    //    Console.WriteLine($"Vorname:{ pers.Vorname } Nachname:{ pers.Nachname} Rolle:{pers.Rolle}");
                    //}

                    break;
                case ("löschen"): // Möchte Bewohner erstellen 
                    Console.WriteLine("Bitte zu löschenden Vornamen eingeben");
                    string delvname = Console.ReadLine();
                    Console.WriteLine("Bitte zu löschenden Nachnamen eingeben");
                    string delnname = Console.ReadLine();
                    Console.WriteLine("Bitte zu löschenden Rolle eingeben");
                    string delrolle = Console.ReadLine();

                    Person.loeschePerson(delvname, delnname, delrolle);
                    
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl"); // ungültige Auswahl getroffen gibt 


                    break;
                    
            }
            Console.ReadKey();

            
        }
    }
}
