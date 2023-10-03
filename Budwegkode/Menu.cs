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
            Medarbejder[] medarbejdere = handler.LoadMedarbejdere();

            UserID = UserID.ToUpper();                   // Omdanner lower-case bogstaver til upper-case. 
            bool user = false;
            for (int i = 0; i < medarbejdere.Length; i++)
            {
                if (medarbejdere[i].UserID == UserID)
                {
                    user = true; break;
                }
            }
            return user;
        }
        public string GetMedarbejderNavn(string UserID)
        {
            Medarbejder[] medarbejdere = handler.LoadMedarbejdere();

            UserID = UserID.ToUpper();
            string navn = "";
            for (int i = 0; i < medarbejdere.Length; i++)
            {
                if (medarbejdere[i].UserID == UserID)
                {
                    navn = medarbejdere[i].Navn; break;
                }
            }
            return navn;
        }
        public string GetMedarbejderRolle(string UserID)
        {
            Medarbejder[] medarbejdere = handler.LoadMedarbejdere();

            UserID = UserID.ToUpper();
            string rolle = "";
            for (int i = 0; i < medarbejdere.Length; i++)
            {
                if (medarbejdere[i].UserID == UserID)
                {
                    rolle = medarbejdere[i].Rolle; break;
                }
            }
            return rolle;
        }
    }
}
