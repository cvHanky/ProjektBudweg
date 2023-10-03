namespace Budwegkode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataHandler medarbejderHandler = new DataHandler(@"..\..\..\Medarbejderliste.txt");
            DataHandler afdelingHandler = new DataHandler(@"..\..\..\Afdelingsliste.txt");
            // Nu opstilles en simpel menu som kan bruges i projektet.

            Medarbejder[] medarbejdere = new Medarbejder[]
            {
                new Medarbejder("Per Hansen", "9Q13", "leder"),
                new Medarbejder("Daniel Hoppe Hansen", "52135"),
                new Medarbejder("Roberozlav", "007"),
                new Medarbejder("Mads Carlsen", "1337"),
                new Medarbejder("Anders Bakdal", "PWQ9"),
            };

            Afdeling[] afdelinger = new Afdeling[]
            {
                new Afdeling("Lager","Bygning 1"),
                new Afdeling("Vaskeri","Bygning 1"),
                new Afdeling("Varemodtagelse","Bygning 2"),
                new Afdeling("Lager", "Bygning 2"),
                new Afdeling("Pakkeri","Bygning 2"),
            };

            medarbejderHandler.SaveMedarbejdere(medarbejdere);
            afdelingHandler.SaveAfdelinger(afdelinger);
            
            Menu loginMenu = new Menu("Velkommen.");

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
                            Console.WriteLine("1. Tjek ind\n2. Tjek ud\n3. Se medarbejdere\n\n(Tast et menupunkt eller tryk 0 for at logge ud)");
                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);                // Login menu for en standard medarbejder opstilles nu. 
                            switch (keyInfo.Key)
                            {
                                case ConsoleKey.D0:
                                    innerMenuRunning = false;
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D1:
                                    Console.Clear();
                                    Console.WriteLine("Hvilken bygning arbejder du i idag?\n1. Bygning A\n2. Bygning B\n3. Bygning C\n(Tryk 0 for at gå tilbage)");
                                    ConsoleKeyInfo bygning = Console.ReadKey(true);
                                    switch (bygning.Key)
                                    {
                                        case ConsoleKey.D0:
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
                                        default:
                                            Console.Clear();
                                            break;
                                    }
                                    break;
                                case ConsoleKey.D2:
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D3:
                                    Console.Clear();
                                    break;
                                default:
                                    Console.Clear();
                                    break;
                            }
                        }
                        else if (BrugerRolle == "leder")
                        {
                            Console.WriteLine("1. Tjek ind\n2. Tjek ud\n3. Se medarbejdere\n4. Tilføj Gruppe\n5. Fjern gruppe\n6. Tilføj medarbejder\n 7. Fjern medarbejder\n\n(Tast et menupunkt eller tryk 0 for at logge ud)");
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
                                    Console.WriteLine("Hvilken afdeling arbejder du i idag?\n1. Bygning A\n2. Bygning B\n3. Bygning C\n\n(Tryk på 0 for at gå tilbage)");
                                    ConsoleKeyInfo bygning = Console.ReadKey(true);
                                    switch (bygning.Key)
                                    {
                                        case ConsoleKey .D0:
                                            Console.Clear();
                                            break;
                                        case ConsoleKey .D1:
                                            Console.Clear();
                                            break;
                                        case ConsoleKey .D2:
                                            Console.Clear();
                                            break;
                                        case ConsoleKey .D3:
                                            Console.Clear();
                                            break;
                                        default: 
                                            Console.Clear();
                                            break;
                                    }
                                    break;
                                case ConsoleKey.D2:
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D3:
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D4:
                                    Console.Clear();
                                    Console.WriteLine("Hvor kommer gruppen fra?");
                                    Console.ReadLine();
                                    Console.WriteLine("Hvor mange er de i gruppen?");
                                    Console.ReadLine();
                                    break;
                                case ConsoleKey.D5:
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D6:
                                    Console.Clear();
                                    break;
                                case ConsoleKey.D7:
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