using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Game();

            string playAgain = "yes";

            while (playAgain == "yes")
            {
                Console.WriteLine("Do you want to play again? (yes or no)");
                playAgain = Console.ReadLine();
                
                if (playAgain == "yes")
                {
                    Game();
                }
                else if (playAgain == "no")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Answer \"yes\" or \"no\"");
                }
            }
        }
        static void Game()
        {
            //creates an array containing the numbers 1-9
            char[] arr = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int turn = 1;
            int input = 0;

            while (true)
            {
                //draws a board with each sqare numbered
                Console.WriteLine($" _________ _________ _________");
                Console.WriteLine($"|         |         |         |");
                Console.WriteLine($"|    {arr[0]}    |    {arr[1]}    |    {arr[2]}    |");
                Console.WriteLine($"|_________|_________|_________|");
                Console.WriteLine($"|         |         |         |");
                Console.WriteLine($"|    {arr[3]}    |    {arr[4]}    |    {arr[5]}    |");
                Console.WriteLine($"|_________|_________|_________|");
                Console.WriteLine($"|         |         |         |");
                Console.WriteLine($"|    {arr[6]}    |    {arr[7]}    |    {arr[8]}    |");
                Console.WriteLine($"|_________|_________|_________|");

                //Checks whose turn it is, asks the player where they want to place their mark and places it
                if (turn % 2 == 1)
                {
                    Console.WriteLine("Player 1 turn, choose a tile to place an X");
                    input = int.Parse(Console.ReadLine());
                    arr[input - 1] = 'X';
                }
                else
                {
                    Console.WriteLine("Player 2 turn, choose a tile to place an O");
                    input = int.Parse(Console.ReadLine());
                    arr[input - 1] = 'O';
                }


                //Checks if anyone has won
                if (arr[0] == arr[1] && arr[1] == arr[2])
                {
                    if (arr[0] == 'X')
                    {
                        Console.WriteLine("First player has won");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Second player has won");
                        break;
                    }
                }
                if (arr[3] == arr[4] && arr[4] == arr[5])
                {
                    if (arr[3] == 'X')
                    {
                        Console.WriteLine("First player has won");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Second player has won");
                        break;
                    }
                }
                if (arr[6] == arr[7] && arr[7] == arr[8])
                {
                    if (arr[6] == 'X')
                    {
                        Console.WriteLine("First player has won");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Second player has won");
                        break;
                    }
                }
                if (arr[0] == arr[3] && arr[3] == arr[6])
                {
                    if (arr[0] == 'X')
                    {
                        Console.WriteLine("First player has won");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Second player has won");
                        break;
                    }
                }
                if (arr[1] == arr[4] && arr[4] == arr[7])
                {
                    if (arr[1] == 'X')
                    {
                        Console.WriteLine("First player has won");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Second player has won");
                        break;
                    }
                }
                if (arr[2] == arr[5] && arr[5] == arr[8])
                {
                    if (arr[2] == 'X')
                    {
                        Console.WriteLine("First player has won");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Second player has won");
                        break;
                    }
                }
                if (arr[0] == arr[4] && arr[4] == arr[8])
                {
                    if (arr[0] == 'X')
                    {
                        Console.WriteLine("First player has won");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Second player has won");
                        break;
                    }
                }
                if (arr[2] == arr[4] && arr[4] == arr[6])
                {
                    if (arr[2] == 'X')
                    {
                        Console.WriteLine("First player has won");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Second player has won");
                        break;
                    }
                }

                //If there is no winner and the board is full (turn = 9) it's a draw
                if (turn == 9)
                {
                    Console.WriteLine("It's a draw");
                    break;
                }

                //Adds 1 to the number of turns
                turn++;
            }
        }
    }
}