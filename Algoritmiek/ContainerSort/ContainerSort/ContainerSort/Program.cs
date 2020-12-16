using System;
using System.Collections.Generic;
using System.Xml;

namespace ContainerSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship();

            string inputLength;
            string inputWidth;
            
            int Length;
            int Width;
            
            
            
            
            Console.WriteLine("How many rows of containers in lenght?");
            inputLength = Console.ReadLine();
            Length = Int32.Parse(inputLength);
            ship.Length = Length;

            Console.WriteLine("How many rows of containers in width?");
            inputWidth = Console.ReadLine();
            Width = Int32.Parse(inputWidth);
            ship.Width = Width;

            int AvailableContainerSpace = ship.Length * ship.Width;
            
            

            Console.WriteLine("De beschikbare plaatsen zijn:" + AvailableContainerSpace);
            Console.WriteLine("De hoogte is gelimiteerd tot 120.000 kg");
            Console.ReadLine();
            
            
            List<Container>container = new List<Container>();
            container.Add(new Container(20000, false, true));
            ;

        }
    }
}