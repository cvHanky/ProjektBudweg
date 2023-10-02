using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budwegkode
{
    public class Medarbejder
    {              // Klasse til medarbejderen. Alting er public, da det skal kunne tilgås af andre klasser. 
        Menu menu = new Menu("Lets go");

        private string navn;                 // Private attributter
        private string userID;
        private string rolle;
        
        public string Navn                   // Public properties
        {
            get { return navn; } 
            set { navn = value; }
        }
        public string UserID
        {
            get { return userID; } 
            set { userID = value; }
        }
        public string Rolle
        {
            get { return rolle; } 
            set { rolle = value}
        }

        public Medarbejder(string navn, string userID)
        {
            Navn = navn;
            UserID = userID;
            rolle = "medarbejder";
        }
        public void GørTilLeder()
        {
            rolle = "leder";
        }
    }
}
