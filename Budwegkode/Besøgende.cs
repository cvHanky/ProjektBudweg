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
        private int antal;
        private string navn;

        public Besøgende(int antal, string navn)
        {
            this.antal = antal;
            this.navn = navn;
        }
    }
}
