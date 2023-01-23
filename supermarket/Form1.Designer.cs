using System.Windows.Forms;

namespace supermarket;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.NumberOfCashRegisters = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.menu = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.N = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.M = new System.Windows.Forms.NumericUpDown();
            this.CashRegister = new System.Windows.Forms.GroupBox();
            this.NumberOfCustomersInTheQueue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.M)).BeginInit();
            this.CashRegister.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.start.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.start.Location = new System.Drawing.Point(3, 289);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(132, 64);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.stop.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stop.Location = new System.Drawing.Point(3, 359);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(132, 64);
            this.stop.TabIndex = 1;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // NumberOfCashRegisters
            // 
            this.NumberOfCashRegisters.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.NumberOfCashRegisters.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberOfCashRegisters.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NumberOfCashRegisters.Location = new System.Drawing.Point(6, 10);
            this.NumberOfCashRegisters.Name = "NumberOfCashRegisters";
            this.NumberOfCashRegisters.Size = new System.Drawing.Size(120, 50);
            this.NumberOfCashRegisters.TabIndex = 2;
            this.NumberOfCashRegisters.Text = "Number of cash registers";
            this.NumberOfCashRegisters.Click += new System.EventHandler(this.label1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.progressBar1.Location = new System.Drawing.Point(6, 41);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Maximum = 15;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(188, 22);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(26, 62);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(91, 23);
            this.numericUpDown1.TabIndex = 5;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu.ColumnCount = 1;
            this.menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.menu.Controls.Add(this.groupBox2, 0, 1);
            this.menu.Controls.Add(this.groupBox1, 0, 0);
            this.menu.Controls.Add(this.stop, 0, 3);
            this.menu.Controls.Add(this.start, 0, 2);
            this.menu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menu.Location = new System.Drawing.Point(12, 12);
            this.menu.Name = "menu";
            this.menu.RowCount = 4;
            this.menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.menu.Size = new System.Drawing.Size(138, 426);
            this.menu.TabIndex = 7;
            this.menu.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Controls.Add(this.N);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 98);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(6, 63);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(91, 23);
            this.N.TabIndex = 8;
            this.N.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of customers";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Controls.Add(this.M);
            this.groupBox1.Controls.Add(this.NumberOfCashRegisters);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 98);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // M
            // 
            this.M.Location = new System.Drawing.Point(6, 63);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(91, 23);
            this.M.TabIndex = 8;
            this.M.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // CashRegister
            // 
            this.CashRegister.BackColor = System.Drawing.SystemColors.Info;
            this.CashRegister.Controls.Add(this.NumberOfCustomersInTheQueue);
            this.CashRegister.Controls.Add(this.label2);
            this.CashRegister.Controls.Add(this.progressBar1);
            this.CashRegister.Location = new System.Drawing.Point(211, 12);
            this.CashRegister.Name = "CashRegister";
            this.CashRegister.Size = new System.Drawing.Size(200, 70);
            this.CashRegister.TabIndex = 8;
            this.CashRegister.TabStop = false;
            this.CashRegister.Text = "CashRegister";
            this.CashRegister.Visible = false;
            this.CashRegister.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // NumberOfCustomersInTheQueue
            // 
            this.NumberOfCustomersInTheQueue.Location = new System.Drawing.Point(6, 23);
            this.NumberOfCustomersInTheQueue.Name = "NumberOfCustomersInTheQueue";
            this.NumberOfCustomersInTheQueue.Size = new System.Drawing.Size(33, 15);
            this.NumberOfCustomersInTheQueue.TabIndex = 5;
            this.NumberOfCustomersInTheQueue.Text = "x";
            this.NumberOfCustomersInTheQueue.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "customers in the queue";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "X";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(473, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 39);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(56, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Customers left in the store";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.CashRegister);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.N)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.M)).EndInit();
            this.CashRegister.ResumeLayout(false);
            this.CashRegister.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private Button start;
    private Button stop;
    private Label NumberOfCashRegisters;
    private ProgressBar progressBar1;
    private NumericUpDown numericUpDown1;
    private TableLayoutPanel menu;
    private NumericUpDown M; // M- no. of cash registers
    private GroupBox groupBox2;
    private NumericUpDown N; // N- no. of customers in the queue
    private Label label1;
    private GroupBox groupBox1;
    private GroupBox CashRegister;
    private Label label2;
    private Label NumberOfCustomersInTheQueue;
    private Label label4;
    private GroupBox groupBox3;
    private Label label3;
}

/*
class cash_register
{
            this.start = new System.Windows.Forms.Button();
            this.CashRegister = new System.Windows.Forms.GroupBox();
            this.CashRegister.SuspendLayout();
    

            this.CashRegister.BackColor = System.Drawing.SystemColors.Info;
            this.CashRegister.Controls.Add(this.NumberOfCustomersInTheQueue);
            this.CashRegister.Controls.Add(this.label2);
            this.CashRegister.Controls.Add(this.progressBar1);
            this.CashRegister.Location = new System.Drawing.Point(211, 12);
            this.CashRegister.Name = "CashRegister";
            this.CashRegister.Size = new System.Drawing.Size(200, 70);
            this.CashRegister.TabIndex = 8;
            this.CashRegister.TabStop = false;
            this.CashRegister.Text = "CashRegister";
            this.CashRegister.Enter += new System.EventHandler(this.groupBox3_Enter);


    private ProgressBar progressBar1;
    private GroupBox CashRegister;
    private Label NumberOfCustomersInTheQueue;
    private Label label2;
}*/