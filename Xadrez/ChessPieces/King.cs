using Board;
using Xadrez.Board;

namespace Xadrez.ChessPieces
{
    class King : Piece
    {
        public King(Colors color, Table table) : base(color, table)
        {
        }
        public override string ToString()
        {
            return "R";
        }
    }
}
