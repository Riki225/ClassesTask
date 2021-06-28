using System;

namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person David = new Person("David","Killan", new DateTime(2000, 5, 1), 172);
            David.GetFullName();
            //David.GetHeightDifference();

            Person Gavin = new Person("Gavin", "Chung", new DateTime(2002,3,6), 166);
            Gavin.GetFullName();
            //Gavin.GetHeightDifference();

            Person Oliver = new Person("Oliver", "Smith", new DateTime(1998,10,27), 192);
            Oliver.GetFullName();
            //Oliver.GetHeightDifference();

        }
    }
}
