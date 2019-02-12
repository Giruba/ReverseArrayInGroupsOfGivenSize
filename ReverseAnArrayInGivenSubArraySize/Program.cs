using System;

namespace ReverseAnArrayInGivenSubArraySize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse subarrays of size K in an array!");
            Console.WriteLine("----------------------------------------");

            try
            {
                int[] array = GetArrayFromInput();
                Console.WriteLine("Enter the size for the subarrays for reversal");
                int K = int.Parse(Console.ReadLine());
                PrintSubArrayReversedArray(array, K);
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }

            Console.ReadLine();
        }

        private static int[] GetArrayFromInput() {
            int[] array = null;

            Console.WriteLine("Enter the number of elements in the array");
            try
            {
                int noElements = int.Parse(Console.ReadLine());
                array = new int[noElements];
                Console.WriteLine("Enter the elements separated by space");
                String[] elements = Console.ReadLine().Split(' ');
                for (int index = 0; index < noElements; index++) {
                    array[index] = int.Parse(elements[index]);
                }
            }
            catch (Exception exception) {
                Console.WriteLine("GetArrayFromInput(): Thrown exception is " + exception.Message);
            }

            return array;
        }

        private static void PrintSubArrayReversedArray(int[] array, int K) {

            for (int index = 0; index < (array.Length - K + 1); index = index + K) {
                array = ReverseArray(array, index, index+K-1);
            }

            Console.WriteLine("Printing output-------------");

            for (int index = 0; index < array.Length; index++) {
                Console.Write(array[index]+" ");
            }

            Console.WriteLine();
        }

        private static int[] ReverseArray(int[] array, int startIndex, int endIndex) {

            while (startIndex < endIndex) {
                int temp = array[startIndex];
                array[startIndex] = array[endIndex];
                array[endIndex] = temp;
                startIndex++;
                endIndex--;
            }
            return array;
        }
    }
}
