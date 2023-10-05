using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
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
            set 
            { 
                if (value > 0) 
                {
                    antal = value;
                } 
                else
                {
                    throw new Exception("Fejl, antal skal være over 0 :(");
                }
            }
        }
        public string Navn
        {
            get { return navn; }
            set 
            { 
                if (value.Length > 0)
                {
                    navn = value;
                }
                else 
                { 
                    throw new Exception("Gruppen skal have et navn");
                }
            
            }
        }
        public Besøgende(int antal, string navn)
        {
            Antal = antal;
            Navn = navn;
        }

        public override string ToString()
        {
            return "Navn: " + Navn + ", antal: " + Antal;
        }
    }
}
