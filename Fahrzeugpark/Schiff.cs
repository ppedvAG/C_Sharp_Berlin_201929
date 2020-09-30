﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrzeugpark
{
    //vgl. auch PKW
    public class Schiff : Fahrzeug
    {
        //Klassen-eigener Enumerator
        public enum SchiffsTreibstoff { Diesel = 0, Dampf, Wind, Muskelkraft }
        public SchiffsTreibstoff Treibstoff { get; set; }

        public Schiff(string name, int maxG, decimal preis, SchiffsTreibstoff treibstoff) : base(name, maxG, preis)
        {
            this.Treibstoff = treibstoff;
        }

        public override string BeschreibeMich()
        {
            return "Das Schiff " + base.BeschreibeMich() + $" Es fährt mit {this.Treibstoff}.";
        }

        public override void Hupen()
        {
            Console.WriteLine("Trööööt");
        }
    }
}
