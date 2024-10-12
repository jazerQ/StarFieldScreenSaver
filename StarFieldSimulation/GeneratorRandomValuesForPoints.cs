using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarFieldSimulation
{
    static class GeneratorRandomValuesForPoints
    {
        static GeneratorRandomValuesForPoints(){
            rand = new Random();
        }
        public static Random rand;
    }
}
