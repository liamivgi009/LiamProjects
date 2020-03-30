using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Reflection;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetBufferSize(240, 63);
            Console.SetWindowSize(240, 63);
            design.machine();
            design.buildBottels();
            design.nav();
            design.personAnimate();
            machineDrinking s2 = new machineDrinking();
            while (1 > 0)
            {
                design.yKey();
                design.xKey();
                s2.keys();
                s2.music();
            }
        }

    }
    }

