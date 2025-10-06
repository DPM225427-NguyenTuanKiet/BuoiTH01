using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ShapeCreator[] creators = new ShapeCreator[2];
            creators[0] = new CircleCreator(); 
            creators[1] = new SquareCreator();  

            foreach (ShapeCreator creator in creators)
            {
                creator.DrawShape(); 
            }

            Console.ReadKey();
        }
    }
}
