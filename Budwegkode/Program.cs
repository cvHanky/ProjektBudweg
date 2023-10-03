namespace Budwegkode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataHandler handler = new DataHandler(@"..\..\..\Medarbejderliste.txt");
            // Nu opstilles en simpel menu som kan bruges i projektet.

            Menu loginMenu = new Menu("Velkommen.");

            Medarbejder[] medArbejderliste = new Medarbejder[]
            {
                new Medarbejder("Per Hansen", "9Q13", "leder"),
                new Medarbejder("Daniel Hoppe Hansen", "52135"),
                new Medarbejder("Roberozlav", "007"),
                new Medarbejder("Anders Bakdal", "PWQ9"),
                new Medarbejder("Mads Carlsen", "1337"),
            };
            handler.SaveMedarbejdere(medArbejderliste);

            bool validUser = false;           // En bool der styrer om brugeren er en valid user.
            bool menuRunning = true;          // En bool der styrer om menuen kører.
            string BrugerRolle = "";          
            string BrugerNavn = "";
            while (menuRunning)
            {
                Console.WriteLine("{0}\nIndtast medarbejder ID...",loginMenu.Title);
                string inputID = Console.ReadLine();
                validUser = loginMenu.TjekMedarbejder(inputID);  // Denne metode kigger listen af "UserID" igennem og returnerer "true" hvis den finder et ID. 
                if (validUser)
                {
                    BrugerNavn = loginMenu.GetMedarbejderNavn(inputID);
                    BrugerRolle = loginMenu.GetMedarbejderRolle(inputID);         // Gemmer navnet og rollen på personen der har logget ind så det nemmere kan tilgås.
                    
                    Console.Clear();
                    Console.WriteLine("Login var succesfuld.\nVelkommen {0}\n",BrugerNavn);

                    bool innerMenuRunning = true;
                    while (innerMenuRunning)
                    {
                        if (BrugerRolle == "medarbejder")
                        {
                            Console.WriteLine("1. Tjek ind\n2. Tjek ud\n\n(Tast et menupunkt eller tryk 0 for at logge ud)");
                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);                // Login menu for en standard medarbejder opstilles nu. 
                            switch (keyInfo.Key)
                            {
                                case ConsoleKey.D0:
                                    innerMenuRunning = false;
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D1:
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D2:
                                    Console.Clear();
                                    break;
                                default:
                                    Console.Clear();
                                    break;
                            }
                        }
                        else if (BrugerRolle == "leder")
                        {
                            Console.WriteLine("1. Tjek ind\n2. Tjek ud\n3. Tilføj gruppe\n4. Fjern Gruppe\n5. Se medarbejdere\n\n(Tast et menupunkt eller tryk 0 for at logge ud)");
                            //Login menu for en leder 
                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            switch (keyInfo.Key)
                            {
                                case ConsoleKey.D0:
                                    innerMenuRunning = false;
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D1:
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D2:
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D3:
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D4:
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D5:
                                    Console.Clear();
                                    break;
                                default:
                                    Console.Clear();
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Login failed.");
                }
            }

            Console.Write("\nPress any button to continue...");
            Console.ReadKey();
        }
    }
}