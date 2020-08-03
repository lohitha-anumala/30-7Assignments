using System;


 using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Assignment1ln

{
    abstract class Quadrilateral
    {

        public int length;
        public Quadrilateral()
        {

        }
        public Quadrilateral(int _length)
        {
            length = _length;
        }

        abstract public int Area();
        //abstract public void Display();

    }
    class Square : Quadrilateral
    {

        public Square()
        {

        }
        public Square(int length) : base(length)
        {

        }
        public override int Area()
        {
            int area = length * length;
            return area;
        }



    }
    class Rectangle : Quadrilateral
    {
        int breadth;


        public Rectangle()
        {

        }
        public Rectangle(int length, int _breath) : base(length)
        {
            breadth = _breath;



        }
        public override int Area()
        {
            return (breadth * length);
        }

    }

    class Program


    {
        static void Main(string[] args)
        {
            Square s = new Square(4);
            Console.WriteLine("Square Area : " + s.Area());

            Quadrilateral q = new Rectangle(6, 5);
            Console.WriteLine("Rectangle Area : " + q.Area());


            if (s.Area() > q.Area())
            {
                Console.WriteLine("Square area is greater than Rectangle area");
            }
            else
            {
                Console.WriteLine("Rectangle area is greater than Square area");
            }


            Console.Read();

        }
    } 
}

