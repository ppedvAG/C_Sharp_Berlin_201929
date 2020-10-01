using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrzeugpark
{
    public interface IBewegbar
    {
        public int AnzahlRäder { get; set; }

        void BaueUnfall();
    }
}
