using System;

namespace Task1
{
    public class Cookie
    {
        public int Weight {get;set;}
        public string Shape {get;set;}
        public Colour CookieColour;

        public Cookie(int weight, string shape, Colour cookiecolour)
        {
            this.Weight = weight;
            this.Shape = shape;
            this.CookieColour = cookiecolour;
        }
        public void features()
        {
            Console.WriteLine(Weight);
            Console.WriteLine(Shape);
            Console.WriteLine(CookieColour.red);
            Console.WriteLine(CookieColour.green);
            Console.WriteLine(CookieColour.blue);
            Console.WriteLine(CookieColour.name);

        }
       
    
    }
    
}
