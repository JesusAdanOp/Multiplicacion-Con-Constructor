using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicacion_Con_Constructor
{
    internal class clmult
    {
        int v1, v2;

        public clmult(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public int multiplicacion()
        {
            return v1 * v2;
        }
    }
}
