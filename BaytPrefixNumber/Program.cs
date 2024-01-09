using System;

namespace Calculation
{
    class EnterNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź prefix: ");
            string userInputPrefix = Console.ReadLine();

            Console.WriteLine("Wprowadź numer: ");
            string userInputNumber = Console.ReadLine();

            if (int.TryParse(userInputPrefix, out int userPrefix))
            {
                if (userPrefix == 359)
                {
                    Console.WriteLine("Prefix nie zostanie zmieniony ze względu na prefix = 359");
                }
                else if (userInputNumber.Length == 9)
                {
                    Console.WriteLine("Numer ma 9 cyfr i prefix zostanie zmieniony na 48");
                }
                else
                {
                    Console.WriteLine("Nie zmieniamy numeru, bo prefix ma inną wartość i numer ma inną długość niż 9 cyfr");
                }
            }
            else
            {
                Console.WriteLine("Nieprawidłowy prefix. Spróbuj ponownie.");
            }

            RunProgram();
        }

        static void RunProgram()
        {
            Console.WriteLine("Czy chcesz uruchomić program ponownie? (T/N)");
            string response = Console.ReadLine();

            if (response.ToUpper() == "T")
            {
                Console.WriteLine("Restart programu...\n");
                Main(new string[] { }); // Ponowne uruchomienie metody Main
            }
            else
            {
                Console.WriteLine("Zamykanie programu...");
                // Dodaj kod, który zamyka program
            }
        }
    }
}


