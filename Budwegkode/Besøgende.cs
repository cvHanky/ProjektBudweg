using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budwegkode
{
    public class Besøgende
    {
        // Klasse til grupper der besøger virksomheden.
        private int antal;                // Private attributter
        private string navn;

        public int Antal                  // Public properties
        {
            get { return antal; }
            set { antal = value; }
        }
        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }
        public Besøgende(int antal, string navn)
        {
            Antal = antal;
            Navn = navn;
        }


    }
}
