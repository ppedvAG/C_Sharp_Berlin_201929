using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    //Ein DELEGATE ist eine Variable, in welcher man Funktionen mit einem gleichen Methodenkopf speichern kann. Eigene Delegate-Typen müssen
    ///vorher definiert werden.
    public delegate int MeinDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            //Zuweisung der Addiere()-Methode zur einer Variablen vom Typ MyDelegate
            MeinDelegate delegateVariable = Addiere;

            //Ausführung der Delegate-Variablen
            int ergebnis = delegateVariable(12, 45);
            Console.WriteLine(ergebnis);

            //Neuzuweisung der Variable (Kurzschreibweise)
            delegateVariable = Subtrahiere;

            ergebnis = delegateVariable(12, 45);
            Console.WriteLine(ergebnis);

            //Zuweisung einer zweiten Methode zur Delegate-Variablen
            delegateVariable += Addiere;

            //Bei Ausführung einer Delegate-Variablen werden alle referenzierten Methoden in der Reihenfolge ihrer Zuweisung ausgeführt.
            ///Nur die letzte Methode gibt einen Rückgabewert zurück
            ergebnis = delegateVariable(12, 45);
            Console.WriteLine(ergebnis);

            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            delegateVariable += Addiere;
            
            //Erstellen und Ausgabe einer Liste der in der Variablen gespeicherten Methode
            foreach (var item in delegateVariable.GetInvocationList().ToList())
            {
                Console.WriteLine(item.Method);
            }

            //Löschen einer Referenz aus der Variablen
            delegateVariable -= Subtrahiere;

            delegateVariable = null;


            //FUNC<> / ACTION<> /PREDICATE<> sind die von C# vordefinierten Delegate-Typen
            Func<int, int, int> meinFunc = Addiere;
            meinFunc += Subtrahiere;
            meinFunc(4, 8);

            FühreAus(Addiere);


            //ANONYME METHODEN sind Methoden, welche nicht mit Kopf und Körper geschrieben stehen, sondern nur innerhalb von Delegate-Variablen
            ///existieren

            //Übergabe einer Methode an eine andere Methode
            List<string> Städteliste = new List<string>() { "München", "Berlin", "Hamburg", "Köln", "Heidelberg" };

            string gefundeneStadt = Städteliste.Find(SucheStadtMitH);
            Console.WriteLine(gefundeneStadt);

            //Übergabe der Methode als anonyme Methode
            gefundeneStadt = Städteliste.Find(
                delegate (string stadt)
                {
                    return stadt.StartsWith("H");
                });

            //Übergabe der anonymen Methode in LAMBDA-Schreibweise (Lang und Kurz)
            gefundeneStadt = Städteliste.Find((string stadt) => { return stadt.StartsWith("H"); });
            gefundeneStadt = Städteliste.Find(stadt => stadt.StartsWith("H"));

            //Weiteres Bsp für die Übergabe einer anonymen Methode in Lambda (Sortierung der Einträge nach dem ersten Buchstaben)
            Städteliste = Städteliste.OrderBy(stadt => stadt[0]).ToList();
            foreach (var item in Städteliste)
            {
                Console.WriteLine(item);
            }

            //weiteres Bsp der Lambda-Schreibweise (Methode empfängt zwei int und gibt deren Summe als int zurück)
            meinFunc = delegate (int a, int b) { return a + b; };
            meinFunc = (a, b) => a + b;
        }

        //Bsp-Methode zur Übergabe an eine Liste
        public static bool SucheStadtMitH(string stadt)
        {
            //bool result = stadt.StartsWith("H");
            //return result;

            return stadt.StartsWith("H");
        }

        //Funktion mit Delegate-Übergabeparameter
        public static void FühreAus(Func<int, int, int> methode)
        {
            methode(47, 45);
        }

        //Funktion mit Delegate-Rückgabewert
        public static Func<int, int, int> BaueFunc()
        {
            return Addiere;
        }

        //Bsp-Methoden zur Demonstration der Delegate-Funktionalität
        public static int Addiere(int a, int b)
        {
            Console.WriteLine("Addition");
            return a + b;
        }

        public static int Subtrahiere(int a, int b)
        {
            Console.WriteLine("Subtraktion");
            return a - b;
        }
    }
}
