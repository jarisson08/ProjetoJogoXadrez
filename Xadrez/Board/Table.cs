

using Board;

namespace Xadrez.Board
{
    internal class Table
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces;
        

        public Table(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            Pieces = new Piece[Lines,Columns];           
        }
        public Piece Piece(int line, int column)
        {
            return Pieces[line, column];
        }

        public Piece Piece(Position pos)
        {
            return Pieces[pos.Line, pos.Column];

        }

        public bool IsPieceExists(Position pos)
        {
            ToValidPosition(pos);
            return Piece(pos) != null; 
        }

        public void MovePiece(Piece piece, Position p)
        {
            if (IsPieceExists(p))
            {
                throw new BoardException("Already exists a piece in this position");
            }
            Pieces[p.Line, p.Column]= piece;
            piece.Position= p;  
        }

        public bool IsValidPosition(Position pos)
        {
            if(pos.Line<0 || pos.Line>= Lines || pos.Column<0 || pos.Column >= Columns)
            {
                return false;
            }
            return true;
        }

        public void ToValidPosition(Position pos)
        {
            if (!IsValidPosition(pos))
            {
                throw new BoardException("Invalid position");
                
            }
        }
    }
}
