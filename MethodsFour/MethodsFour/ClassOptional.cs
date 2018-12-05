using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsFour
{
    public class ClassOptional
    {
        public void optionalModifier(int x, int z = 0)
        {
             this.x = x + 20;
             this.z = z * 20;
        }

        public int x { get; set; }
        public int z { get; set; }
    }
}
