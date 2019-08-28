using System;
using System.Configuration;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            InitBoard();
          //  DisplayBoard();

          Console.WriteLine("Spele sakusies.");
          int moves = 0;
          bool first = true; // pirmais speletajs X
          int winner = 0;

            do
          {
              
              DisplayBoard();
              if (first)
              {
                  Console.Write("'{0}' Ievadi kur (rinda colona) liksi {1}:", first ? "X" : "O",
                      first ? "krustu" : "apli");
                  string inputString = Console.ReadLine();
                  string[] coordString = inputString.Split(' ');
                  int x = Convert.ToInt32(coordString[0])-1;
                  int y = Convert.ToInt32(coordString[1])-1;

                  if (board[x, y] == ' ')
                  {
                      board[x, y] = first ? 'X' : 'O';
                      moves++;
                      first = false;
                  }

                  if (CheckGame('X'))
                  {
                      winner = 1;
                  }

              }
              else // iet dators
              {
                
                int cx = 0;
                int cy = 0;
                do
                {
                    Random rnd = new Random();
                    cx = rnd.Next(0, 3);
                    cy = rnd.Next(0, 3);
                } while (board[cx,cy] != ' ');

                board[cx,cy] = first ? 'X' : 'O';
                moves++;
                if (CheckGame('O'))
                {
                    winner = 2;
                }

                    first = true;
              }

             
          } while(moves<9&&winner==0);

            DisplayBoard();
            if (winner == 0)
            {
                Console.WriteLine("Neizkirts!");
            } else if (winner == 1)
            {
                Console.WriteLine("Uzvareja pirmais speletajs!");
            } else Console.WriteLine("Uzvareja otrais speletajs!");
            Console.ReadKey();
        }

        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
            
        }

        private static void DisplayBoard()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("     " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("     " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("     " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }

        private static bool CheckGame(char player) { 
            bool end = false;
            int win = 0;
            string rinda = "";
            string colona = "";
            for (int j = 0; j < 3; j++)
            {
                rinda = "";
                colona = "";
                for (int k = 0; k < 3; k++)
                {
                    rinda += board[j, k];
                    colona += board[k, j];
                }
                //Console.WriteLine(rinda);
                if (rinda == player.ToString() + player.ToString() + player.ToString()|| colona == player.ToString() + player.ToString() + player.ToString())
                {
                    return true;
                }
                //Console.WriteLine(colona);
               //Console.WriteLine(player.ToString() + player.ToString() + player.ToString());
               //Console.WriteLine(player);
            }


            rinda = board[0, 0].ToString() + board[1, 1].ToString() + board[2, 2];//diognale 1
            colona = board[2, 0].ToString() + board[1, 1].ToString() + board[0, 2];//diognale 2

            if (rinda == player.ToString() + player.ToString() + player.ToString() || colona == player.ToString() + player.ToString() + player.ToString())
            {
                return true;
            }

            //Console.ReadKey();
            return false;
        }
    }
}
