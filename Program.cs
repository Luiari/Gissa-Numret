
using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Vi ska köra en lek. jag tänker på ett tal mellan 1-20 och du ska gissa vilket tal det är. Du får 5 försök");
            bool correctAnswer = false; // Ger correctAnswer ett värde
            int guess = 5; // Ger antar gissingar ett värde
            Random random = new Random();
            int i = random.Next(1, 20); // Ger random ett värde
            while (!correctAnswer) // While sats så länge correctAnswer är false
            {
                Console.WriteLine("Skriv in din gissning: ");
                int number = int.Parse(Console.ReadLine()); // Lagrar användarens val i number

                guess--; // -5 för antar gissningar

                if (number < i)
                {
                    Console.WriteLine("Fel svar! För lågt tal. " + "Antal gissningar kvar: " + guess);//Om gissning är större än talet händer detta.
                }
                else if (number > i)
                {
                    Console.WriteLine("Fel svar! För högt tal. " + "Antal gissningar kvar: " + guess); // Om gissning är mindre än talet händer detta.
                }
                else
                {
                    Console.WriteLine("GRATTIS!!! Du gissade rätt på rätt tal" + "Antal gissningar: " + guess);
                    correctAnswer = true;

                }

                if (guess == 0) // OM antar gissningar är 0 tar spelet slut
                {
                    Console.WriteLine("Ajda! Dina gissningar tog slut. Du förlora");
                    break;
                }






            }
        }
    }
}