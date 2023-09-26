using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budwegkode
{
    public class Medarbejder
    {              // Klasse til medarbejderen. Alting er public, da det skal kunne tilgås af andre klasser. 
        public string Navn;
        public string UserID;
        private string rolle;
        Menu menu = new Menu("Lets go");

        public Medarbejder(string navn, string userID)
        {
            Navn = navn;
            UserID = userID;
            rolle = "medarbejder";
        }
        public string GetRolle()
        {
            return rolle;
        }
        public void GørTilLeder()
        {
            rolle = "leder";
        }
    }
}
