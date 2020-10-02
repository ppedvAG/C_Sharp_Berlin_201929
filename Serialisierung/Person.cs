using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialisierung
{
    public class Person
    {
        //Modelklasse für das Projekt (vgl. Fahrzeugpark.Fahrzeug)

        public string Name { get; set; }

        public int Größe { get; set; }

        public DateTime Geburtsdatum { get; set; }


        public Person(string name, int größe, DateTime gebDatum)
        {
            this.Name = name;
            this.Größe = größe;
            this.Geburtsdatum = gebDatum;
        }

        public override string ToString()
        {
            return $"{this.Name} ({this.Größe} cm), {this.Geburtsdatum.ToShortDateString()}";
        }
    }
}
