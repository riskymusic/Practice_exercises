using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {

        static void Main(string[] args)
        {
            //q1
            //{
            //   // Console.WriteLine("Hello");
            //    //Console.WriteLine("Tamawera Owens");
            //    //Console.WriteLine("Press enter for next questions");
            //    //Console.ReadLine();

            //q2
            //    {
            // Console.WriteLine("Please enter first number: ");
            // int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter your second number: ");
            //int num2 = int.Parse(Console.ReadLine());
            // int sum = num1 + num2;
            // Console.WriteLine($"{num1} + {num2} = {sum}");
            // Console.WriteLine("Press enter for next question");
            // Console.ReadLine();

            //}
            //q3
            //{
            //    Console.WriteLine("Please enter first number: ");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Please enter your second number: ");
            //    int num2 = int.Parse(Console.ReadLine());
            //    int sum = num1 / num2;
            //    Console.WriteLine($"{num1} / {num2} = {sum}");
            //    Console.WriteLine("Press enter for next question");
            //    Console.ReadLine();
            //}
            //q4
            //{
            //    Console.WriteLine("Enter a number: ");
            //    int num = int.Parse(Console.ReadLine());
            //    int i;
            //    for (i = 0; i < 11; i++)

            //    {
            //        Console.WriteLine($"{num} x {i} = {num *i} ");

            //    }
            //Console.ReadLine();
            //{
            //    Console.Write($"Please input the radius of your circle: ");
            //    int rad = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"perimeter = {Perimeter(rad)}\nArea = {Area(rad)}");
            //    Console.ReadLine();

            //}
            //static double Area(int radius)

            //{
            //    return Math.PI * radius * radius;
            //}
            //static double Perimeter(int radius)

            //{
            //    return radius * Math.PI;
            //}

            //Number swap 
            //{
            //    int num1 = 10;
            //    int num2 = 20;
            //    int num3;

            //    Console.WriteLine($"num1: {num1}\nnum2: {num2}");

            //    num3 = num1;
            //    num1 = num2;
            //    num2 = num3;
            //    Console.WriteLine($"num1: {num1}\nnum2: {num2}");
            //    Console.ReadLine();
            //}



            Animal[] animals = new Animal[3];
            for (int i = 0; i < 3; i++)
            {
                Animal A1 = new Animal();
                Console.Write("Please enter the animals type: ");
                A1.Type = Console.ReadLine();
                Console.Write("Please enter the animals name: ");
                A1.Name = Console.ReadLine();
                Console.Write("Please enter the animals age: ");
                A1.Age = int.Parse(Console.ReadLine());
                Console.Write("Please enter the animals Id: ");
                A1.ID = int.Parse(Console.ReadLine());
                Console.WriteLine(A1.Details());
                animals[i] = A1;


            }

        }
    }

    class Animal
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ID { get; set; }

        public string Details()
        {
            return $"Animal Details....\n" +
                $"Type = {Type}\n" +
                $"Name = {Name}\n" +
                $"Age = {Age}\n" +
                $"ID = {ID}\n";
        }

    }
}











    

