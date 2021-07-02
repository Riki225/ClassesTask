using System;
using System.Collections.Generic;

namespace Task2
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime DOB;
        public DateTime dateonly;
        public int Height;
        public int Id;
        public Subject StuSubject;
        
        public Person(string firstname, string lastname, DateTime dob, int height, int id)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.DOB = dob;
            dateonly = DOB.Date;
            this.Height = height;
            this.Id = id;
            
        }

        public void GetFullName()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
        }
        
        public void GetHeightDifference()
        {
            int person1 = Height;
            int person2 = 0;
            int person3 = 0;

            if(person1 == 172)
            {
                person2 = 166;
                person3 = 192;
            }
            else if(person1 == 166)
            {   
                person2 = 172;
                person3 = 192;
            }
            else if(person1 == 192)
            {
                person2 = 172;
                person3 = 166;
            }
            int heightdiff1 = (person1 - person2);
            int heightdiff2 = (person1 - person3);

            string p1 = FirstName;
            string p2 = "p2";
            string p3 = "p3";

            if(p1 == "David")
            {
                p2 = "Gavin";
                p3 = "Oliver";
            }
            else if(p1 == "Gavin")
            {   
                p2 = "David";
                p3 = "Oliver";
            }
            else if(p1 == "Oliver")
            {
                p2 = "David";
                p3 = "Gavin";
            }

            Console.WriteLine($"Height Difference Between {p2} = {heightdiff1}");
            Console.WriteLine($"Height Difference Between {p3} = {heightdiff2}");
        }

        public void printID()
        {
            Console.WriteLine($"Student ID: {Id}");
        }

        public void AddSubject()
        {
            List<string> subjectList = new List<string>();
            string userInput = "s";
            Console.WriteLine("Please Enter A Subject To The Student's List. (Enter 'stop' When Finished.)");
            while (userInput != "stop")
            {
                userInput = Console.ReadLine();
                subjectList.Add(userInput);
                subjectList.Remove("stop");
            }

            Console.Write("Undertaking Subjects: ");

            foreach (string s in subjectList)
            {
                Console.Write($"{s}, ");
            }
        }
    }
}
