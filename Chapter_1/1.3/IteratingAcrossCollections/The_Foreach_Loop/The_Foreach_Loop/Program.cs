using System;
using System.Collections.Generic;
namespace The_Foreach_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Output for foreachLoop() is : \n");
            foreachLoop();
            Console.WriteLine("\n");

            Console.WriteLine("Output for CannotChangeForeachIterationVariable() is : \n");
            CannotChangeForeachIterationVariable();
            Console.WriteLine("\n");

            Console.WriteLine("Output for compiler_generated_code_for_a_foreach_loop() is : \n");
            compiler_generated_code_for_a_foreach_loop();
            Console.WriteLine("\n");
        }

        public static void foreachLoop()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };

            foreach(int i in values)
            {
                Console.WriteLine(i);
            }
        }

        /***********************************
         * Changing items in a foreach Loop*
         * *********************************/
         class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        public static void CannotChangeForeachIterationVariable()
        {
            /*
             * The Loop variable cannot be modified.
             * You can make modifications to the object that the variable points to, but you cant assign a new value to it.
             * */
            var people = new List<Person>
            {
                new Person() {FirstName = "John", LastName = "Doe"},
                new Person() {FirstName = "Jane", LastName = "Doe"}
            };

            foreach(Person p in people)
            {
                p.LastName = "Changed";
                Console.WriteLine(p.FirstName);
                Console.WriteLine(p.LastName);


                // p = new Person(); //gives a compiler error
            }
        }

        /****************************************************
         * The Compiler-generated code for a foreach loop   *
         * *************************************************/
         public static void compiler_generated_code_for_a_foreach_loop()
        {
            /*
             * If you change the value of e.Current to something else, the iterator pattern cant determine
             * what to do when e.MoveNext is called. 
             * This is why its not allowed to change the value of the iteration variable in a foreach statement.
             * */
            var people = new List<Person>
            {
                new Person() {FirstName = "John", LastName = "Doe"},
                new Person() {FirstName = "Jane", LastName = "Doe"}
            };

            List<Person>.Enumerator e = people.GetEnumerator();

            try
            {
                Person v;
                while(e.MoveNext())
                {
                    v = e.Current;
                }
            }
            finally
            {
                System.IDisposable d = e as System.IDisposable;
                if (d != null) d.Dispose();
            }
        }
    }
}
