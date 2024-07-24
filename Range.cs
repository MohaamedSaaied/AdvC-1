using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_1
{
    //Create a generic class named Range<T> where T represents the type of values.
    //Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.
     class Range<T> where T: IComparable<T>
    {
        private T s;
        private T e;

        //Implement a constructor that takes the minimum and maximum values to define the range.
        public Range(T s, T e)
        {
            this.s=s;
            this.e = e;  
        }

        //Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
        public void IsInRange(T x)
        {
            if (x.CompareTo(s) >= 0 && x.CompareTo(e) <= 0) Console.WriteLine($"{x} Is In Range");
            else Console.WriteLine($"{x} Is Not In Range");
        }

        //Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
        public int Length()
        {

            int length = Convert.ToInt32(e) - Convert.ToInt32(s);
            return length;
        }



    }
}
