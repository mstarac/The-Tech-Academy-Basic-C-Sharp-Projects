using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Five
{
    class ClassDivider
    {
        public void Division(int M, out int N)
        {
            N = M / 2;
        }
        public static void Division(decimal P, out decimal Q)
        {
            Q = P / 2;
        }
        int M { get; set; }
        int N { get; set; }
        decimal P { get; set; }
        decimal Q { get; set; }
    }
}
