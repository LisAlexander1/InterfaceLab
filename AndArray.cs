using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassLab
{
    internal class AndArray : IArrays
    {
        private double[] arr;

        public double[] Arr
        {
            get => arr; set
            {
                if (value is double[])
                {
                    arr = value;
                }
            }
        }

        public int Length => Arr.Length;

        public double this[int index]
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                {
                    return arr[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < arr.Length)
                {
                    arr[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public AndArray(double[] arr)
        {
            Arr = arr;
        }

        public void ElemByElem()
        {
            for (int item_index = 0; item_index < Arr.Length; item_index++)
            {
                Arr[item_index] = Math.Sqrt(Math.Abs(Arr[item_index]));
            }
        }

        public double[] Sum(double[] plenty)
        {
            return Arr.Intersect(plenty).ToArray();
        }
    }
}
