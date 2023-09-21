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
        public int Antal;
        public string Navn;

        public Besøgende(int antal, string navn)
        {
            Antal = antal;
            Navn = navn;
        }
    }
}
