using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            add();
            sub();
            mult();
        }

        private static void add()
        {
            NumPattern p = new NumPattern("+");
            p.init();
            p.displayPattern();
            p.getUserInput();
        }
        private static void sub()
        {
            NumPattern p = new NumPattern("-");
            p.init();
            p.displayPattern();
            p.getUserInput();
        }
        private static void mult()
        {
            NumPattern p = new NumPattern("*");
            p.init();
            p.displayPattern();
            p.getUserInput();
        }
    }
}
