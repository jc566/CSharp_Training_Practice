using System;
using System.Diagnostics.CodeAnalysis;

namespace Calculator
{
    public class Program
    {
        [ExcludeFromCodeCoverage]
        static void Main(string[] args)
        {
            //instantiate the variables
            float result;

            //make new instances of the classes
            addition add = new addition();
            subtraction subtract = new subtraction();
            multiplication multiply = new multiplication();
            division divide = new division();
            float[] plus = { 5, 2 };
            result = add.add(plus);
            Console.WriteLine(result + " = addition result.\n");
            result = subtract.subtract(2, 5);
            Console.WriteLine(result + " = subtract result.\n");
            result = multiply.multiply(5, 2);
            Console.WriteLine(result + " = multiplicaiton result.\n");
            result = divide.Divide(5, 2);
            Console.WriteLine(result + " = division result.\n");


            Console.ReadKey();
        }



    }


}
