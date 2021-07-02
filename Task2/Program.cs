using System;
using System.Collections.Generic;

namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rand1 = new Random();
            int ID1 = rand1.Next(1000, 10000);

            Random rand2 = new Random();
            int ID2 = rand2.Next(1000, 10000);

            Random rand3 = new Random();
            int ID3 = rand3.Next(1000, 10000);


            Person David = new Person("David","Killan", new DateTime(2000, 5, 1), 172, ID1);
            David.GetFullName();
            David.printID();
            David.GetHeightDifference();
            David.AddSubject();
            Console.WriteLine();
            Console.WriteLine("***************************************************");

            Person Gavin = new Person("Gavin", "Chung", new DateTime(2002,3,6), 166, ID2);
            Gavin.GetFullName();
            Gavin.printID();
            Gavin.GetHeightDifference();
            Gavin.AddSubject();
            Console.WriteLine();
            Console.WriteLine("***************************************************");

            Person Oliver = new Person("Oliver", "Smith", new DateTime(1998,10,27), 192, ID3);
            Oliver.GetFullName();
            Oliver.printID();
            Oliver.GetHeightDifference();
            Oliver.AddSubject();
            Console.WriteLine();
            Console.WriteLine("***************************************************");

        }
    }
}
