using System.Collections.Generic;
using System;
namespace Search
{
static class Search{


    public static int LinearSearch<T>(T[] array, T value)
    {
        for(int i = 0; i< array.Length; i++){
            if(array[i].Equals(value) ){
                return i;
            }
        }
        return -1;

    }

    public static int BinarySearch<T>(T[] array, T value, Comparer<T> comparer)
    {
        int low = 0;
        int high = array.Length - 1;

        while(low <= high){
           int middle = (low + high) / 2;
           if(comparer.Compare(value, array[middle]) < 0){
               high = middle - 1;
           }
           else if(comparer.Compare(value, array[middle]) > 0){
               low = middle + 1;
           }
           else
           {
               Console.WriteLine("Target  is found.");
               return middle;
           }
           }
           return -1;
        }
    }
}
