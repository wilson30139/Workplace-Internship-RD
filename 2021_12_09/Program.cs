using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class ShapeFactory
    {
        public Shape MakeSquare()
        {
            Square s = new Square();
            return s;
        }
    }

    public class Square : Shape
    {

    }

    public class Shape
    {

    }
}
