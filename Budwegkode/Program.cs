namespace Budwegkode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nu opstilles en simpel menu som kan bruges i projektet.


            /*  SLET HER FOR AT KODE VIRKER
            

            Console.WriteLine("Velkommen til menuen.");

            List<string> UserList = new List<string>();
            UserList.Add("makker2");UserList.Add("andersbakdal");UserList.Add("roberozlav"); UserList.Add("makker");

            bool menuRunning = true;     // En bool der styrer om menuen kører.
            int countOuter = 0;
            while (menuRunning)
            {
                Console.WriteLine("\nIndtast medarbejder ID...");
                string userID = Console.ReadLine();
                bool user = false;     // En bool der styrer om brugeren er en valid user.
                for (int i = 0; i < UserList.ToArray().Length; i++)
                {              // Dette loop tjekker om brugeren er en valid user.
                    if (userID == UserList[i])
                    {
                        user = true;
                        Console.Clear();
                        break;
                    }
                    else
                        Console.Clear();
                }
                if (user)
                {
                    Console.WriteLine("Login successful.");
                    menuRunning = false;
                }
                else
                {
                    Console.WriteLine("Login failed."); // Testing123
                }
            }

            SLET HER FOR AT KODE VIRKER */

            Menu menu = new Menu();

            menu.TilføjMedarbejder("Per Hansen", "Per");
            menu.TilføjMedarbejder("Daniel Hoppe Hansen", "52135");
            menu.TilføjMedarbejder("Roberozlav", "007");
            menu.TilføjMedarbejder("Anders Bakdal", "PWQ9");

            menu.SeMedarbejdere();

            Console.Write("\nPress any button to continue...");
            Console.ReadKey();
        }
    }
}