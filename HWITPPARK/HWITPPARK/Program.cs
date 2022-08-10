using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWITPPARK
{
    class Program
    {
        static void Main(string[] args)
        {
            SnowManager snowManager = new SnowManager();
            snowManager.AddSnow(10);
            snowManager.StartSimulation();
            Console.ReadKey();
        }
    }
}
