using System;

namespace StructVsClass
{
    class PersonC
    {
        public int alter;
        public string name;

        public PersonC(string name, int alter)
        {
            this.name = name;
            this.alter = alter;
        }
    }

    struct PersonS
    {
        public int alter;
        public string name;

        public PersonS(string name, int alter)
        {
            this.name = name;
            this.alter = alter;
        }
    }

    class Program
    {
        public static void Altern (PersonC person)
        {
            person.alter++;
        }

        public static void Altern (PersonS person)
        {
            person.alter++;
        }

        public static void Altern (ref PersonS person)
        {
            person.alter++;
        }

        static void Main(string[] args)
        {
            PersonC classPerson = new PersonC("Hugo", 30);
            PersonS structPerson = new PersonS("Anna", 30);

            Console.WriteLine($"{classPerson.name}: {classPerson.alter}");
            Console.WriteLine($"{structPerson.name}: {structPerson.alter}");

            Altern(classPerson);
            Altern(structPerson);

            Console.WriteLine($"{classPerson.name}: {classPerson.alter}");
            Console.WriteLine($"{structPerson.name}: {structPerson.alter}");

            Altern(ref structPerson);
            Console.WriteLine($"{structPerson.name}: {structPerson.alter}");
        }
    }
}
