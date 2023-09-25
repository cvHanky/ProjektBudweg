namespace Budwegkode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nu opstilles en simpel menu som kan bruges i projektet.

            Menu loginMenu = new Menu("Velkommen til menuen.");

            loginMenu.TilføjMedarbejder("Per Hansen", "9Q13");
            loginMenu.GørTilLeder("9Q13");
            loginMenu.TilføjMedarbejder("Daniel Hoppe Hansen", "52135");
            loginMenu.TilføjMedarbejder("Roberozlav", "007");
            loginMenu.TilføjMedarbejder("Anders Bakdal", "PWQ9");

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
                    menuRunning = false;     // Når "menuRunning" er false genstarter den ikke menuen. 

                    if (BrugerRolle == "medarbejder")
                    {
                        Console.WriteLine("1. Tjek ind\n2. Tjek ud\n\n(Tast et menupunkt eller tryk 0 for at logge ud)");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);                // Login menu for en standard medarbejder opstilles nu. 
                        switch (keyInfo.Key)
                        {
                            case ConsoleKey.D0:
                                menuRunning = true;
                                Console.Clear();
                                break;
                            case ConsoleKey.D1:
                                Console.WriteLine();
                                break;
                            case ConsoleKey.D2:
                                Console.WriteLine();
                                break;
                            default:
                                Console.WriteLine();
                                break;
                        }
                    }
                    else if (BrugerRolle == "leder")
                    {

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