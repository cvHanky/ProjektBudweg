using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budwegkode
{
    public class DataHandler
    {
        public DataHandler(string dataFileName)
        {
            this.dataFileName = dataFileName;
        }

        private string dataFileName;
        public string DataFileName
        {
            get { return dataFileName; }
        }
        public void SaveMedarbejdere(Medarbejder[] medarbejdere)
        {
            StreamWriter sw = new StreamWriter(DataFileName);
            for (int i = 0; i < medarbejdere.Length; i++)
            {
                if (i != medarbejdere.Length - 1)
                    sw.WriteLine(medarbejdere[i].MedarbejderTitel());
                else
                    sw.Write(medarbejdere[i].MedarbejderTitel());
            }
            sw.Close();
        }
        public Medarbejder[] LoadMedarbejdere()
        {
            StreamReader sr = new StreamReader(DataFileName);
            string[] fileLines = sr.ReadToEnd().Split('\n');
            Medarbejder[] medarbejderListe = new Medarbejder[fileLines.Length];

            for (int i = 0; i < fileLines.Length; i++)
            {
                string[] lineData = fileLines[i].Split(";");
                Medarbejder medarbejder = new Medarbejder(lineData[0], lineData[1], lineData[2]);
                medarbejderListe[i] = medarbejder;
            }
            sr.Close();
            return medarbejderListe;
        }
        public void SaveAfdelinger(Afdeling[] afdelinger)
        {
            StreamWriter sw = new StreamWriter(DataFileName);
            for (int i = 0; i < afdelinger.Length;i++)
            {
                if (i != afdelinger.Length - 1)
                    sw.WriteLine(afdelinger[i].AfdelingTitel());
                else
                    sw.Write(afdelinger[i].AfdelingTitel());
            }
            sw.Close();
        }
        public Afdeling[] LoadAfdelinger()
        {
            StreamReader sr = new StreamReader(DataFileName);
            string[] Lines = sr.ReadToEnd().Split("\n");
            Afdeling[] afdelingsListe = new Afdeling[Lines.Length];

            for (int i = 0;i < afdelingsListe.Length;i++)
            {
                string[] lineData = Lines[i].Split(";");
                Afdeling a = new Afdeling(lineData[0], lineData[1]);
                afdelingsListe[i] = a;
            }
            sr.Close();
            return afdelingsListe;
        }
    }
}
