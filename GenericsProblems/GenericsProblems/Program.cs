// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Welcome to generics problems");
namespace GenericsProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Choose The Option Can Be Executed: ");
            Console.WriteLine("Find the Max Value Out Of Three: \n1.Integers \n2.Float \n3.String \n4.Exit");
            Console.Write("Enter the selected Option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    TestCases.IntTest();
                    break;

                case 2:
                    TestCases.FloatTest();
                    break;

                case 3:
                    TestCases.StringTest();
                    break;
                default:
                    Console.WriteLine("Invlid Choice");
                    break;

            }
        }
    }
}

//Refactor-2
//Refactor to create Generic Class to take in 3 variables of Generic Type

//- Ensure the Generic Type extends Comparable
//- Write parameter constructor
//- Write testMaximum method to internally call the static testMaximum method passing the 3 instance variables
//- Define new test case to use the Generic Class

//Result

//Please Choose The Option Can Be Executed:
//Find the Max Value Out Of Three:
//1.Integers
//2.Float
//3.String
//4.Exit
//Enter the selected Option: 1
//Test Case 1:[8, 10, 2]
//Max value is: 10
//Test Case 2:[2, 40, 50]
//Max value is: 50
//Test Case 3:[50, 30, 20]
//Max value is: 50
//--------------------------------------------
//Please Choose The Option Can Be Executed:
//Find the Max Value Out Of Three:
//1.Integers
//2.Float
//3.String
//4.Exit
//Enter the selected Option: 2
//Test Case 1:[2.5, 3.8, 4.5]
//Max value is: 4.5
//Test Case 2:[9.6, 5.5, 2.8]
//Max value is: 9.6
//Test Case 3:[5.6, 10.5, 2.6]
//Max value is: 10.5
//-----------------------------------------------
//Please Choose The Option Can Be Executed:
//Find the Max Value Out Of Three:
//1.Integers
//2.Float
//3.String
//4.Exit
//Enter the selected Option: 3
//Test Case 1:[Shivaraj, Arun, Deepak]
//Max value is: Shivaraj
//Test Case 2:[Pen, Scale, Eraser]
//Max value is: Scale
//Test Case 3:[Shravani, Raksha, Punya]
//Max value is: Shravani
//-----------------------------------------------