using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Database.Enums.Extensions
{
    public static class PieceExtensions
    {
        public static bool IsMinorPiece(this Piece piece)
        {
            return piece == Piece.Knight || piece == Piece.Bishop;
        }
    }
}
