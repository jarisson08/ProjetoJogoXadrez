using Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez.Board;

namespace Xadrez.ChessPieces
{
    internal class ChessPosition
    {
        public char Column { get; set; }
        public int Line { get; set; }

        public ChessPosition(char column, int line)
        {
            Column = column;
            Line = line;
        }

        public Position PositionDisposal()
        {
            return new Position(8-Line, Column -'a');
        }

        public override string ToString()
        {
            return "" +  Column + Line;
        }
    }
}
