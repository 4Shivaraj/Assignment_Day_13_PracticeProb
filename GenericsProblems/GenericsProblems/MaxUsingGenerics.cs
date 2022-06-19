using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{

    public class FindMaxNum<T> where T : IComparable
    {
        public T[] array;
        public FindMaxNum(T[] array)
        {
            this.array = array;
        }
        public void GetMaximum(T Value1, T Value2, T Value3)
        {
            array[0] = Value1; array[1] = Value2; array[2] = Value3;
            Array.Sort(array);
            Console.WriteLine($"Max value is: {array[2]}");
        }
    }
}



