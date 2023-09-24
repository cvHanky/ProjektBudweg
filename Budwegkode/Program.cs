namespace Budwegkode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nu opstilles en simpel menu som kan bruges i projektet.

            Menu loginMenu = new Menu("Velkommen til menuen.");

            loginMenu.TilføjMedarbejder("Per Hansen", "9Q13");
            loginMenu.TilføjMedarbejder("Daniel Hoppe Hansen", "52135");
            loginMenu.TilføjMedarbejder("Roberozlav", "007");
            loginMenu.TilføjMedarbejder("Anders Bakdal", "PWQ9");

            bool user = false;           // En bool der styrer om brugeren er en valid user.
            bool menuRunning = true;     // En bool der styrer om menuen kører.
            while (menuRunning)
            {
                Console.WriteLine("\nIndtast medarbejder ID...");
                string inputID = Console.ReadLine();
                user = loginMenu.TjekMedarbejder(inputID);  // Denne metode kigger listen af "UserID" igennem og returnerer "true" hvis den finder et ID. 
                if (user)
                {
                    Console.Clear();
                    Console.WriteLine("Login successful.");
                    menuRunning = false;     // Når "menuRunning" er false genstarter den ikke menuen. 
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