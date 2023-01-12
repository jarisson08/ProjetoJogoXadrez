
using Board;
using Xadrez.View;
using Xadrez.Board;
using Xadrez.ChessPieces;
using System;

namespace Xadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ChessPosition pos= new ChessPosition('b',5); 

            //Console.WriteLine(pos);
            //Console.WriteLine(pos.PositionDisposal());


            try
            {
                Table tab = new Table(8, 8);

                tab.MovePiece(new Tower(Colors.White, tab), new Position(0, 0));
                tab.MovePiece(new King(Colors.Yellow, tab), new Position(1, 4));
                tab.MovePiece(new King(Colors.White, tab), new Position(3, 0));
                tab.MovePiece(new Tower(Colors.Black, tab), new Position(5, 1));



                Screen.PrintTable(tab);

            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
