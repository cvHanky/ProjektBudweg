using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budwegkode
{
    public class Menu      // Denne klasse styrer de metoder der skal bruges i vores system. 
    {
        private int medarbejderAntal = 0;
        private Medarbejder[] MedarbejderListe = new Medarbejder[200];    // Alle disse sættes til private, da de ikke skal kunne ændres direkte, kun ved brug af metoder. 

        public void TilføjMedarbejder(string inputNavn, string inputID)   // Metode der tilføjer en ny medarbejder. Der skal skrives 2 parametre, 
        {                                                           // ... som hhv. er medarbejderens navn og hans userID. 
            Medarbejder medarbejder = new Medarbejder();     // Tilføjer en ny instans af en medarbejder.
            medarbejder.Name = inputNavn;
            MedarbejderListe[medarbejderAntal].Name = inputNavn;     
            medarbejder.UserID = inputID;
            MedarbejderListe[medarbejderAntal].UserID = inputID;    // Her bruges de indtastede parametre til at ændre "Name" og "UserID" attributterne af en medarbejder.

            medarbejderAntal++;       // Til sidst lægges der 1 til antallet af medarbejdere, da der nu er tilføjet en ny medarbejder. 
        }

        public void SeMedarbejdere()
        {
            for (int i = 0; i < medarbejderAntal; i++)
            {
                Console.WriteLine(MedarbejderListe[i].Name);
            }
        }
    }
}
