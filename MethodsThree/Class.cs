using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsThree
{
    class Class
    {
        public int DoMath(int input)

        {
            return input * 10;

        }
        public int DoMath(decimal input)
        {
            return (int)(input + 10);
        }
        public int DoMath(string input)
        {
            int result = 0;

            try
            {
                result = Convert.ToInt32(input);
            }

            catch

            {
                Console.WriteLine("Error! Can't convert string to integer");
                return 0;
            }
            

            return result;
        }
    }
}
  