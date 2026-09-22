using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1_Linq
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Part 1
            #region prob1
            var x = 5;
            var str = "rawan";
            var y = 55.6;
            var isTrue = true;
            var arr = new int []{ 1, 2, 3 };

            Console.WriteLine(x.GetType());
            Console.WriteLine(str.GetType());
            Console.WriteLine(y.GetType());
            Console.WriteLine(isTrue.GetType());
            Console.WriteLine(arr.GetType());


            #endregion

            #region prob2
            // Explicit types
            int age1 = 21;
            string name1 = "Rawan";
            double salary1 = 50.5;
            bool isActive1 = true;

            // var
            var age2 = 21;
            var name2 = "Rawan";
            var salary2 = 50.5;
            var isActive2 = true



         /* The result is exactly the same at compile time because
            the compiler determines the type of each var variable
            from its assigned value.
         var does NOT mean dynamic.
         */
            #endregion

            //Part 2
            #region 1
            var Producct = new { Name = "Ball", Price = 5000, Quantity = 40 };
            Console.WriteLine(Producct.Name);
            Console.WriteLine(Producct.Price);
            Console.WriteLine(Producct.Quantity);
            #endregion

            #region 2
            var Students = new[]
            {
                new {Name = "Ahmed" , Grade = 90},
                new {Name = "Doha" , Grade = 80},
                new {Name = "Toqa" , Grade = 95},
            }

            foreach(var stud in Students)
            {
                Console.WriteLine($"{stud.Name} grade is {stud.Grade}");
            }
            #endregion



        }
    }
}
