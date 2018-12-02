using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOne
{
    class MathOperation
    {
        public class oneMath
        {
            public oneMath(int a)
            {
                this.a = a + 2;
            }
            public int a { get; set; }
        }
        public class twoMath
        {
            public twoMath(int b)
            {
                this.b = b * 2;
            }
            public int b { get; set; }
        }
        public class threeMath
        {
            public threeMath(int c)
            {
                this.c = c / 2;
            }
            public int c { get; set; }
        }
    }
}



