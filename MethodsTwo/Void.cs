using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTwo
{
    class Void
    {
        public int speed;

        static void Main(string[] args)
        {
            Void m = new Void();
            m.speed = 90;
            m.print();
            m.result();

            m.speed = 55;
            m.print();
            m.result();
            Console.Read();
        }

        public void print()
        {
            Console.Write("Print the result: ");
        }

        public void result()
        {
            if (speed < 0)
            {
                return;
            }
            else
            {
                if (speed < 60)
                    Console.WriteLine("No ticket");
                else
                    Console.WriteLine("You get a ticket!");
            }
        }
    }
}
