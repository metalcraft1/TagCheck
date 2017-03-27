namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LoadMaster_Button = new System.Windows.Forms.Button();
            this.LoadPredator_Button = new System.Windows.Forms.Button();
            this.LoadTid_Button = new System.Windows.Forms.Button();
            this.OrderNumber_TextBox = new System.Windows.Forms.TextBox();
            this.EPCLength_TextBox = new System.Windows.Forms.TextBox();
            this.TIDLength_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Offline_CheckBox = new System.Windows.Forms.CheckBox();
            this.Import_CheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FileName_ListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EpcCount_TextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadMaster_Button
            // 
            this.LoadMaster_Button.Location = new System.Drawing.Point(362, 88);
            this.LoadMaster_Button.Margin = new System.Windows.Forms.Padding(2);
            this.LoadMaster_Button.Name = "LoadMaster_Button";
            this.LoadMaster_Button.Size = new System.Drawing.Size(102, 33);
            this.LoadMaster_Button.TabIndex = 0;
            this.LoadMaster_Button.Text = "Load Master";
            this.LoadMaster_Button.UseVisualStyleBackColor = true;
            this.LoadMaster_Button.Click += new System.EventHandler(this.LoadMaster_Button_Click);
            // 
            // LoadPredator_Button
            // 
            this.LoadPredator_Button.Location = new System.Drawing.Point(362, 153);
            this.LoadPredator_Button.Margin = new System.Windows.Forms.Padding(2);
            this.LoadPredator_Button.Name = "LoadPredator_Button";
            this.LoadPredator_Button.Size = new System.Drawing.Size(102, 28);
            this.LoadPredator_Button.TabIndex = 1;
            this.LoadPredator_Button.Text = "Load Predator";
            this.LoadPredator_Button.UseVisualStyleBackColor = true;
            this.LoadPredator_Button.Click += new System.EventHandler(this.LoadPredator_Button_Click);
            // 
            // LoadTid_Button
            // 
            this.LoadTid_Button.Location = new System.Drawing.Point(362, 212);
            this.LoadTid_Button.Margin = new System.Windows.Forms.Padding(2);
            this.LoadTid_Button.Name = "LoadTid_Button";
            this.LoadTid_Button.Size = new System.Drawing.Size(102, 30);
            this.LoadTid_Button.TabIndex = 2;
            this.LoadTid_Button.Text = "Load Read/Write";
            this.LoadTid_Button.UseVisualStyleBackColor = true;
            this.LoadTid_Button.Click += new System.EventHandler(this.LoadTid_Button_Click);
            // 
            // OrderNumber_TextBox
            // 
            this.OrderNumber_TextBox.Location = new System.Drawing.Point(172, 24);
            this.OrderNumber_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.OrderNumber_TextBox.Name = "OrderNumber_TextBox";
            this.OrderNumber_TextBox.Size = new System.Drawing.Size(264, 20);
            this.OrderNumber_TextBox.TabIndex = 3;
            this.OrderNumber_TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EPCLength_TextBox
            // 
            this.EPCLength_TextBox.Location = new System.Drawing.Point(95, 272);
            this.EPCLength_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EPCLength_TextBox.Name = "EPCLength_TextBox";
            this.EPCLength_TextBox.Size = new System.Drawing.Size(26, 20);
            this.EPCLength_TextBox.TabIndex = 4;
            this.EPCLength_TextBox.TextChanged += new System.EventHandler(this.EPCLengthTextBox_TextChanged);
            // 
            // TIDLength_TextBox
            // 
            this.TIDLength_TextBox.Location = new System.Drawing.Point(95, 297);
            this.TIDLength_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TIDLength_TextBox.Name = "TIDLength_TextBox";
            this.TIDLength_TextBox.Size = new System.Drawing.Size(26, 20);
            this.TIDLength_TextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Master File Loaded";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Load Master Here";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Load Read/Write Here";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Predator Loaded";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 275);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Max Epc Length:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 300);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Max Tid Length:";
            // 
            // Reset_Button
            // 
            this.Reset_Button.BackColor = System.Drawing.Color.ForestGreen;
            this.Reset_Button.Location = new System.Drawing.Point(496, 21);
            this.Reset_Button.Margin = new System.Windows.Forms.Padding(2);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(66, 25);
            this.Reset_Button.TabIndex = 15;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = false;
            // 
            // Offline_CheckBox
            // 
            this.Offline_CheckBox.AutoSize = true;
            this.Offline_CheckBox.Location = new System.Drawing.Point(14, 29);
            this.Offline_CheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.Offline_CheckBox.Name = "Offline_CheckBox";
            this.Offline_CheckBox.Size = new System.Drawing.Size(56, 17);
            this.Offline_CheckBox.TabIndex = 16;
            this.Offline_CheckBox.Text = "Offline";
            this.Offline_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Import_CheckBox
            // 
            this.Import_CheckBox.AutoSize = true;
            this.Import_CheckBox.Location = new System.Drawing.Point(380, 247);
            this.Import_CheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.Import_CheckBox.Name = "Import_CheckBox";
            this.Import_CheckBox.Size = new System.Drawing.Size(135, 17);
            this.Import_CheckBox.TabIndex = 17;
            this.Import_CheckBox.Text = "Import Previous Project";
            this.Import_CheckBox.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(493, 160);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Load Predator Here";
            // 
            // FileName_ListBox
            // 
            this.FileName_ListBox.FormattingEnabled = true;
            this.FileName_ListBox.Location = new System.Drawing.Point(8, 96);
            this.FileName_ListBox.Margin = new System.Windows.Forms.Padding(2);
            this.FileName_ListBox.Name = "FileName_ListBox";
            this.FileName_ListBox.Size = new System.Drawing.Size(113, 160);
            this.FileName_ListBox.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(172, 88);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 184);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(304, 297);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 79);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "List of Loaded Files";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Order Number:";
            // 
            // EpcCount_TextBox
            // 
            this.EpcCount_TextBox.Location = new System.Drawing.Point(95, 322);
            this.EpcCount_TextBox.Name = "EpcCount_TextBox";
            this.EpcCount_TextBox.Size = new System.Drawing.Size(26, 20);
            this.EpcCount_TextBox.TabIndex = 24;
            this.EpcCount_TextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "EPC Count:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(729, 371);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EpcCount_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FileName_ListBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Import_CheckBox);
            this.Controls.Add(this.Offline_CheckBox);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TIDLength_TextBox);
            this.Controls.Add(this.EPCLength_TextBox);
            this.Controls.Add(this.OrderNumber_TextBox);
            this.Controls.Add(this.LoadTid_Button);
            this.Controls.Add(this.LoadPredator_Button);
            this.Controls.Add(this.LoadMaster_Button);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Tag Checker Gen2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void EPCLengthTextBox_TextChanged(object sender, System.EventArgs e)
        {
           
        }

        private void TIDLengthTextBox_TextChanged(object sender, System.EventArgs e)
        {

        }

      
   

        private System.Windows.Forms.Button LoadMaster_Button;
        private System.Windows.Forms.Button LoadPredator_Button;
        private System.Windows.Forms.Button LoadTid_Button;
        private System.Windows.Forms.TextBox OrderNumber_TextBox;
        private System.Windows.Forms.TextBox EPCLength_TextBox;
        private System.Windows.Forms.TextBox TIDLength_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.CheckBox Offline_CheckBox;
        private System.Windows.Forms.CheckBox Import_CheckBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox FileName_ListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        #endregion
        private System.Windows.Forms.TextBox EpcCount_TextBox;
        private System.Windows.Forms.Label label8;

    }
}

