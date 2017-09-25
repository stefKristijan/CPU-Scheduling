namespace CPU_scheduling
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbFCFS = new System.Windows.Forms.RadioButton();
            this.rbSJF = new System.Windows.Forms.RadioButton();
            this.rbSRTN = new System.Windows.Forms.RadioButton();
            this.rbRR = new System.Windows.Forms.RadioButton();
            this.rbPS = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddRnd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbTQ = new System.Windows.Forms.ComboBox();
            this.dgvProcesses = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvTimeline = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDone = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvProgress = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesses)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeline)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDone)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgress)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // rbFCFS
            // 
            this.rbFCFS.AutoSize = true;
            this.rbFCFS.BackColor = System.Drawing.Color.DodgerBlue;
            this.rbFCFS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbFCFS.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbFCFS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbFCFS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.rbFCFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbFCFS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFCFS.ForeColor = System.Drawing.Color.White;
            this.rbFCFS.Location = new System.Drawing.Point(0, 0);
            this.rbFCFS.Name = "rbFCFS";
            this.rbFCFS.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.rbFCFS.Size = new System.Drawing.Size(246, 28);
            this.rbFCFS.TabIndex = 0;
            this.rbFCFS.Text = "First come, first served (FCFS)";
            this.rbFCFS.UseVisualStyleBackColor = false;
            this.rbFCFS.CheckedChanged += new System.EventHandler(this.rbFCFS_CheckedChanged);
            // 
            // rbSJF
            // 
            this.rbSJF.AutoSize = true;
            this.rbSJF.BackColor = System.Drawing.Color.DodgerBlue;
            this.rbSJF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbSJF.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbSJF.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbSJF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.rbSJF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbSJF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSJF.ForeColor = System.Drawing.Color.White;
            this.rbSJF.Location = new System.Drawing.Point(0, 28);
            this.rbSJF.Name = "rbSJF";
            this.rbSJF.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.rbSJF.Size = new System.Drawing.Size(246, 28);
            this.rbSJF.TabIndex = 1;
            this.rbSJF.Text = "Shortest job first (SJF)\r\n";
            this.rbSJF.UseVisualStyleBackColor = false;
            this.rbSJF.CheckedChanged += new System.EventHandler(this.rbSJF_CheckedChanged);
            // 
            // rbSRTN
            // 
            this.rbSRTN.AutoSize = true;
            this.rbSRTN.BackColor = System.Drawing.Color.DodgerBlue;
            this.rbSRTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbSRTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbSRTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbSRTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.rbSRTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbSRTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSRTN.ForeColor = System.Drawing.Color.White;
            this.rbSRTN.Location = new System.Drawing.Point(0, 56);
            this.rbSRTN.Name = "rbSRTN";
            this.rbSRTN.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.rbSRTN.Size = new System.Drawing.Size(246, 28);
            this.rbSRTN.TabIndex = 2;
            this.rbSRTN.Text = "Shortest RemainingTime Next (SRTN)";
            this.rbSRTN.UseVisualStyleBackColor = false;
            this.rbSRTN.CheckedChanged += new System.EventHandler(this.rbSRTN_CheckedChanged);
            // 
            // rbRR
            // 
            this.rbRR.AutoSize = true;
            this.rbRR.BackColor = System.Drawing.Color.DodgerBlue;
            this.rbRR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbRR.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbRR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbRR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.rbRR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbRR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRR.ForeColor = System.Drawing.Color.White;
            this.rbRR.Location = new System.Drawing.Point(0, 84);
            this.rbRR.Name = "rbRR";
            this.rbRR.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.rbRR.Size = new System.Drawing.Size(246, 28);
            this.rbRR.TabIndex = 3;
            this.rbRR.Text = "Round Robin (RR)";
            this.rbRR.UseVisualStyleBackColor = false;
            this.rbRR.CheckedChanged += new System.EventHandler(this.rbRR_CheckedChanged);
            // 
            // rbPS
            // 
            this.rbPS.AutoSize = true;
            this.rbPS.BackColor = System.Drawing.Color.DodgerBlue;
            this.rbPS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbPS.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbPS.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rbPS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.rbPS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbPS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPS.ForeColor = System.Drawing.Color.White;
            this.rbPS.Location = new System.Drawing.Point(0, 112);
            this.rbPS.Name = "rbPS";
            this.rbPS.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.rbPS.Size = new System.Drawing.Size(246, 28);
            this.rbPS.TabIndex = 4;
            this.rbPS.Text = "Priority scheduling (PS)";
            this.rbPS.UseVisualStyleBackColor = false;
            this.rbPS.CheckedChanged += new System.EventHandler(this.rbPS_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 161);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(246, 43);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Dodaj proces";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddRnd
            // 
            this.btnAddRnd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddRnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddRnd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddRnd.Enabled = false;
            this.btnAddRnd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddRnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddRnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRnd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRnd.ForeColor = System.Drawing.Color.White;
            this.btnAddRnd.Location = new System.Drawing.Point(0, 204);
            this.btnAddRnd.Name = "btnAddRnd";
            this.btnAddRnd.Size = new System.Drawing.Size(246, 43);
            this.btnAddRnd.TabIndex = 4;
            this.btnAddRnd.Text = "Dodaj random proces";
            this.btnAddRnd.UseVisualStyleBackColor = false;
            this.btnAddRnd.Click += new System.EventHandler(this.btnAddRnd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnAddRnd);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.cbTQ);
            this.panel1.Controls.Add(this.rbPS);
            this.panel1.Controls.Add(this.rbRR);
            this.panel1.Controls.Add(this.rbSRTN);
            this.panel1.Controls.Add(this.rbSJF);
            this.panel1.Controls.Add(this.rbFCFS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 327);
            this.panel1.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(164, 247);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(82, 80);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(82, 247);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(82, 80);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(0, 247);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(82, 80);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbTQ
            // 
            this.cbTQ.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbTQ.Enabled = false;
            this.cbTQ.FormattingEnabled = true;
            this.cbTQ.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbTQ.Location = new System.Drawing.Point(0, 140);
            this.cbTQ.Name = "cbTQ";
            this.cbTQ.Size = new System.Drawing.Size(246, 21);
            this.cbTQ.TabIndex = 10;
            this.cbTQ.Text = "Kvant";
            this.cbTQ.SelectedIndexChanged += new System.EventHandler(this.cbTQ_SelectedIndexChanged);
            // 
            // dgvProcesses
            // 
            this.dgvProcesses.AllowUserToAddRows = false;
            this.dgvProcesses.AllowUserToDeleteRows = false;
            this.dgvProcesses.AllowUserToOrderColumns = true;
            this.dgvProcesses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProcesses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProcesses.BackgroundColor = System.Drawing.Color.White;
            this.dgvProcesses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProcesses.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcesses.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProcesses.Location = new System.Drawing.Point(0, 27);
            this.dgvProcesses.MultiSelect = false;
            this.dgvProcesses.Name = "dgvProcesses";
            this.dgvProcesses.ReadOnly = true;
            this.dgvProcesses.RowHeadersVisible = false;
            this.dgvProcesses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProcesses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProcesses.Size = new System.Drawing.Size(261, 161);
            this.dgvProcesses.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTimeline);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(246, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 139);
            this.panel2.TabIndex = 1;
            // 
            // dgvTimeline
            // 
            this.dgvTimeline.AllowUserToAddRows = false;
            this.dgvTimeline.AllowUserToDeleteRows = false;
            this.dgvTimeline.AllowUserToOrderColumns = true;
            this.dgvTimeline.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTimeline.BackgroundColor = System.Drawing.Color.White;
            this.dgvTimeline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeline.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTimeline.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTimeline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimeline.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTimeline.Location = new System.Drawing.Point(0, 27);
            this.dgvTimeline.MultiSelect = false;
            this.dgvTimeline.Name = "dgvTimeline";
            this.dgvTimeline.ReadOnly = true;
            this.dgvTimeline.RowHeadersVisible = false;
            this.dgvTimeline.RowTemplate.Height = 100;
            this.dgvTimeline.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvTimeline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTimeline.Size = new System.Drawing.Size(664, 112);
            this.dgvTimeline.TabIndex = 8;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel11.Controls.Add(this.label4);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(664, 27);
            this.panel11.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(265, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Izvođenje procesa u vremenu";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDone);
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(710, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 188);
            this.panel3.TabIndex = 2;
            // 
            // dgvDone
            // 
            this.dgvDone.AllowUserToAddRows = false;
            this.dgvDone.AllowUserToDeleteRows = false;
            this.dgvDone.AllowUserToOrderColumns = true;
            this.dgvDone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDone.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDone.BackgroundColor = System.Drawing.Color.White;
            this.dgvDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDone.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDone.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDone.Location = new System.Drawing.Point(0, 27);
            this.dgvDone.MultiSelect = false;
            this.dgvDone.Name = "dgvDone";
            this.dgvDone.ReadOnly = true;
            this.dgvDone.RowHeadersVisible = false;
            this.dgvDone.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDone.Size = new System.Drawing.Size(200, 161);
            this.dgvDone.TabIndex = 10;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel10.Controls.Add(this.label3);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 27);
            this.panel10.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Gotovi procesi";
            // 
            // dgvProgress
            // 
            this.dgvProgress.AllowUserToAddRows = false;
            this.dgvProgress.AllowUserToDeleteRows = false;
            this.dgvProgress.AllowUserToOrderColumns = true;
            this.dgvProgress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProgress.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProgress.BackgroundColor = System.Drawing.Color.White;
            this.dgvProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProgress.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProgress.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProgress.Location = new System.Drawing.Point(0, 27);
            this.dgvProgress.MultiSelect = false;
            this.dgvProgress.Name = "dgvProgress";
            this.dgvProgress.ReadOnly = true;
            this.dgvProgress.RowHeadersVisible = false;
            this.dgvProgress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProgress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProgress.Size = new System.Drawing.Size(203, 161);
            this.dgvProgress.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvProgress);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(507, 61);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(203, 188);
            this.panel4.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel9.Controls.Add(this.label2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(203, 27);
            this.panel9.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Procesi u izvođenju i čekanju";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dgvProcesses);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(246, 61);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(261, 188);
            this.panel7.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel8.Controls.Add(this.label1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(261, 27);
            this.panel8.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Svi procesi";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Controls.Add(this.pbClose);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(910, 61);
            this.panel6.TabIndex = 8;
            // 
            // pbClose
            // 
            this.pbClose.BackgroundImage = global::CPU_scheduling.Properties.Resources.close_1;
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbClose.Location = new System.Drawing.Point(865, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(33, 27);
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            this.pbClose.MouseEnter += new System.EventHandler(this.pbClose_MouseEnter);
            this.pbClose.MouseLeave += new System.EventHandler(this.pbClose_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(910, 388);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesses)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeline)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDone)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgress)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFCFS;
        private System.Windows.Forms.RadioButton rbSJF;
        private System.Windows.Forms.RadioButton rbSRTN;
        private System.Windows.Forms.RadioButton rbRR;
        private System.Windows.Forms.RadioButton rbPS;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddRnd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dgvProcesses;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTimeline;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvProgress;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.DataGridView dgvDone;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbTQ;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pbClose;
    }
}

