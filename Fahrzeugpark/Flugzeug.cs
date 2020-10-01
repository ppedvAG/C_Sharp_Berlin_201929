using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrzeugpark
{
    //vgl auch PKW
    public class Flugzeug : Fahrzeug, IBewegbar
    {
        public int MaxFlughöhe { get; set; }
        public int AnzahlRäder { get; set; }

        public Flugzeug(string name, int maxG, decimal preis, int maxFH) : base(name, maxG, preis)
        {
            this.MaxFlughöhe = maxFH;
            this.AnzahlRäder = 8;
        }

        public override string BeschreibeMich()
        {
            return "Das Flugzeug " + base.BeschreibeMich() + $" Es kann bis auf {this.MaxFlughöhe}m aufsteigen.";
        }

        public override void Hupen()
        {
            Console.WriteLine("BiepBiep");
        }

        public void BaueUnfall()
        {
            Console.WriteLine("Du hast den Vogel übersehen");
        }
    }
}
