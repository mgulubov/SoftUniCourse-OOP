using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _03.PCCatalog.Classes;

namespace _03.PCCatalog
{
    class PCCatalog
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer("PC 1");

            comp.AddComponent("CPU", 300m);
            comp.AddComponent("GFX", 500m);
            comp.AddComponent("RAM", 100m);

            Console.WriteLine(comp.ToString());
        }
    }
}
