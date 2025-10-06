using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorld
{
    public class CircleCreator : ShapeCreator
    {
        public override Shape FactoryMethod()
        {
            return new Circle(); 
        }
    }
}
