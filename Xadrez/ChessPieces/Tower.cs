using Board;
using Xadrez.Board;

namespace Xadrez.ChessPieces
{
    class Tower : Piece
    {
        public Tower(Colors color, Table table) : base(color, table)
        {
        }
        public override string ToString()
        {
            return "T";
        }
    }
}
