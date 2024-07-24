namespace AdvC_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1

            ////The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases,
            ////which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm
            ////And implement the code of this optimized bubble sort algorithm

            //int[] a = {12,15,3,4,16,8,5,7,3,1};

            //Console.WriteLine("Array Before Sort:");
            //foreach (int x in a)
            //{
            //    Console.Write(x + " ");
            //}
            //Console.WriteLine(" ");
            //BubbleSort.Sort(a);
            //Console.WriteLine("Array After Sorted:");
            //foreach (int x in a)
            //{
            //    Console.Write(x + " ");
            //}


            #endregion

            #region 2

            ////create a generic Range < T > class that represents a range of values from a minimum value to a maximum value.
            ////The range should support basic operations such as checking if a value is within the range and determining the length of the range.

            ////Requirements:
            ////Create a generic class named Range<T> where T represents the type of values.

            ////Implement a constructor that takes the minimum and maximum values to define the range.

            ////Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.

            ////Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).

            ////Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.


            //Range<int> range = new Range<int>(1,5);
            //range.IsInRange(3);
            //Console.WriteLine($"The length is {range.Length()}");


            #endregion

        }
    }
}
