using Board;
using System;
using Xadrez.Board;

namespace Xadrez.View
{
    internal class Screen
    {

        public static void PrintTable(Table tab)
        {
            for (int i = 0; i < tab.Lines; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Columns; j++)
                {
                    if (tab.Piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        PieceColor(tab.Piece(i, j));
                        Console.Write(" ");

                    }
                    
                }
                Console.WriteLine();
            }
           Console.WriteLine("  A B C D E F G H");
        }

        public static void PieceColor(Piece piece) 
        {
            if (piece.Color == Colors.White)
            {
                Console.Write(piece);
            }else 
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }
    }
}
