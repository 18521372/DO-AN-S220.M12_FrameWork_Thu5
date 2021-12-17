using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace qltx.Models
{
    public class chart
    {
        private int _row;
        private int _col;
        public int row
        {
            get { return _row; }
            set { _row = value; }
        }
        public int col
        {
            get { return _col; }
            set { _col = value; }
        }
    }
}
