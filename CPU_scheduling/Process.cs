using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_scheduling
{
    class Process
    {
        private string ID;
        private int tArrival;
        private int tBurst;
        private int priority;

        public Process(string id, int ta, int tb, int pr)
        {
            ID = id; tArrival = ta; tBurst = tb; priority = pr;
        } 
        
        public void generateRandom()
        {

        }
    }
}
