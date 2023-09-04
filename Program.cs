namespace Fizz_Buzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Erstellen Sie einen Algorithmus der das Spiel FizzBuzz bis zur 100 durchführt.
            //Regeln siehe https://de.wikipedia.org/wiki/Fizz_buzz.

            //Modulo gibt uns den Rest einer Division als Ganzzahl zurück. Das Zeichen für den Operanten ist %
            //Beispiel: 4 % 2 = 0

            bool aufgabe = true;
            do
            {
                Console.Clear();
                for (int i = 1; i < 101; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz!!");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz!!");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz!!");
                    }
                    else
                    {
                        Console.WriteLine(i);
                        Thread.Sleep(1000);
                    }
                }
            } while (aufgabe);
        }
    }
}