namespace UAS_APP
{
    partial class Form2
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_process_excel = new System.Windows.Forms.Button();
            this.btn_open_word_target = new System.Windows.Forms.Button();
            this.txt_word_target = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_process_saveas = new System.Windows.Forms.Button();
            this.btn_open_file_saveas = new System.Windows.Forms.Button();
            this.txt_saveas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.SlateGray;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(575, 380);
            this.splitContainer1.SplitterDistance = 282;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_process_excel);
            this.groupBox2.Controls.Add(this.btn_open_word_target);
            this.groupBox2.Controls.Add(this.txt_word_target);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 380);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asal";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(3, 227);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(276, 150);
            this.dgv.TabIndex = 6;
            this.dgv.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Word Target";
            // 
            // btn_process_excel
            // 
            this.btn_process_excel.Location = new System.Drawing.Point(97, 163);
            this.btn_process_excel.Name = "btn_process_excel";
            this.btn_process_excel.Size = new System.Drawing.Size(88, 34);
            this.btn_process_excel.TabIndex = 3;
            this.btn_process_excel.Text = "Process Excel";
            this.btn_process_excel.UseVisualStyleBackColor = true;
            this.btn_process_excel.Click += new System.EventHandler(this.btn_process_excel_Click);
            // 
            // btn_open_word_target
            // 
            this.btn_open_word_target.Location = new System.Drawing.Point(185, 98);
            this.btn_open_word_target.Name = "btn_open_word_target";
            this.btn_open_word_target.Size = new System.Drawing.Size(88, 34);
            this.btn_open_word_target.TabIndex = 0;
            this.btn_open_word_target.Text = "Browse File";
            this.btn_open_word_target.UseVisualStyleBackColor = true;
            this.btn_open_word_target.Click += new System.EventHandler(this.btn_openfile_Click);
            // 
            // txt_word_target
            // 
            this.txt_word_target.Location = new System.Drawing.Point(12, 106);
            this.txt_word_target.Name = "txt_word_target";
            this.txt_word_target.ReadOnly = true;
            this.txt_word_target.Size = new System.Drawing.Size(167, 20);
            this.txt_word_target.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_process_saveas);
            this.groupBox1.Controls.Add(this.btn_open_file_saveas);
            this.groupBox1.Controls.Add(this.txt_saveas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 380);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tujuan";
            // 
            // btn_process_saveas
            // 
            this.btn_process_saveas.Location = new System.Drawing.Point(67, 194);
            this.btn_process_saveas.Name = "btn_process_saveas";
            this.btn_process_saveas.Size = new System.Drawing.Size(154, 41);
            this.btn_process_saveas.TabIndex = 6;
            this.btn_process_saveas.Text = "Process Save to Word File";
            this.btn_process_saveas.UseVisualStyleBackColor = true;
            this.btn_process_saveas.Click += new System.EventHandler(this.btn_process_saveas_Click);
            // 
            // btn_open_file_saveas
            // 
            this.btn_open_file_saveas.Location = new System.Drawing.Point(192, 90);
            this.btn_open_file_saveas.Name = "btn_open_file_saveas";
            this.btn_open_file_saveas.Size = new System.Drawing.Size(88, 34);
            this.btn_open_file_saveas.TabIndex = 5;
            this.btn_open_file_saveas.Text = "Browse File";
            this.btn_open_file_saveas.UseVisualStyleBackColor = true;
            this.btn_open_file_saveas.Click += new System.EventHandler(this.btn_open_file_saveas_Click);
            // 
            // txt_saveas
            // 
            this.txt_saveas.Location = new System.Drawing.Point(9, 98);
            this.txt_saveas.Name = "txt_saveas";
            this.txt_saveas.ReadOnly = true;
            this.txt_saveas.Size = new System.Drawing.Size(177, 20);
            this.txt_saveas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "File Word Save as";
            // 
            // OFD
            // 
            this.OFD.Filter = "Word Files | *.docx";
            // 
            // SFD
            // 
            this.SFD.Filter = "Word files |*.docx";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(575, 380);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form_List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.Button btn_open_word_target;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_word_target;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_saveas;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.Button btn_open_file_saveas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_process_excel;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btn_process_saveas;
    }
}