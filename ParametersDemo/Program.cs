using System;

namespace ParametersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pass by Value
            Console.WriteLine("Pass by value test:");
            int testVal1 = 1;
            Console.WriteLine("Original value: {0}",testVal1);
            Test(testVal1);
            Console.WriteLine("Returned value: {0}", testVal1);

            //pass in a reference type
            Console.WriteLine("\nPass in a reference type test:");
            int[] testArray = { 1, 1, 1 };
            Console.WriteLine("Original value: {0}", testArray[0]);
            TestArray(testArray);
            Console.WriteLine("Returned value: {0}",testArray[0]);

            //out parameter test
            Console.WriteLine("\nOut parameter test:");
            int testVal2;
            // Console.WriteLine("Original value: {0}", testVal2);
            TestOut(out testVal2);
            Console.WriteLine("Returned value: {0}", testVal2);


            //Ref parameter test
            Console.WriteLine("\nRef parameter test:");
            int testVal3 = 3;
            Console.WriteLine("Original value: {0}", testVal3);
            TestRef(ref testVal3);
            Console.WriteLine("Returned value: {0}", testVal3);

            //optional parametter passed by position
            Console.WriteLine("\nCalling TestOptional with a parameter");
            TestOptional(4);

            //optional parameter pass with no parameters
            Console.WriteLine("\nCalling TestOptional with no parameter");
            TestOptional();


            //Multiple parameters
            Console.WriteLine("\nTestMultiple all three set");
            TestMultiple(1, 2, 3);


            //Multiple parameters not all set
            Console.WriteLine("\nTestMultiple set first two");
            TestMultiple(1, 2);


            //Multiple parameters with named parameter
            Console.WriteLine("\nTestMultiple set 1 by pos, 3 by name, 2 by default");
            TestMultiple(1, cValue: 3);


            //overload test string method
            Console.WriteLine("\nTest overloaded method with string");
            TestOverloaded("Test with string");

            //overload test numeric method
            Console.WriteLine("\nTest overloaded method with numbers");
            TestOverloaded(5, 5.5);




        }
        public static void Test(int aValue)
        {
            aValue = 111;
            Console.WriteLine("In Test Value is {0}", aValue);
        }

        public static void TestArray(int[] anArray)
        {
            anArray[0] = 111;
            Console.WriteLine("In TestArray, value is {0}", anArray[0]);
        }

        public static void TestOut(out int aValue)
        {
            aValue = 222;
            Console.WriteLine("In TestOut value is {0}", aValue);
        }

        public static void TestRef(ref int aValue)
        {
            aValue = 333;
            Console.WriteLine("In TestRef, value is {0}", aValue);
        }

        public static void TestOptional(int aValue = 444)
        {
            Console.WriteLine("in TestOptional, value is {0}", aValue);

        }

        public static void TestMultiple(int aValue, int bValue=222, int cValue = 333)
        {
            Console.WriteLine("Inside TestMultiple - Values: {0}, {1}, {2}", aValue, bValue, cValue);
        }

        public static void TestOverloaded(string strParam)
        {
            Console.WriteLine("String overload called with a value of {0}",strParam);
        }
        public static void TestOverloaded(int intParam, double dblParam)
        {
            Console.WriteLine("Numeric overload called with values of {0} and {1}", intParam, dblParam);
        }
    }
}
//2.5 the values for testVal1 and aValue are completely separated, as the function call Test(testVal1) is passing
//by value, so no changes are made to testVal1 in Test().
//
//3.4 the function call TestArray(testArray) is passing an array, which is a reference type.  So, anArray and testArray
//are actually the same array. Changes in the function TestArray() to anArray[] are also changing testArray[] in Main().
//
//4.4 TestOut() is passing a value type (aValue) by using an out parameter.  This makes the program pass the parameter by
//reference, so testVal2 in Main() and aValue in TestOut() are actually the same variable.  Changes to aValue in TestOut()
//therefore change testVal2 in Main().
//
//5.4 Again, passing a value type (aValue) by reference, exept using ref vs out.  Parameter is passed as reference, both 
//both variables reference same mem location, changes to aValue in the function affect changes to testVal3 in Main().
//
//