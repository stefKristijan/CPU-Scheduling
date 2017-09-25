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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<cProcess> processList = new List<cProcess>();
        List<cProcess> readyProcessList = new List<cProcess>();
        List<cProcess> tempProcessList = new List<cProcess>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbPS.Checked)
            {
                using (AddProcess fAdd = new AddProcess(true))
                {
                    if (fAdd.ShowDialog() == DialogResult.OK)
                    {
                        cProcess proc = new cProcess(fAdd.id, fAdd.tArrival, fAdd.tBurst, fAdd.Priority, fAdd.c);
                        if(processList.Count==0) setDataGridView(proc.Priority);
                        createDataGridViewRow(proc);
                        processList.Add(proc);
                        cProcess proc2 = new cProcess(fAdd.id, fAdd.tArrival, fAdd.tBurst, fAdd.Priority, fAdd.c);
                        tempProcessList.Add(proc2);
                    }

                }
            }
            else
            using (AddProcess fAdd = new AddProcess(false))
            {
                    if (fAdd.ShowDialog() == DialogResult.OK)
                    {
                        cProcess proc = new cProcess(fAdd.id, fAdd.tArrival, fAdd.tBurst, fAdd.Priority, fAdd.c);
                        if (processList.Count == 0)  setDataGridView(proc.Priority);
                        createDataGridViewRow(proc);
                        processList.Add(proc);
                        cProcess proc2 = new cProcess(fAdd.id, fAdd.tArrival, fAdd.tBurst, fAdd.Priority, fAdd.c);
                        tempProcessList.Add(proc2);
                    }
            }
        }

        private void createDataGridViewRow(cProcess proc)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewTextBoxCell { Value = proc.ID });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = proc.TArrival.ToString() });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = proc.TBurst.ToString() });
            if (dgvProcesses.ColumnCount == 5)
            {
                row.Cells.Add(new DataGridViewTextBoxCell { Value = proc.Priority.ToString() });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = "" });
                row.Cells[4].Style.BackColor = proc.ProcessColor;
            }
            else
            {
                row.Cells.Add(new DataGridViewTextBoxCell { Value = "" });
                row.Cells[3].Style.BackColor = proc.ProcessColor;
            }

            dgvProcesses.Rows.Add(row);

        }

        private void setDataGridView(int priority)
        {
            dgvProcesses.Rows.Clear();
            dgvProcesses.ColumnCount = 4;
            dgvProcesses.Columns[0].Name = "ID procesa";
            dgvProcesses.Columns[1].Name = "Vrijeme pojavljivanja";
            dgvProcesses.Columns[2].Name = "Vrijeme trajanja";
            dgvProcesses.Columns[3].Name = "Boja";
            if (priority != 0)
            {
                dgvProcesses.ColumnCount = 5;
                dgvProcesses.Columns[3].Name = "Prioritet";
                dgvProcesses.Columns[4].Name = "Boja";
            }
            dgvProcesses.ClearSelection();
        }

        private void btnAddRnd_Click(object sender, EventArgs e)
        {
            cProcess proc = new cProcess();

            Random randomGen = new Random();
            proc.ProcessColor = Color.FromArgb(randomGen.Next(0,255),randomGen.Next(0,255),randomGen.Next(0,255));
            proc.ID = "Pr" + dgvProcesses.Rows.Count;
            proc.TArrival = randomGen.Next(0, 30);
            proc.TBurst = randomGen.Next(1, 20);
            proc.ProgressLeft = proc.TBurst;
            if (rbRR.Checked || rbPS.Checked)
            {
                proc.Priority = randomGen.Next(1, 10);
            }

            if (dgvProcesses.ColumnCount < 4) setDataGridView(proc.Priority);
            createDataGridViewRow(proc);

            processList.Add(proc);
            cProcess proc2 = new cProcess(proc.ID, proc.TArrival, proc.TBurst, proc.Priority, proc.ProcessColor);
            proc2.ProgressLeft = proc2.TBurst;
            tempProcessList.Add(proc2);
        }

        private void rbFCFS_CheckedChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnAddRnd.Enabled = true;
            if (rbFCFS.Checked) cbTQ.Enabled = false;
        }

        private void rbSJF_CheckedChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnAddRnd.Enabled = true;
            if (rbSJF.Checked) cbTQ.Enabled = false;
        }

        private void rbSRTN_CheckedChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnAddRnd.Enabled = true;
            if (rbSRTN.Checked) cbTQ.Enabled = false;
        }

        private void rbRR_CheckedChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnAddRnd.Enabled = true;
            cbTQ.Enabled = true;
        }

        private void rbPS_CheckedChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnAddRnd.Enabled = true;
            cbTQ.Enabled = true;
        }

        int i = 0;
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rbFCFS.Checked) FCFSAlgorithm();
            else if (rbSJF.Checked) SJFAlgorithm();
            else if (rbSRTN.Checked) SRTNAlgorithm();
            else if (rbRR.Checked) RoundRobinAlgorithm();
            else if (rbPS.Checked) PrioritySchedulingAlgorithm();
        }

        cProcess executing;
        int quant = 0;

        private void PrioritySchedulingAlgorithm()
        {
            updateReadyProcessList();
            if (readyProcessList.Count != 0)
            {
                readyProcessList = readyProcessList.OrderBy(o => o.Priority).ToList();
                dgvProgress.Rows.Clear();
                setProgressDGViews(dgvProgress);
                foreach (cProcess pr in readyProcessList)
                {
                    createRow(dgvProgress, pr);
                }
                if (i == 0)
                {
                    executing = readyProcessList[0];
                    quant++;
                    firstTime("PS");
                }
                else if (quant % Convert.ToInt32(cbTQ.SelectedItem) != 0 && quant != 0 || quant == 0)
                {
                    if (executing == null) executing = readyProcessList[0];
                    quant++;
                }
                else if (quant % Convert.ToInt32(cbTQ.SelectedItem) == 0 && quant != 0)
                {
                    quant = 0;
                    if (readyProcessList.Count > 1 )
                    {
                        readyProcessList.Add(executing);
                        readyProcessList.RemoveAt(0);
                        dgvProgress.Rows.Clear();
                        setProgressDGViews(dgvProgress);
                        readyProcessList = readyProcessList.OrderBy(o => o.Priority).ToList();
                        foreach (cProcess pr in readyProcessList)
                        {
                            createRow(dgvProgress, pr);
                        }
                        executing = readyProcessList[0];
                    }
                    quant++;
                }
            }
            else if (i == 0)
            {
                setProgressDGViews(dgvProgress);
                firstTime("PS");
            }
            if (executing == null && i > 0)
            {
                addNewCell("(" + i.ToString() + "-" + (i + 1).ToString() + ")" + "s", Color.Black);
            }
            else if (executing != null && i > 0)
            {
                addNewCell(executing.ID + "\n\n\n\n\n" + "(" + i.ToString() + "-" + (i + 1).ToString() + ")" + "s", executing.ProcessColor);

                executing.Progress++; executing.ProgressLeft--;
                dgvProgress.Rows[0].Cells[1].Value = Math.Round(1.0 * executing.Progress / executing.TBurst * 100, 4).ToString() + "%";

                processDone("PS");
            }
            i++;
            if (dgvDone.Rows.Count == dgvProcesses.Rows.Count) timer1.Stop();
            dgvTimeline.ClearSelection();
        }


        private void RoundRobinAlgorithm()
        {
            updateReadyProcessList();
            if (readyProcessList.Count != 0)
            {
                dgvProgress.Rows.Clear();
                setProgressDGViews(dgvProgress);
                foreach(cProcess pr in readyProcessList)
                {
                    createRow(dgvProgress, pr);
                }
                if (i == 0)
                {
                    executing = readyProcessList[0];
                    quant++;
                    firstTime("RR");
                }
                else if (quant % Convert.ToInt32(cbTQ.SelectedItem) != 0  && quant!=0 || quant==0)
                {
                    if (executing == null) executing = readyProcessList[0];
                    quant++;
                }
                else if (quant % Convert.ToInt32(cbTQ.SelectedItem) == 0 && quant != 0)
                {
                    quant = 0;
                    readyProcessList.Add(executing);
                    readyProcessList.RemoveAt(0);
                    dgvProgress.Rows.Clear();
                    setProgressDGViews(dgvProgress);
                    foreach (cProcess pr in readyProcessList)
                    {
                        createRow(dgvProgress, pr);
                    }
                    executing = readyProcessList[0];
                    quant++;
                }
            }
            else if (i == 0)
            {
                setProgressDGViews(dgvProgress);
                firstTime("SRTN");
            }
            if (executing == null && i > 0)
            {
                addNewCell("("+i.ToString()+"-"+(i+1).ToString()+")" + "s", Color.Black);
            }
            else if (executing != null && i > 0)
            {
                addNewCell(executing.ID + "\n\n\n\n\n" + "(" + i.ToString() + "-" + (i + 1).ToString() + ")" + "s", executing.ProcessColor);

                executing.Progress++; executing.ProgressLeft--;
                dgvProgress.Rows[0].Cells[1].Value = Math.Round(1.0 * executing.Progress / executing.TBurst * 100, 4).ToString() + "%";

                processDone("RR");
            }
            i++;
            if (dgvDone.Rows.Count == dgvProcesses.Rows.Count) timer1.Stop();
            dgvTimeline.ClearSelection();
        }

        private void SRTNAlgorithm()
        {
            updateReadyProcessList();
            if (readyProcessList.Count != 0)
            {
                readyProcessList = readyProcessList.OrderBy(o => o.ProgressLeft).ToList();
                dgvProgress.Rows.Clear();
                setProgressDGViews(dgvProgress);
                foreach (cProcess pr in readyProcessList)
                {
                    createRow(dgvProgress, pr);
                }
                executing = readyProcessList[0];
              
                if (i == 0) firstTime("SRTN");
                else processDone("SRTN");
            }
            else if (i == 0) firstTime("SRTN");
            if (executing == null && i > 0)
            {
                addNewCell("(" + i.ToString() + "-" + (i + 1).ToString() + ")" + "s", Color.Black);
            }
            else if (executing != null && i>0)
            {
                addNewCell(executing.ID + "\n\n\n\n\n" + "(" + i.ToString() + "-" + (i + 1).ToString() + ")" + "s", executing.ProcessColor);

                executing.Progress++; executing.ProgressLeft--;
                dgvProgress.Rows[0].Cells[1].Value = Math.Round(1.0 * executing.Progress / executing.TBurst * 100, 4).ToString() + "%";

                processDone("SRTN");
            }
            i++;
            if (executing != null) readyProcessList[0] = executing;
            if (dgvDone.Rows.Count == dgvProcesses.Rows.Count) timer1.Stop();
            dgvTimeline.ClearSelection();
        }
        
        private void SJFAlgorithm()
        {
            updateReadyProcessList();
            if (readyProcessList.Count != 0)
            {
                readyProcessList = readyProcessList.OrderBy(o => o.TBurst).ToList();
                dgvProgress.Rows.Clear();
                setProgressDGViews(dgvProgress);
                if (executing != null) createRow(dgvProgress, executing);
                foreach (cProcess pr in readyProcessList)
                {
                    createRow(dgvProgress, pr);
                }
                if (executing == null)
                {
                    executing = readyProcessList[0];
                    readyProcessList.RemoveAt(0);

                }
                if (i == 0) firstTime("SJF");
                else processDone("SJF");
            }
            else if (i == 0) firstTime("SJF"); 
            if (executing==null && i > 0)
            {
                addNewCell("(" + i.ToString() + "-" + (i + 1).ToString() + ")" + "s", Color.Black);
                
            }
            else if (executing != null && i>0 )
            {
                addNewCell(executing.ID + "\n\n\n\n\n" + "(" + i.ToString() + "-" + (i + 1).ToString() + ")" + "s", executing.ProcessColor);
               
                executing.Progress++;
                dgvProgress.Rows[0].Cells[1].Value = Math.Round(1.0 * executing.Progress / executing.TBurst * 100, 4).ToString() + "%";

                processDone("SJF");
            }
            i++;
            if (dgvDone.Rows.Count == dgvProcesses.Rows.Count) timer1.Stop();
            dgvTimeline.ClearSelection();
        }

        private void FCFSAlgorithm()
        {
            foreach (cProcess pr in processList)
            {
                if (i == pr.TArrival)
                {
                    readyProcessList.Add(pr);
                    setProgressDGViews(dgvProgress);

                    createRow(dgvProgress, pr);
                }
            }
            if (i == 0)
            {
                if(readyProcessList.Count!=0) executing = readyProcessList[0];
                firstTime("FCFS");
            }
            else if (readyProcessList.Count == 0 && i > 0)
            {
                addNewCell("(" + i.ToString() + "-" + (i + 1).ToString() + ")" + "s", Color.Black);
            }
            else if (readyProcessList.Count != 0)
            {
                executing=readyProcessList[0]; 
                addNewCell(executing.ID + "\n\n\n\n\n" + "(" + i.ToString() + "-" + (i + 1).ToString() + ")" + "s", executing.ProcessColor);

                executing.Progress++;
                dgvProgress.Rows[0].Cells[1].Value = Math.Round(1.0 * executing.Progress / executing.TBurst*100, 4).ToString() + "%";

                processDone("FCFS");
            }
            i++;
            if (dgvDone.Rows.Count==dgvProcesses.Rows.Count) timer1.Stop();
            dgvTimeline.ClearSelection();
        }

        private void updateReadyProcessList()
        {
            foreach (cProcess pr in processList)
            {
                if (i == pr.TArrival)
                {
                    readyProcessList.Add(pr);
                }
            }
        }

        private void firstTime(string algorithm)
        {
            DataGridViewRow row = new DataGridViewRow();
            dgvTimeline.ColumnCount = 1;
            if (executing==null) row.Cells.Add(new DataGridViewTextBoxCell { Value = "(" + i.ToString() + "-" + (i + 1).ToString() + ")" + "s" });
            else {
                row.Cells.Add(new DataGridViewTextBoxCell { Value = executing.ID + "\n\n\n\n\n" + "(" + i.ToString() + "-" + (i + 1).ToString() + ")" + "s" });
                row.Cells[0].Style.BackColor = executing.ProcessColor;
                executing.Progress++; executing.ProgressLeft--;
                dgvProgress.Rows[0].Cells[1].Value = Math.Round(1.0 * executing.Progress / executing.TBurst * 100, 4).ToString() + "%";
                processDone(algorithm);
            }
            row.Height = 100;
            dgvTimeline.Rows.Add(row);
            dgvTimeline.Columns[0].Width = 35;
        }

        private void processDone(string algorithm)
        {
            if (executing.Progress == executing.TBurst)
            {
                dgvProgress.Rows.Clear();
                setProgressDGViews(dgvDone);
                createRow(dgvDone, executing);
                if (algorithm == "FCFS")
                {
                    readyProcessList.RemoveAt(0);
                    if (readyProcessList.Count > 0) executing = readyProcessList[0];
                    foreach (cProcess pr in readyProcessList)
                    {
                        createRow(dgvProgress, pr);
                    }
                }
                else if (algorithm == "RR")
                {
                    readyProcessList.RemoveAt(0);
                    quant = 0;
                    executing = null;
                    foreach (cProcess pr in readyProcessList)
                    {
                        createRow(dgvProgress, pr);
                    }
                }
                else if( algorithm == "PS")
                {
                    readyProcessList.RemoveAt(0);
                    quant = 0;
                    executing = null;
                    readyProcessList = readyProcessList.OrderBy(o => o.Priority).ToList();
                    foreach (cProcess pr in readyProcessList)
                    {
                        createRow(dgvProgress, pr);
                    }
                }
                else if (algorithm == "SJF")
                {
                    executing = null;
                    foreach (cProcess pr in readyProcessList)
                    {
                        createRow(dgvProgress, pr);
                    }
                }
                else if (algorithm == "SRTN")
                {
                    readyProcessList.RemoveAt(0);
                    readyProcessList = readyProcessList.OrderBy(o => o.ProgressLeft).ToList();
                    executing = null;
                    foreach (cProcess pr in readyProcessList)
                    {
                        createRow(dgvProgress, pr);
                    }
                }
            }
        }

        private void addNewCell(string val, Color color)
        {
            dgvTimeline.ColumnCount++;
            if (color == Color.White) dgvTimeline.ForeColor = Color.Black;
            else dgvTimeline.ForeColor = Color.White;
            DataGridViewTextBoxCell tbCell = new DataGridViewTextBoxCell();
            tbCell.Value = val;
            dgvTimeline.Rows[0].Cells[i] = tbCell;
            dgvTimeline.Rows[0].Cells[i].Style.BackColor = color;
            dgvTimeline.Columns[i].Width = 35;
        }

        private void setProgressDGViews(DataGridView dgv)
        {
            dgv.ColumnCount = 2;
            dgv.Columns[0].Name = "ID procesa";
            dgv.Columns[1].Name = "Napredak";
        }

        private void createRow(DataGridView dgv, cProcess pr)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewTextBoxCell { Value = pr.ID });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = Math.Round(1.0*pr.Progress/pr.TBurst*100, 4).ToString() + "%" });
            dgv.Rows.Add(row);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnStart.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            rbFCFS.Enabled = false;
            rbPS.Enabled = false;
            rbRR.Enabled = false;
            rbSJF.Enabled = false;
            rbSRTN.Enabled = false;
            btnAdd.Enabled = false;
            btnAddRnd.Enabled = false;
            btnStart.Enabled = false;
        }

        private void cbTQ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            processList.Clear();
            executing = null;
            foreach(cProcess pr in tempProcessList) {
                pr.Progress = 0;
                processList.Add(pr);
            }
            readyProcessList.Clear();
            dgvDone.Columns.Clear();
            dgvProgress.Columns.Clear();
            setProgressDGViews(dgvProgress);
            dgvTimeline.Columns.Clear();
            btnStart.Enabled = true;
            i = 0;
            rbFCFS.Enabled = true;
            rbPS.Enabled = true;
            rbRR.Enabled = true;
            rbSJF.Enabled = true;
            rbSRTN.Enabled = true;
           // Application.Restart();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.BackgroundImage = Properties.Resources.close_2;
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.BackgroundImage = Properties.Resources.close_1;
        }
    }
}
