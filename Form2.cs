using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Diagnostics;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;

namespace UAS_APP
{
    public partial class Form2 : Form
    {
        private string debugFolder;
        private string excelFile;
        private string wordFileTarget;
        private string wordFileSaveAS;
        Word.Application WordApp;
        Word.Document doc;
        Excel.Application oXL;
        Excel._Workbook oWB;
        Excel._Worksheet oWS;
        Excel.Range oRng;
        Form1 frm1;
        ToolStripStatusLabel statusStrip;
        bool is_process_word = false;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // set Form 1 MDI Parent to allow get set another components
            frm1 = (Form1)this.MdiParent;
            statusStrip = frm1.toolStripStatusLabel1;

            // set debug folder
            debugFolder = Directory.GetCurrentDirectory();
            excelFile = debugFolder + @"\data_mahasiswa.xlsx";

            wordFileTarget = "";
            wordFileSaveAS = "";
            setEnableSaveas(false);
        }

        private void btn_openfile_Click(object sender, EventArgs e)
        {
            string pathFile = "";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                pathFile = OFD.FileName;
                wordFileTarget = pathFile;
                txt_word_target.Text = wordFileTarget;
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //WordApp.Quit();
            }
            catch (Exception ex)
            {
                statusStrip.Text = "Status : " + ex.Message.ToString();
                Debug.WriteLine("Status : " + ex.Message);
                // cancel exit actions
                //e.Cancel = true;
            }
        }

        private void btn_open_file_saveas_Click(object sender, EventArgs e)
        {
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                wordFileSaveAS = SFD.FileName;
                txt_saveas.Text = wordFileSaveAS;
            }
        }

        private void btn_process_excel_Click(object sender, EventArgs e)
        {
            if (wordFileTarget != "")
            {
                //prosessData();
                loadExcel(excelFile);

                if (is_process_word)
                {
                    setEnableSaveas(true);
                }
                else
                {
                    setEnableSaveas(false);
                }
            }
            else
            {
                statusStrip.Text = "Status : Error file word target didn't selected!";
                setEnableSaveas(false);
            }
        }

        private void btn_process_saveas_Click(object sender, EventArgs e)
        {
            if (wordFileSaveAS != "")
            {
                try
                {
                    doc.SaveAs2(wordFileSaveAS);
                    WordApp.Quit();
                    statusStrip.Text = "Status : File saved";
                }
                catch (Exception ex)
                {
                    statusStrip.Text = "Status : " + ex.Message;
                }
            }
            else
            {
                statusStrip.Text = "Status : Error File save location didn't set!";
            }
        }

        private void init_WordApp()
        {
            WordApp = new Word.Application();
            doc = new Word.Document();
        }

        public void loadExcel(string pathName)
        {
            // load excel file & set to datagridview
            string sheetName = "Sheet1";
            dgv.DataSource = null;
            try
            {
                string fileName = Path.GetFileNameWithoutExtension(pathName);
                System.Data.DataTable tbContainer = new System.Data.DataTable();
                string strConn = string.Empty;

                FileInfo file = new FileInfo(pathName);
                if (!file.Exists)
                {
                    MessageBox.Show("Error, file doesn't exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                string extension = file.Extension;
                switch (extension)
                {
                    case ".xls":
                        strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                        break;
                    case ".xlsx":
                        strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
                        break;
                    default:
                        strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                        break;
                }

                OleDbConnection cnnxls = new OleDbConnection(strConn);
                String query_txt = string.Format("select * from [{0}$]", sheetName);
                OleDbDataAdapter oda = new OleDbDataAdapter(query_txt, cnnxls);
                oda.Fill(tbContainer);

                dgv.DataSource = tbContainer;

                if (dgv.Rows.Count != 0)
                {
                    processDatagrid_excel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void processDatagrid_excel()
        {
            // read & write data excel from datagrid to word file

            //string fn = debugFolder + @"\testDoc.docx";
            string fn = wordFileTarget;

            if (fn != "")
            {
                init_WordApp();
                WordApp.Visible = true;
                doc = WordApp.Documents.Open(fn);
                try
                {
                    string matkul = dgv.Rows[1].Cells[1].Value.ToString();
                    string tahun = dgv.Rows[0].Cells[1].Value.ToString();

                    replaceBookmarkWord(doc, "mk_title", matkul);
                    replaceBookmarkWord(doc, "tahun_subtitle", tahun);

                    int indexWordTable = 0;
                    for (int rows = 4; rows < dgv.Rows.Count; rows++)
                    {
                        string no_table = dgv.Rows[rows].Cells[0].Value.ToString();
                        string nama_table = dgv.Rows[rows].Cells[1].Value.ToString();
                        string nim_table = dgv.Rows[rows].Cells[2].Value.ToString();
                        string jk_table = dgv.Rows[rows].Cells[3].Value.ToString();
                        string prodi_table = dgv.Rows[rows].Cells[4].Value.ToString();

                        // set data to word table
                        // +2 = setelah judul kolom
                        doc.Tables[1].Rows[indexWordTable + 2].Cells[1].Range.Text = no_table;
                        doc.Tables[1].Rows[indexWordTable + 2].Cells[2].Range.Text = nama_table;
                        doc.Tables[1].Rows[indexWordTable + 2].Cells[3].Range.Text = jk_table;
                        doc.Tables[1].Rows[indexWordTable + 2].Cells[4].Range.Text = prodi_table;

                        indexWordTable++;
                        statusStrip.Text = "Status : Process Write Data to Word";
                    }
                    statusStrip.Text = "Status : Idle";
                }
                catch (Exception ex)
                {
                    statusStrip.Text = "Status : " + ex.Message.ToString();
                }

                is_process_word = true;
            }
            else
            {
                statusStrip.Text = "Status : Error file word target didn't selected!";
            }
        }

        private void replaceBookmarkWord(Word.Document doc, string bookmarkName, String sdata)
        {
            object oBookmark = bookmarkName;
            if (sdata.Length > 0)
            {
                doc.Bookmarks.get_Item(ref oBookmark).Range.Text = sdata;
            }
        }

        private void setEnableSaveas(bool isEnable = false)
        {
            if (isEnable)
            {
                btn_process_saveas.Enabled = true;
                btn_open_file_saveas.Enabled = true;
                txt_saveas.Enabled = true;
            }
            else
            {
                btn_process_saveas.Enabled = false;
                btn_open_file_saveas.Enabled = false;
                txt_saveas.Enabled = false;
            }
        }
    }
}
