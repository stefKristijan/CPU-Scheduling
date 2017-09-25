using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_scheduling
{
    class cProcess
    {
        private string id;
        private int tArrival;
        private int tBurst;
        private int priority;
        private int progress;
        private int progressLeft;
        private Color processColor;

        public cProcess(string i, int ta, int tb, int pr, Color c)
        {
            id = i; tArrival = ta; tBurst = tb; priority = pr; processColor = c; progress = 0; progressLeft = tb;
        }
        
        public cProcess() { ID = ""; tArrival = 0; tBurst = 0; priority = 0; processColor = Color.Black; progress = 0; progressLeft = 0; }

        public int ProgressLeft
        {
            get { return progressLeft; }
            set { progressLeft = value; }
        }

        public int Progress
        {
            get { return progress; }
            set { progress = value; }
        }

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public int TArrival
        {
            get { return tArrival; }
            set { tArrival = value; }
        }
        public int TBurst
        {
            get { return tBurst; }
            set { tBurst = value; }
        }
        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }
        public Color ProcessColor
        {
            get { return processColor; }
            set { processColor = value; }
        }

        
    }
}
