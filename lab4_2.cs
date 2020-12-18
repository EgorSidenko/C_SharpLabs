using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04Lib
{
    public class Matrix
    {
        private int[,] map = new int[3, 3];
        private double det;
        public double Det
        {
            get
            {
                det = map[0, 0] * map[1, 1] * map[2, 2] - map[0, 0] * map[1, 2] * map[2, 1] -
                map[0, 1] * map[1, 0] * map[2, 2] + map[0, 1] * map[1, 2] * map[2, 0] +
                map[0, 2] * map[1, 0] * map[2, 1] + map[0, 2] * map[1, 1] * map[2, 0];

                return det;
            }
        }
        public int[,] Map
        {
            get { return map; }
            set
            {
                Array.Copy(value, map, value.Length);
            }
        }

        public int getRank()
        {
            return Map.Rank;
        }

        public void Display()
        {
            // Loop over 2D int array and display it.
            for (int i = 0; i <= Map.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= Map.GetUpperBound(1); j++)
                {
                    Console.Write(Map[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        private int Compere(Matrix arr)
        {
            //  0 - equal
            //  1 - higher
            // -1 - lower
            Matrix tmpMatr = new Matrix(Map);
            if (arr.Det == tmpMatr.Det)
                return 0;
            if (arr.Det > tmpMatr.Det)
                return 1;
            else
                return -1;
        }
        public void Input()
        {
            for (int i = 0; i <= Map.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= Map.GetUpperBound(1); j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    Map[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }

        //Constucters with no parameters
        public Matrix()
        {

        }

        public Matrix(int[,] tmp)
        {
            Array.Copy(tmp, map, tmp.Length);
        }
        
        public Matrix(string tmp, double flow)
        {

        }

        public static Matrix operator +(Matrix arr1, Matrix arr2)
        {
            Matrix newArr = new Matrix(arr1.Map);
            for (int i = 0; i <= arr1.Map.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr1.Map.GetUpperBound(1); j++)
                {
                    newArr.Map[i, j] += arr2.Map[i, j];
                }
            }
            return newArr;
        }
        public static Matrix operator -(Matrix arr1, Matrix arr2)
        {
            Matrix newArr = new Matrix(arr1.Map);
            for (int i = 0; i <= arr1.Map.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr1.Map.GetUpperBound(1); j++)
                {
                    newArr.Map[i, j] -= arr2.Map[i, j];
                }
            }
            return newArr;
        }
        public static Matrix operator *(Matrix arr1, Matrix arr2)
        {
            Matrix newArr = new Matrix(arr1.Map);
            for (int i = 0; i <= arr1.Map.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr1.Map.GetUpperBound(1); j++)
                {
                    newArr.Map[i, j] *= arr2.Map[i, j];
                }
            }
            return newArr;
        }
        public static bool operator ==(Matrix arr1, Matrix arr2)
        {
            return arr1.Compere(arr2) == 0;
        }
        public static bool operator !=(Matrix arr1, Matrix arr2)
        {
            return arr1.Compere(arr2) != 0;
        }
        public static bool operator >=(Matrix arr1, Matrix arr2)
        {
            return arr1.Compere(arr2) <= 0;
        }
        public static bool operator <=(Matrix arr1, Matrix arr2)
        {
            return arr1.Compere(arr2) <= 0;
        }
        public static bool operator <(Matrix arr1, Matrix arr2)
        {
            return arr1.Compere(arr2) < 0;
        }
        public static bool operator >(Matrix arr1, Matrix arr2)
        {
            return arr1.Compere(arr2) > 0;
        }
        //Display map into console

        public static implicit operator string(Matrix arr)
        {
            string res = "";
            for (int i = 0; i <= arr.Map.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.Map.GetUpperBound(1); j++)
                {
                    res+=arr.Map[i, j];
                    res += " ";
                }
                res += "\n";
            }
            return res;
        }

        public static explicit operator double(Matrix arr)
        {
            return arr.Det;
        }

    }
}
