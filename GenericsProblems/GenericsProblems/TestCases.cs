using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblems
{
    internal class TestCases
    {
        public static int[] IntCase1;
        public static int[] IntCase2;
        public static int[] IntCase3;
        public static float[] FloatCase1;
        public static float[] FloatCase2;
        public static float[] FloatCase3;
        public static string[] StringCase1;
        public static string[] StringCase2;
        public static string[] StringCase3;

        //Initialization
        static TestCases()
        {
            IntCase1 = new int[] { 8, 10, 2 };
            IntCase2 = new int[] { 2, 40, 50 };
            IntCase3 = new int[] { 50, 30, 20 };
            FloatCase1 = new float[] { 2.5f, 3.8f, 4.5f };
            FloatCase2 = new float[] { 9.6f, 5.5f, 2.8f };
            FloatCase3 = new float[] { 5.6f, 10.5f, 2.6f };
            StringCase1 = new string[] { "Shivaraj", "Arun", "Deepak" };
            StringCase2 = new string[] { "Pen", "Scale", "Eraser" };
            StringCase3 = new string[] { "Shravani", "Raksha", "Punya" };
        }

        public static string GetString<T>(T[] testCase)
        {
            return $"[{testCase[0]}, {testCase[1]}, {testCase[2]}]";
        }

        public static void IntTest()
        {
            Console.WriteLine("Test Case 1:" + GetString(IntCase1));
            FindMaxNum.GetMaximum<int>(IntCase1[0], IntCase1[1], IntCase1[2]);
            Console.WriteLine("Test Case 2:" + GetString(IntCase2));
            FindMaxNum.GetMaximum<int>(IntCase2[0], IntCase2[1], IntCase2[2]);
            Console.WriteLine("Test Case 3:" + GetString(IntCase3));
            FindMaxNum.GetMaximum<int>(IntCase3[0], IntCase3[1], IntCase3[2]);
            Console.ReadKey();
        }

        public static void FloatTest()
        {
            Console.WriteLine("Test Case 1:" + GetString(FloatCase1));
            FindMaxNum.GetMaximum<float>(FloatCase1[0], FloatCase1[1], FloatCase1[2]);
            Console.WriteLine("Test Case 2:" + GetString(FloatCase2));
            FindMaxNum.GetMaximum<float>(FloatCase2[0], FloatCase2[1], FloatCase2[2]);
            Console.WriteLine("Test Case 3:" + GetString(FloatCase3));
            FindMaxNum.GetMaximum<float>(FloatCase3[0], FloatCase3[1], FloatCase3[2]);
            Console.ReadKey();

        }

        public static void StringTest()
        {
            Console.WriteLine("Test Case 1:" + GetString(StringCase1));
            FindMaxNum.GetMaximum<string>(StringCase1[0], StringCase1[1], StringCase1[2]);
            Console.WriteLine("Test Case 2:" + GetString(StringCase2));
            FindMaxNum.GetMaximum<string>(StringCase2[0], StringCase2[1], StringCase2[2]);
            Console.WriteLine("Test Case 3:" + GetString(StringCase3));
            FindMaxNum.GetMaximum<string>(StringCase3[0], StringCase3[1], StringCase3[2]);
            Console.ReadKey();
        }

    }
}
 