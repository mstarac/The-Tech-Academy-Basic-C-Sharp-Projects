using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Math1
    {
        public Math1(int a)
        {
            this.a = a + 2;
        }
        public int a { get; set; }
    }
    public class Math2
    {
        public Math2(int b)
        {
            this.b = b * 2;
        }
        public int b { get; set; }
    }
    public class Math3
    {
        public Math3(int c)
        {
            this.c = c / 2;
        }
        public int c { get; set; }
    }
}


