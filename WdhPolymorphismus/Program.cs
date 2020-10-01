using System;

namespace WdhPolymorphismus
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund hund1 = new Hund("Bello", "Braun");
            Console.WriteLine(hund1.Name);

            Meise meise1 = new Meise("Tschiep", "Blau");
            Console.WriteLine(meise1.Name);

            hund1.Name = "Hasso";

            Tier tier1 = hund1;
            Console.WriteLine(tier1.Name);

            tier1 = meise1;
            Console.WriteLine(tier1.Name);

            if(tier1 is Hund)
            {
                ((Hund)tier1).Fellfarbe = "Schwarz";
            }
            else
            {
                (tier1 as Meise).Federfarbe = "Rot";
                Meise meise2 = tier1 as Meise;
                Console.WriteLine(meise2.Federfarbe);
            }

            Flugzeug fz1 = new Flugzeug(250);

            IFlugfähig flugfähigesObjekt = meise1;

            flugfähigesObjekt.Abheben();

            Abstürzen(meise1);

            Abstürzen(fz1);


        }

        public static void Abstürzen(IFlugfähig flugfähig)
        {
            flugfähig.AnzahlFlügel--;

            if(flugfähig is Meise)
            {
                Console.WriteLine((flugfähig as Meise).Name + " ist abgestürzt");
            }
        }
    }

    public abstract class Tier
    {
        public string Name { get; set; }
        public int AnzahlBeinen { get; set; }

        public Tier(string name, int anzB)
        {
            this.Name = name;
            this.AnzahlBeinen = anzB;
        }
    }

    public class Hund : Tier
    {
        public string Fellfarbe { get; set; }

        public Hund(string name, string fellFarbe) : base(name, 4)
        {
            this.Fellfarbe = fellFarbe;
        }
    }

    public class Meise : Tier, IFlugfähig
    {
        public string Federfarbe { get; set; }
        public int AnzahlFlügel { get; set; }

        public Meise(string name, string federFarbe) : base(name, 2)
        {
            this.Federfarbe = federFarbe;
            this.AnzahlFlügel = 2;
        }

        public void Abheben()
        {
            Console.WriteLine("Meise fliegt!!");
        }
    }

    public class Flugzeug : IFlugfähig
    {
        public int AnzahlSitze { get; set; }
        public int AnzahlFlügel { get; set; }

        public Flugzeug(int anzS)
        {
            this.AnzahlSitze = anzS;
            this.AnzahlFlügel = 2;
        }

        public void Abheben()
        {
            Console.WriteLine("Takeoff");
        }
    }

    public interface IFlugfähig
    {
        public int AnzahlFlügel { get; set; }

        void Abheben();
    }
}
