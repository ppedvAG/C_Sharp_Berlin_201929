using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Serialisierung
{
    public partial class Form1 : Form
    {
        //Benötigte Properties (Liste zum Speichern der Fahrzeuge und Zufallsgenerator)
        public List<Person> Personenliste { get; set; }
        public Random Generator { get; set; }

        public Form1()
        {
            InitializeComponent();

            //Initialisierung der Properties
            this.Personenliste = new List<Person>()
            {
                new Person("Anna Nass", 171, new DateTime(1994, 4, 12)),
                new Person("Rainer Zufall", 189, new DateTime(1988, 12, 6))
            };
            this.Generator = new Random();

            UpdateGui();
        }

        //Methode zum Update der GUI
        private void UpdateGui()
        {
            //Löschen der Listboxinhalte
            Lbx_Person.Items.Clear();

            //Einfügen der Fahrzeuge aus der Liste in die Listbox
            foreach (var person in Personenliste)
            {
                Lbx_Person.Items.Add(person);
            }
        }

        //Methode zum zufälligen Erstellen von Personen
        private Person NeueZufälligePerson()
        {
            string name = String.Empty;
            switch (Generator.Next(1, 6))
            {
                case 1:
                    name = "Anna";
                    break;
                case 2:
                    name = "Hugo";
                    break;
                case 3:
                    name = "Johann";
                    break;
                case 4:
                    name = "Maria";
                    break;
                case 5:
                    name = "Simon";
                    break;
            }
            switch (Generator.Next(1, 6))
            {
                case 1:
                    name += " Meier";
                    break;
                case 2:
                    name += " Schmidt";
                    break;
                case 3:
                    name += " Fischer";
                    break;
                case 4:
                    name += " Müller";
                    break;
                case 5:
                    name += " Becker";
                    break;
            }
            return new Person(name, Generator.Next(130, 200), new DateTime(Generator.Next(1940, 2020), Generator.Next(1, 13), Generator.Next(1, 28)));
        }

        private void Btn_New_Click(object sender, EventArgs e)
        {
            //Erstellen einer zufälligen neuen Person und Eintrag in die Personenliste
            Personenliste.Add(NeueZufälligePerson());
            //Updaten der GUI
            UpdateGui();
        }

        //Methode zum Löschen markierter Fahrzeugen
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            //Löschen des in der ListBox markierten Items aus der Personenliste
            Personenliste.Remove(Lbx_Person.SelectedItem as Person);
            //Updaten der GUI
            UpdateGui();
        }

        //Methode zum Abspeichern von Fahrzeugen (vgl. auch LadeFZ)
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("personen.txt"))
                {
                    for (int i = 0; i < Personenliste.Count; i++)
                    {
                        string personAlsString = JsonConvert.SerializeObject(Personenliste[i]);

                        writer.WriteLine(personAlsString);
                    }
                }

                MessageBox.Show("Speichern erfolgreich");
            }
            catch
            {
                MessageBox.Show("Speichern fehlgeschlagen");
            }
        }

        //Methode zum Laden einer 'Fahrzeug'-Datei (vgl. auch SpeichernUndLaden.Form1.LadeText())
        private void Btn_Load_Click(object sender, EventArgs e)
        {
            try
            {
                List<Person> tempPersonen = new List<Person>();

                using (StreamReader reader = new StreamReader("personen.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        //Lesen einer Textzeile aus der Datei
                        string personAlsString = reader.ReadLine();
                        //Umwandlung der Textzeile in ein Fahrzeug (Beachte die Übergabe des Settings-Objekts)
                        Person person = JsonConvert.DeserializeObject<Person>(personAlsString);
                        //Hinzufügen des Fahrzeugs zur Liste
                        tempPersonen.Add(person);
                    }
                }

                Personenliste = tempPersonen;

                UpdateGui();

            }
            catch
            {
                MessageBox.Show("Laden fehlgeschlagen");
            }
        }
    }
}
