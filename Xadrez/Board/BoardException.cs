using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez.Board
{
    internal class BoardException: Exception
    {
        public BoardException(string msg): base(msg) 
        {

        }
    }
}
