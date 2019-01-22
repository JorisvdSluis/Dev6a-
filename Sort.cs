using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort
{
    static class Sort
    {
        public static T[] InsertionSort<T>(T[] array, Comparer<T> comparer)
        {
            for (int j = 1; j < array.Length; j++)
            {
                T key = (array[j]);
                int i = j - 1;
                while (i > -1 && comparer.Compare(array[i], key) > 0)
                {
                    array[i + 1] = array[i];
                    i = i - 1;

                }

                array[i + 1] = key;
            }

            Console.WriteLine("\nArray sorted (InsertionSort)");
            for (var k = 0; k < array.Length; k++)
            {
                Console.Write(array[k] + "  ");
            }

            return array;
        }

        public static T[] MergeSort<T>(T[] array, Comparer<T> comparer)
        {
            if (array.Length > 1)
            {
                int middle = array.Length / 2;
                T[] left = array.Take(middle).ToArray();
                T[] right = array.Skip(middle).ToArray();
                MergeSort<T>(left, Comparer<T>.Default);
                MergeSort<T>(right, Comparer<T>.Default);
                
                var i = 0; var j = 0; var k = 0;
                while (i < left.Length && j < right.Length) {
                    if (comparer.Compare(left[i], right[j]) < 0) {
                        array[k] = left[i];
                        i++;
                    }
                    else { 
                        array[k] = right[j];
                        j++;
                    }
                    k++;
                }

                while (i < left.Length) {
                    array[k] = left[i];
                    i++; k++;
                }
                
                while (j < right.Length) {
                    array[k] = right[j];
                    j++; k++;
                }
                
            }

            return array;
        }
    }

}
