﻿using System;
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
        private string? lokation;
        
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
            set { rolle = value;  }
        }
        public string? Lokation
        {
            get { return lokation; }
            set { lokation = value;  }
        }

        public Medarbejder(string navn, string userID)           // Overloading constructors, så man både kan vælge at tilføje 
        {                                                        // en almen medarbejder eller en leder/admin. 
            Navn = navn;
            UserID = userID;
            rolle = "medarbejder";
            Lokation = null;
        }
        public Medarbejder(string navn, string userID, string rolle)
        {
            Navn = navn;
            UserID = userID;
            Rolle = rolle;
            Lokation = null;
        }
        public string MedarbejderTitel()
        {
            string Titel = Navn + ";" + UserID + ";" + Rolle + ";" + Lokation + ";";
            return Titel;
        }

        public string IndtjekketMedarbejderTitel()
        {
            string Titel = Navn + ";" + Lokation + ";";
            return Titel;
        }
           
    }
}
