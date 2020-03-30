using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.SetBufferSize(240,63);
            Console.SetWindowSize(240,63);
            design.frame(75,33);
            design.menu();
            design.personAnimate();
            time.timer();
            design.yKey();
            Console.ReadKey();






        }
    }
}
