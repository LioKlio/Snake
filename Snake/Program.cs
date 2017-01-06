using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Func1(x);
            Console.WriteLine("Call Func1. x = " + x);     

            x = 3;
            Func2(x);
            Console.WriteLine("Call Func2. x = " + x);

            x = 1;
            Func3(x);
            Console.WriteLine("Call Func3. x = " + x);
            

            Point p1 = new Point(1,2,"*");
            Move(p1, 10, 10);
            /*p1.Draw();*/

            Point p2 = new Point(2,4,"#");
            Reset(p2);
            /*p2.Draw();*/

            Console.WriteLine("1 p1.x = " + p1.x + "; p2.x = " + p2.x);
            p1 = p2;
            Console.WriteLine("2 p1.x = " + p1.x + "; p2.x = " + p2.x);

            Console.ReadLine();
        }
        public static void Func1(int x)
        {
            Console.WriteLine("Call Func1 1. x = " + x);
            x = x + 2;
            Console.WriteLine("Call Func1 2. x = " + x);
        }
        public static void Func2(int x) { x = x; }
        public static void Func3(int a) { a = a + 9; }

        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }
        public static void Reset(Point p)
        {
            p = new Point();
        }
    }
}
