using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_scheduling
{
    public partial class AddProcess : Form
    {
        public string id { get; set; }
        public int tArrival { get; set; }
        public int tBurst { get; set; }
        public int Priority { get; set; }
        public Color c { get; set; }
      

        public AddProcess(bool flag)
        {
            InitializeComponent();
            tbPriority.Visible = flag;
            label4.Visible = flag;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                c = colorDialog1.Color;
                panel1.BackColor = c;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int arrival = 0, burst = 0, priority = 0;
            id = tbId.Text;
            if (Int32.TryParse(tbArrivalT.Text, out arrival) || tbArrivalT.Text == "")
            {
                if (arrival > 100) MessageBox.Show("Maksimalno vrijeme pojavljivanja je 100!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else tArrival = arrival;
            }
            else {
                MessageBox.Show("U kućicu možete unijeti isključivo broj!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbArrivalT.Text = "";
            }
            if (Int32.TryParse(tbBurstT.Text, out burst) || tbBurstT.Text == "")
            {
                if (burst > 100) MessageBox.Show("Maksimalno vrijeme trajanja je 100!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else tBurst = burst;
            }
            else {
                MessageBox.Show("U kućicu možete unijeti isključivo broj!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbBurstT.Text = "";
            }
            if (Int32.TryParse(tbPriority.Text, out priority) || tbPriority.Text=="")
            {
                if (priority > 10) MessageBox.Show("Maksimalan prioritet je 10!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (tbPriority.Text == "") priority = 0;
                else Priority = priority;
            }
            else {
                MessageBox.Show("U kućicu možete unijeti isključivo broj!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPriority.Text = "";
            }
        }

        private void AddProcess_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
