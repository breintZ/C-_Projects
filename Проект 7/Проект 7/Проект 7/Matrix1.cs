using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_7
{
    class Matrix1
    {
        private int[,] m = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
        public int this[int i, int j]
        {
            set { m[i, j] = value; }
            get { return m[i, j]; }
        }
    }
}
