using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1_Linq
{
    internal class Program
    {
        class Employee
        {
            public int Id { get; set; }

            public string Name { get; set; }
            public double Salary { get; set; }

            public Employee(string name, double salary)
            {
                Name = name;
                Salary = salary;
            }
        }

         static class Extentions
        {
            public  static bool IsPalindrome(this string s)
            {
                if (s == null)
                    return false; 

                for(int i = 0; i<s.Length/2; i++)
                {
                        if (s[i] != s[s.Length - 1 - i]) return false;
                }

                return true;
            }

            public static bool IsPrime (this int number)
            {
                if (number < 2) return false;

                for(int i = 2; i < number; i++)
                {
                    if (number % i == 0) return false;
                }
                return true;
            }

            public static int Sum(this int[] nums)
            {
                int sum = 0;
                for(int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                }
                return sum;
            }
        }
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
            var isActive2 = true;



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
            };

            foreach(var stud in Students)
            {
                Console.WriteLine($"{stud.Name} grade is {stud.Grade}");
            }

            #endregion

            #region 3
            
            var Order = new {
                OrderId = 201, ProductName = "Ball", Price = 2500.0, 
                Customer = new { Name = "Rawan", City = "Giza" }
            };
            Console.WriteLine("Order ID: " + Order.OrderId);
            Console.WriteLine("Product: " + Order.ProductName);
            Console.WriteLine("Price: " + Order.Price);
            Console.WriteLine("Customer Name: " + Order.Customer.Name);
            Console.WriteLine("Customer City: " + Order.Customer.City);
            #endregion

            //Part 3
            string word1 = "level";
            string word2 = "hello";
            string word3 = "radar";
            Console.WriteLine("IsPalindrome:");
            Console.WriteLine(word1 + " -> " + word1.IsPalindrome());
            Console.WriteLine(word2 + " -> " + word2.IsPalindrome());
            Console.WriteLine(word3 + " -> " + word3.IsPalindrome());

            
            int number1 = 7;
            int number2 = 1;
            int number3 = 13;
            Console.WriteLine("IsPrime:");
            Console.WriteLine(number1 + " -> " + number1.IsPrime());
            Console.WriteLine(number2 + " -> " + number2.IsPrime());
            Console.WriteLine(number3 + " -> " + number3.IsPrime());


            int[] values = { 10, 20, 30, 40 };
            Console.WriteLine("Sum = " + values.Sum());

            //Part 4

            #region 9
            List<string> employees = new List<string>();

            employees.Add("Ahmed");
            employees.Add("Mona");
            employees.Add("Omar");
            employees.Add("Sara");

            employees.Remove(employees[0]); 
            bool found = false;
            for(int i = 0; i < employees.Count; i++)
            {
                if (employees[i] == "Mona")
                {
                    found = true; break;
                }
            }
            if (found) Console.WriteLine("Mona was found");
            else
                Console.WriteLine("Mona was not found.");


            foreach (string emp in employees)
            {
                Console.WriteLine(emp);
            }
            #endregion

            #region 10
            List<Employee> employeeList = new List<Employee>();

            employeeList.Add(new Employee("Ahmed", 6000));
            employeeList.Add(new Employee("Mona", 4500));
            employeeList.Add(new Employee("Omar", 8000));
            employeeList.Add(new Employee("Sara", 5500));
            double givenSalary = 1000.0;
            for(int i = 1;i < employeeList.Count; i++)
            {
                if (employeeList[i].Salary > givenSalary)
                {
                    Console.WriteLine($"Name {employeeList[i].Name} | Salary {employeeList[i].Salary}");
                }
            }
          
            #endregion

            #region 11 
            Dictionary<string,int> products = new Dictionary<string,int>();

            products.Add("Laptop", 25000);
            products.Add("Phone", 15000);
            products.Add("Headphones", 3000);
            products.Add("Keyboard", 1500);

            foreach (KeyValuePair<string,int> i in products)
            {
                Console.WriteLine($"{i.Key} is  {i.Value}");
            }
            #endregion

            #region 12 
            Dictionary<int,string> student = new Dictionary<int,string>();
            student.Add(101, "Ahmed");
            student.Add(102, "Mona");
            student.Add(103, "Omar");
            student.Add(104, "Sara");

            Console.WriteLine("Enter student Id: ");
            int id = int.Parse(Console.ReadLine());
            string studentName;

            if (student.TryGetValue(id, out studentName))
                Console.WriteLine($"Student Name is: {studentName}");
            else
                Console.WriteLine("Student ID was not found.");

            #endregion

            #region 13

            Hashtable table = new Hashtable();

            table.Add(1, "Ahmed");
            table.Add(2, "Mona");
            table.Add("Course", "C#");
            table.Add("Age", 21);

            foreach(DictionaryEntry i in table)
            {
                Console.WriteLine("Key: " + i.Key + ", Value: " + i.Value);
            }

            #endregion

            #region 14 
            Dictionary<string, string> dictionary =
           new Dictionary<string, string>();

            dictionary.Add("Name", "Rawan");
            dictionary.Add("City", "Cairo");
            dictionary.Add("Course", "C#");

            Hashtable hashtable = new Hashtable();

            hashtable.Add("Name", "Rawan");
            hashtable.Add("City", "Cairo");
            hashtable.Add("Course", "C#");

            Console.WriteLine("\n14. Dictionary:");

            foreach (KeyValuePair<string, string> item in dictionary)
            {
                Console.WriteLine(
                    item.Key + " -> " + item.Value
                );
            }

            Console.WriteLine("\nHashtable:");

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(
                    item.Key + " -> " + item.Value
                );
            }

            /*
             * Practical difference:
             *
             * Dictionary<string, string> is strongly typed.
             * Both the key and value must be strings.
             *
             * Hashtable is non-generic, so it can store different
             * types of keys and values, and values are accessed as object.
             */
            #endregion

            //Short Write-Ups
            //1.Difference between a delegate and a lambda expression
            //A delegate is a type that can store a reference to a method with a specific signature.
            //A lambda expression is a short way to write an anonymous function that can be assigned to a delegate.

            //2.Why is var still statically typed?
            //var is statically typed because the compiler determines the variable's type at compile time from the value assigned to it.
            /*
                For example:
                        var age = 20;
                        The compiler knows that age is an int.
                        So this is not allowed:
                        var age = 20;
                        age = "Rawan"; // Error
            */
            //var only saves us from writing the type explicitly; it does not make the variable dynamically typed.


            //3.Real scenario where an anonymous type is more convenient
            //Anonymous types are useful when we need a small temporary object and don't need a reusable class.
            //For example, when preparing data for a report:
            //var reportData = new
            //{
            //    EmployeeName = "Rawan",
            //    Department = "IT",
            //    Salary = 10000
            //};

            //If this data is only needed temporarily inside one method, creating a complete EmployeeReport class may be unnecessary.An anonymous type keeps the code simple and concise.
        }
    }
}
