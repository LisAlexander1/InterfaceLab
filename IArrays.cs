using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassLab
{
    internal interface IArrays
    {
        int Length { get; }
        double this[int index] { get; set; }
        double[] Arr { get; set; }
        double[] Sum(double[] plenty);
        void ElemByElem();
    }
}
