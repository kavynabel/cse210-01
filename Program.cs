using System;
using System.Collections.Generic;

// Assignment: 01 Ponder and Prove: Tic Tac Toe
// Author: Kavyn Abel

namespace solo_prep_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create list to hold the 9 placeholder values for the tic tac toe display.

            List<string> holders = new List<string>();
            holders.Add("1");
            holders.Add("2");
            holders.Add("3");
            holders.Add("4");
            holders.Add("5");
            holders.Add("6");
            holders.Add("7");
            holders.Add("8");
            holders.Add("9");
            // Console.WriteLine(holders[0]);

            int w;
            w = 0;
            int count;
            count = 0;
            while (w != 1)
            {
                // Print Board
                PrintBoard(holders);

                // Taking their turn. x starts
                Console.Write("x's turn, choose a square (1-9): ");
                string answer = Console.ReadLine();

                // Use their input to get to the correct list index.
                int x;
                x = (int.Parse(answer) - 1);

                holders[x] = "x";
                Console.WriteLine("");
                
                count = count + 1;
                // Check if 3 in a row
                w = Check(holders, w);

                // currently count is an undeclared variable
                if (count == 9)
                {
                    w = 1;
                }
                else
                {
                    if (w != 1)
                    {
                        // O's turn
                        PrintBoard(holders);
                        Console.WriteLine("");
                        Console.Write("o's turn, choose a square (1-9): ");
                        answer = Console.ReadLine();
                        Console.WriteLine("");
                        x = (int.Parse(answer) - 1);
                        holders[x] = "o";
                        // Console.WriteLine("");

                        count = count + 1;

                        // Check if 3 in a row
                        w = Check(holders, w);
                    }
                    else
                    {
                        Console.WriteLine("");
                    }
                }
            
            }
            PrintBoard(holders);
            Console.Write("");
            if (count == 9)
            {
                Console.Write("Oof, tough luck, its a draw");
            }
            else
            {
                Console.Write("Good game, thanks for playing!");
            }
            

        }
        static void PrintBoard(List<string>holders)
        {
            Console.WriteLine($"{holders[0]} | {holders[1]} | {holders[2]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{holders[3]} | {holders[4]} | {holders[5]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{holders[6]} | {holders[7]} | {holders[8]}");
            Console.WriteLine("");
        }

        static int Check(List<string>holders, int w)
        {
            if (holders[0] == "x" && holders[1] == "x" && holders[2] == "x" || holders[0] == "o" && holders[1] == "o" && holders[2] == "o" || holders[3] == "x" && holders[4] == "x" && holders[5] == "x" || holders[3] == "o" && holders[4] == "o" && holders[5] == "o" || holders[6] == "x" && holders[7] == "x" && holders[8] == "x" || holders[6] == "o" && holders[7] == "o" && holders[8] == "o" || holders[0] == "x" && holders[3] == "x" && holders[6] == "x" || holders[0] == "o" && holders[3] == "o" && holders[6] == "o" || holders[1] == "x" && holders[4] == "x" && holders[7] == "x" || holders[1] == "o" && holders[4] == "o" && holders[7] == "o" || holders[2] == "x" && holders[5] == "x" && holders[8] == "x" || holders[2] == "o" && holders[5] == "o" && holders[8] == "o" || holders[0] == "x" && holders[4] == "x" && holders[8] == "x" || holders[0] == "o" && holders[4] == "o" && holders[8] == "o" || holders[2] == "x" && holders[4] == "x" && holders[6] == "x" || holders[2] == "o" && holders[4] == "o" && holders[6] == "o")
            {
                w = 1;
            }
            else
            {
                w = 0;
            }
            return w;
        }
    }
}
