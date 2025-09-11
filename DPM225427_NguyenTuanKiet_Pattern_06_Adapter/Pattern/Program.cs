using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    public class Program
    {
         public static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Request();
            Console.ReadKey();
        }
    }
}
