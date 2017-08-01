using System;
using System.Collections.Generic;

namespace basic13
{
    public class Program
    {
        // 1
        public static void Print1To255()
        {
            for (int i = 1; i <= 255; ++i){
                Console.WriteLine(i);
            }
        }
        // 2
        public static void PrintOddTo255()
        {
            for (int i = 1; i <= 255; ++i){
                if (i%2 != 0){
                    Console.WriteLine(i);
                }
            }
        }
        // 3
        public static void PrintSum(){
            int sum = new int();
            sum = 0;
            for (int i = 0; i <= 255; ++i){
                sum += i;
                Console.WriteLine("New number: {0} Sum: {1}", i, sum);
            }
        }
        // 4
        public static void ArrayIterate(int[] thisOne){
            foreach (int i in thisOne){
                Console.WriteLine(i);
            }
        }
        // 5
        public static int findMax(int[] arr){
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++){
                if (arr[i] > max){
                    max = arr[i];
                }
            }
            return max;
        }
        // 6
        public static void findAverage(int[] arr)
        {
            int average = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                average += arr[i];
            }
            average = arr.Length;
            Console.WriteLine(average);
        }
        // 7
        public static int[] arrayWithOddNumbers()
        {
            // have to return array, so seeing if I can easily convert from list
            List<int> oddList = new List<int>();
            for (int i = 1; i <= 255; ++i)
            {
                if (i%2 != 0){
                    oddList.Add(i);
                }
            }
            int[] oddArray = oddList.ToArray();
            return oddArray;
        }
        // 8
        public static void GreaterThanY(int[] arr, int y){
            int count = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > y)
                {
                    ++count;
                }
            }
            Console.WriteLine(count);
        }
        // 9
        public static int[] SquaretheValues(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i){
                arr[i] *= arr[i];
            }
            return arr;
        }
        // 10
        public static int[] EliminateNegatives(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] < 0)
                {
                    arr[i] = 0;
                }
            }
            return arr;
        }
        // 11
        public static void MinMaxAverage(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            int average = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
                if (max < arr[i])
                {
                    max = arr[i];
                }
                average += arr[i];
            }
            average = average/arr.Length;
            Console.WriteLine("Minimum: {0}\nMaximum: {1}\nAverage: {2}", min, max, average);
        }
        // 12
        public static int[] ShiftArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                arr[i] = arr[i + 1];
            }
            arr[arr.Length-1] = 0;
            return arr;
        }
        // 13
        public static object[] NumberToString(int[] arr)
        {
            object[] newArray = new object[arr.Length];
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] < 0)
                {
                    newArray[i] = "Dojo";
                }
                else
                {
                    newArray[i] = arr[i];
                }
            }
            return newArray;
        }
        public static void Main(string[] args)
        {
            foreach (var member in NumberToString(new int[]{1,5,10,-2})){
                Console.WriteLine(member);
            }
            // MinMaxAverage(new int[]{1,5,10,-2});
            
        }
    }
}
