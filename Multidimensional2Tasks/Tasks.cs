using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional2Tasks
{
    public static class Tasks
    {
        public static int Task1(int[,] array, int a)
        {
            int product = 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > a)
                    {
                        product *= array[i, j];
                    }

                }
            }

            return product;
        }

        public static int Task2(int[,] array)
        {
            int sum = 0 , min = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                 min = array[0, i];
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[j, i] < min)
                    {
                        min = array[j, i];
                        
                    }

                }
                sum += min;
            }

            return sum;
        }

        public static int[] Task3(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            int[] minarray = new int[rows];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                minarray[i] = array[i, 0];

                for (int j = 1; j < array.GetLength(1); j++)
                    if (array[i, j] < minarray[i])
                        minarray[i] = array[i, j];
            }

            return minarray;
        }
    }
}
