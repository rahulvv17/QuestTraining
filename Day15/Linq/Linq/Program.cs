using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new int[] {1,2,3,4,5};
            var r = data.Where(i => i > 1);
        }
    }
}
