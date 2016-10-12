using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess_Database.Database.Models;

namespace Chess_Database.Database
{
    public abstract class PlyBase
    {
        ICollection<Ply> _plies;

        public PlyBase()
        {
            _plies = new List<Ply>();
        }

        public ICollection<Ply> Plies
        {
            get { return _plies; }
        }
    }
}
