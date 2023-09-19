namespace Budwegkode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nu opstilles en simpel menu som kan bruges i projektet.

            List<string> UserList = new List<string>();
            UserList.Add("cvhanky");UserList.Add("simsimon");UserList.Add("morten"); UserList.Add("hankyboy");

            bool menuRunning = true;     // En bool der styrer om menuen kører.
            int countOuter = 0;
            while (menuRunning)
            {
                Console.WriteLine("Velkommen til menuen.");
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
                }
                else
                {
                    Console.WriteLine("Login failed."); // REdigere i test branch
                }
            }

        }
    }
}