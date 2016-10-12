using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess_Database.Enums;

namespace Chess_Database.Database.Models
{
    public sealed class Ply : IEntity
    {
        private readonly int _id;
        private readonly Square _startSquare;
        private readonly Square _endSquare;
        private readonly Piece _piece;
        private readonly Color _color;

        public Ply(Square startSquare, Square endSquare, Piece piece, Color color, int id)
        {
            _id = id;
            _startSquare = startSquare;
            _endSquare = endSquare;
            _piece = piece;
            _color = color;
        }

        public int Id
        {
            get { return _id; }
        }

        public Square StartSquare
        {
            get { return _startSquare; }
        }

        public Square EndSquare
        {
            get { return _endSquare; }
        }

        public Piece Piece
        {
            get { return _piece; }
        }

        public Color Color
        {
            get { return _color; }
        }
    }
}
