using System;

namespace Task1
{
    class Program
    {
        public static void Main() {
            Colour RedBlast = new Colour(255, 255, 30, "RedBlast");
            Colour GreenMint = new Colour(0, 255, 95, "GreenMint");
            Colour BlueChuckle = new Colour(25, 63, 255, "BlueChuckle");
            
            Cookie Cookie1 = new Cookie(36, "Circle", RedBlast);
            Cookie1.features();
            
            Cookie Cookie2 = new Cookie(36, "Square", GreenMint);
            Cookie1.features();

            Cookie Cookie3 = new Cookie(36, "Rectangle", BlueChuckle);
            Cookie1.features();
            
            Cookie Cookie4 = new Cookie(36, "Triangle", GreenMint);
            Cookie1.features();
        }
    }
}
