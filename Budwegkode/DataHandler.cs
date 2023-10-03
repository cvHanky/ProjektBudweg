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
    }
}
