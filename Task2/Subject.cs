using System;
using System.Collections.Generic;

namespace Task2
{
    public class Subject
    {
        public List<string> subjectList;
        public string Name;
        public int YearOfDelivery;

        public Subject(string name, int yearofdelivery)
        {
            this.Name = name;
            this.YearOfDelivery = yearofdelivery;
        }


        
    }
}