namespace Budwegkode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nu opstilles en simpel menu som kan bruges i projektet.

            Menu loginMenu = new Menu();
            loginMenu.TilføjMedarbejder("Per Hansen", "9Q13");
            loginMenu.TilføjMedarbejder("Daniel Hoppe Hansen", "52135");
            loginMenu.TilføjMedarbejder("Roberozlav", "007");
            loginMenu.TilføjMedarbejder("Anders Bakdal", "PWQ9");

            Console.WriteLine("Velkommen til menuen.");


            bool menuRunning = true;     // En bool der styrer om menuen kører.
            while (menuRunning)
            {
                Console.WriteLine("\nIndtast medarbejder ID...");
                string inputID = Console.ReadLine();
                bool user = false;                          // En bool der styrer om brugeren er en valid user.
                user = loginMenu.TjekMedarbejder(inputID);  // Denne metode kigger listen af "UserID" igennem og returnerer "true" hvis den finder et ID. 
                if (user)
                {
                    Console.Clear();
                    Console.WriteLine("Login successful.");
                    menuRunning = false;
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