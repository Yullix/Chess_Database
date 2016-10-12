using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Database.Enums.Extensions
{
    public static class SquareExtensions
    {
        public static bool IsCastlingSquare(this Square square, Color color)
        {
            switch(color)
            {
                case Color.White:
                    if (square == Square.c1 || square == Square.d1 || square == Square.f1 || square == Square.g1)
                        return true;
                    break;
                case Color.Black:
                    if (square == Square.c8 || square == Square.d8 || square == Square.f8 || square == Square.g8)
                        return true;
                    break;
            }

            return false;
        }


    }
}
