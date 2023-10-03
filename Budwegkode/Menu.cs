using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budwegkode
{
    public class Menu      // Denne klasse styrer de metoder der skal bruges i vores system. 
    {
        public Menu(string title)     // Constructor til "Menu"-klassen. 
        {
            Title = title;
        }
        public string Title;
        /*
        private Medarbejder[] medarbejderListe = new Medarbejder[200];
        private Afdeling[] afdelingsListe = new Afdeling[30];
        private string[] fremmødteListe = new string[200];
        */


        DataHandler handler = new DataHandler(@"..\..\..\Medarbejderliste.txt");
        StreamReader sr = new StreamReader(@"..\..\..\Medarbejderliste.txt");

        /*
        public void SeMedarbejdere()
        {
            for (int i = 0; i < medarbejderAntal; i++)          // Denne metode printer navn og ID for alle medarbejdere. 
            {
                Console.WriteLine(medarbejderListe[i].Navn + "   :   " + medarbejderListe[i].UserID);
            }
        }
        */

        public bool TjekMedarbejder(string UserID)        // Denne metode tager et "UserID" som input, og tjekker om det findes i listen af ID'er. 
        {
            string[] Lines = sr.ReadToEnd().Split("\n");

            UserID = UserID.ToUpper();                   // Omdanner lower-case bogstaver til upper-case. 
            bool user = false;
            for (int i = 0; i < Lines.Length; i++)
            {
                string[] Data = Lines[i].Split(";");
                if (Data[1] == UserID)
                {
                    user = true; break;
                }
            }
            return user;
        }
        public string GetMedarbejderNavn(string UserID)
        {
            UserID = UserID.ToUpper();
            string navn = "";
            for (int i = 0; i < medarbejderAntal; i++)
            {
                if (medarbejderListe[i].UserID == UserID)
                {
                    navn = medarbejderListe[i].Navn; break;
                }
            }
            return navn;
        }
        public string GetMedarbejderRolle(string UserID)
        {
            UserID = UserID.ToUpper();
            string navn = "";
            for (int i = 0; i < medarbejderAntal; i++)
            {
                if (medarbejderListe[i].UserID == UserID)
                {
                    navn = medarbejderListe[i].Rolle; break;
                }
            }
            return navn;
        }
    }
}
