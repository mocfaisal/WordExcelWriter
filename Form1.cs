using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UAS_APP
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 ff = new Form2();
            // set form2 MDI parent to Form1
            ff.MdiParent = this;
            ff.Dock = DockStyle.Fill;
            ff.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Created by Mochammad Faisal", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

    }

}
