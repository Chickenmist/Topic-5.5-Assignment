using System;

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

            Console.WriteLine("Welcome to the dice game! Make a bet then guess what the resulting roll will be! Also, according to the contract you signed in order to participate, if you run out of money we are legally allowed to take your kidneys as collateral until you can pay us back. With interest. Have fun!");
            Console.WriteLine("");

            while (bank > 0)
            {
                bet = -1;
                outcomeSelection = "";

                Console.WriteLine($"Bank: {bank.ToString("C")}");
                Console.WriteLine("");

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
                    Console.WriteLine("1. Doubles (The dice will be the same. Wins double your bet, loses double your bet)");
                    Console.WriteLine("2. Not Double (The dice will not be the same. Wins half your bet, loses half your bet)");
                    Console.WriteLine("3. Even Sum (The sum of the dice will be even. Wins your bet, loses your bet)");
                    Console.WriteLine("4. Odd Sum (The sum of the dice will be odd. Wins your bet, loses your bet)");
                    Console.WriteLine("");
                    Console.Write("Your guess: ");
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

                Console.WriteLine("");
                Console.WriteLine("Die One:");
                die1.DrawRoll();
                Console.WriteLine("Die Two:");
                die2.DrawRoll();
                Console.WriteLine("");

                if (outcomeGuess == 1)
                {
                    if (die1.Roll == die2.Roll)
                    {
                        Console.WriteLine("You Win!");
                        Console.WriteLine("");
                        bank += bet * 2;
                        Console.WriteLine($"You won {bet.ToString("C")}");
                    }
                    else
                    {
                        Console.WriteLine("You Lose! Too bad!");
                        Console.WriteLine("");
                        bank -= bet * 2;
                        Console.WriteLine($"You lost {(bet * 2).ToString("C")}");
                    }
                }
                
                if (outcomeGuess == 2)
                {
                    if (die1.Roll != die2.Roll)
                    {
                        Console.WriteLine("You Win!");
                        Console.WriteLine("");
                        bank += bet / 2;
                        Console.WriteLine($"You won {(bet / 2).ToString("C")}");
                    }
                    else
                    {
                        Console.WriteLine("You Lose! Too bad!");
                        Console.WriteLine("");
                        bank -= bet / 2;
                        Console.WriteLine($"You lost {(bet / 2).ToString("C")}");
                    }
                }

                if (outcomeGuess == 3)
                {
                    if ((die1.Roll + die2.Roll) % 2 == 0)
                    {
                        Console.WriteLine("You Win!");
                        Console.WriteLine("");
                        bank += bet;
                        Console.WriteLine($"You won {bet.ToString("C")}");
                    }
                    else
                    {
                        Console.WriteLine("You Lose! Too bad!");
                        Console.WriteLine("");
                        bank -= bet;
                        Console.WriteLine($"You lost {bet.ToString("C")}");
                    }
                }

                if (outcomeGuess == 4)
                {
                    if ((die1.Roll + die2.Roll) % 2 != 0)
                    {
                        Console.WriteLine("You Win!");
                        Console.WriteLine("");
                        bank += bet;
                        Console.WriteLine($"You won {bet.ToString("C")}");
                    }
                    else
                    {
                        Console.WriteLine("You Lose! Too bad!");
                        Console.WriteLine("");
                        bank -= bet;
                        Console.WriteLine($"You lost {bet.ToString("C")}");
                    }
                }

                Console.WriteLine("");
            }

            Console.WriteLine("Uh oh, Looks like you ran out of money! Oh well, you signed the contract now hand over your kidneys.");
        }
    }
}