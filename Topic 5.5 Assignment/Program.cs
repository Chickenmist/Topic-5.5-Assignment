namespace Topic_5._5_Assignment
{
    internal class Program
    {
        //Wilson

        static void Main(string[] args)
        {
            double bank = 100, bet;
            string outcomeSelection = "";
            int outcomeGuess = 0; //1 is doubles, 2 is not double, 3 is even sum, 4 is odd sum
            Die die1 = new Die();
            Die die2 = new Die();

            while (bank > 0)
            {
                bet = -1;
                outcomeSelection = "";

                while (bet == -1)
                {
                    Console.Write("Input bet: ");
                
                    double.TryParse(Console.ReadLine(), out bet);

                    if (bet < 0 || bet == -1)
                    {
                        bet = 0;
                    }
                    else if (bet > bank)
                    {
                        bet = bank;
                    }
                }

                Console.WriteLine("");
                Console.WriteLine($"Your bet is {bet.ToString("C")}");
                Console.WriteLine("");

                while (outcomeSelection == "")
                {
                    Console.WriteLine("Pleasae guess an outcome");
                    Console.WriteLine("1. Doubles");
                    Console.WriteLine("2. Not Double");
                    Console.WriteLine("3. Even Sum");
                    Console.WriteLine("4. Odd Sum");
                    outcomeSelection = Console.ReadLine().ToLower();

                    if (outcomeSelection == "doubles" || outcomeSelection == "1")
                    {
                        outcomeGuess = 1;
                    }
                    else if (outcomeSelection == "not double" || outcomeSelection == "2")
                    {
                        outcomeGuess = 2;
                    }
                    else if (outcomeSelection == "even sum" || outcomeSelection == "3")
                    {
                        outcomeGuess = 3;
                    }
                    else if (outcomeSelection == "odd sum" || outcomeSelection == "4")
                    {
                        outcomeGuess = 4;
                    }
                    else
                    {
                        outcomeSelection = "";
                        Console.WriteLine("");
                        Console.WriteLine("Invalid guess");
                        Console.WriteLine("");
                    }
                }

                die1.RollDie();
                die2.RollDie();

                if (outcomeGuess == 1)
                {
                    if (die1.Roll == die2.Roll)
                    {
                        Console.WriteLine("");
                        bank += bet * 2;
                    }
                    else
                    {
                        bank -= bet * 2;
                    }
                }
                
                if (outcomeGuess == 2)
                {
                    if (die1.Roll != die2.Roll)
                    {
                        bank += bet / 2;
                    }
                    else
                    {
                        bank -= bet / 2;
                    }
                }

                if (outcomeGuess == 3)
                {
                    if ((die1.Roll + die2.Roll) % 2 == 0)
                    {
                        bank += bet;
                    }
                    else
                    {
                        bank -= bet;
                    }
                }

                if (outcomeGuess == 4)
                {
                    if ((die1.Roll + die2.Roll) % 2 != 0)
                    {
                        bank += bet;
                    }
                    else
                    {
                        bank -= bet;
                    }
                }
            }
        }
    }
}