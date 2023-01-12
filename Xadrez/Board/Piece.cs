using Board;


namespace Xadrez.Board
{
    internal class Piece
    {
        public Position Position{ get; set; }
        public Colors Color { get; protected set; }
        public int NumberOfMoves { get; protected set; }
        public  Table Table { get; set; }

        public Piece(Colors color, Table table)
        {
            Position = null;
            Color = color;
            NumberOfMoves = 0;
            Table = table;
        }
    }
}
