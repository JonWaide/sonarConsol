using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sonarConsole
{
    class Bar
    {
        public string Append(string beginning, string end) //duplicate method 
        {
            return $"{beginning.ToString()}{end.ToString()}";
        }

    }
}
