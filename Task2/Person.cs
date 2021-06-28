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
            int p1 = Height;
            int p2 = 0;

            

            
        
        }
    }
}
