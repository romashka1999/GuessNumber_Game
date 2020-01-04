using System;


namespace GuessNumberGame
{
    class Program
    {
        public static int GetRandomBetween(int a, int b)
        {
            var random = new Random();
            return random.Next(a, b);
        }

        static void Main(string[] args)
        {
            var computer = Program.GetRandomBetween(1, 100);
            var cnt = 0;
            while (true)
            {
                cnt++;
                Console.WriteLine("enter any number 1 - 100");
                var user = Convert.ToInt32(Console.ReadLine());

                if (user > 100 || user < 0)
                {
                    Console.WriteLine("enter number only from :1 - to: 100");
                    continue;
                }

                if (user > computer)
                {
                    Console.WriteLine("Your number is more then GuessNumber");
                }
                else if (user < computer)
                {
                    Console.WriteLine("Your number is less then GuessNumber");
                }
                else if (user == computer)
                {
                    Console.WriteLine("You guessed number");
                    Console.WriteLine("attemt: " + Convert.ToString(cnt));
                    Console.WriteLine("guessed number is: " + Convert.ToString(computer));
                }
            }
        }
    }
}