using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sonarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var foo = new Foo();
            var bar = new Bar();

            string x = "abc";
            string y = "def";

            if (foo.Append(x, y) == bar.Append(x, y))
            {
                Console.WriteLine("haha".ToString());
            }
            else
            {
                Console.WriteLine("boohoo");
            }

            Console.ReadKey();
        }
    }
}
