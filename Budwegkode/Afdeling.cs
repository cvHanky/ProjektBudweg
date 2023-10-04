using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budwegkode
{
    public class Afdeling
    {
        // Klasse til Afdeling. 
        private string navn;                  // Private attributter
        private string bygning;

        public string Navn                    // Public properties
        {
            get { return navn; }
            set { navn = value; }
        }
        public string Bygning
        {
            get { return bygning; }
            set { bygning = value; }
        }
        public Afdeling(string navn, string bygning)
        {
            Navn = navn;
            Bygning = bygning;
        }
        public string AfdelingTitel()
        {
            string Titel = Navn + ";" + Bygning + ";";
            return Titel;
        }



    }
}
