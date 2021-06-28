using System;

namespace Task2
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime DOB;
        public DateTime dateonly;
        public int Height;
        
        public Person(string firstname, string lastname, DateTime dob, int height)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.DOB = dob;
            dateonly = DOB.Date;
            this.Height = height;
        }

        public void GetFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
        }
        
        public void GetHeightDifference()
        {
            int person1 = 0;
            int person2 = 0;

            int p1 = 0;
            int p2 = 0;

            Console.WriteLine("Please Select A Person");
            Console.WriteLine("(1) David");
            Console.WriteLine("(2) Gavin");
            Console.WriteLine("(3) Oliver");
            person1 = int.Parse(Console.ReadLine());
            
            if(person1 == 1)
            {
                p1 = David.Height;
            }
            else if(person1 == 2)
            {
                p1 = Gavin.Height;
            }
            else if(person1 == 3)
            {
                p1 = Oliver.Height;
            }

            Console.WriteLine("Please Select Another Person");
            Console.WriteLine("(1) David");
            Console.WriteLine("(2) Gavin");
            Console.WriteLine("(3) Oliver");
            person2 = int.Parse(Console.ReadLine());
            
            if(person2 == 1)
            {
                p2 = David.Height;
            }
            else if(person1 == 2)
            {
                p2 = Gavin.Height;
            }
            else if(person1 == 3)
            {
                p2 = Oliver.Height;
            }

            int HeightDiff = p1 - p2;
            Console.WriteLine(HeightDiff);

            
        
        }
    }
}
