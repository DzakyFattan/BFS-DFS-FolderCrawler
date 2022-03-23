using System;
using System.Drawing;
using System.Windows.Forms;
using static Tubes2Stima_DeathFromStima_FolderCrawler.Handler;
namespace Tubes2Stima_DeathFromStima_FolderCrawler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Not Implemented
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Choose Folder
            loc.Text = GetLocation();
            loc.ForeColor = Color.White;
            rootFolder = loc.Text;
            pic_Result.Image = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fileName = tB_InputFile.Text;
            label_fileName.Text = fileName;
            label_fileName.ForeColor = Color.White;
        }
        private void opt_DFS_CheckedChanged(object sender, EventArgs e)
        {
            searchMode = "DFS";
            label_searchMethod.Text = null;
        }
        private void opt_BFS_CheckedChanged(object sender, EventArgs e)
        {
            searchMode = "BFS";
            label_searchMethod.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // clear previous result
            arrResultPath = null;
            // Start Search
            if (rootFolder != null && fileName != null && searchMode != null)
            {
                int ms = DateTime.Now.Millisecond;
                picBoxWidth = pic_Result.Size.Width;
                picBoxHeight = pic_Result.Size.Height;

                if(searchMode == "DFS")
                {
                    (pic_Result.Image,arrResultPath) = GetResultDFS(cb_FindAllDataOccurance.Checked);
                } 
                else if (searchMode == "BFS")
                {
                    (pic_Result.Image,arrResultPath) = GetResultBFS(cb_FindAllDataOccurance.Checked);
                } 
                else { pic_Result.Image = null; }

                ms = DateTime.Now.Millisecond - ms;
                if (ms < 0)
                {
                    ms = 0;
                }
                label_TimeSpent.Text = "Time Spent: " + ms.ToString() + " ms";

                if (pic_Result.Image != null)
                {
                    label_ListResult.ForeColor = Color.Black;
                    label_ListResult.Text = "Hasil Pencarian";
                    if (arrResultPath != null)
                    {
                        ClearResultList();
                        foreach (string path in arrResultPath)
                        {
                            LinkLabel lbl = new LinkLabel();
                            lbl.Text = $@"{path}";
                            lbl.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular);
                            lbl.Size = new System.Drawing.Size(700, 21);
                            lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resultLink_LinkClicked);
                            Console.WriteLine(lbl.Text);
                            tlp_ResultList.Visible = true;
                            tlp_ResultList.Controls.Add(lbl);
                        }
                    }
                    else
                    {
                        Label errormsg = new Label();
                        errormsg.Text = "File tidak ditemukan";
                        errormsg.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular);
                        errormsg.Size = new System.Drawing.Size(200, 20);
                        errormsg.ForeColor = Color.Red;
                        errormsg.BackColor = this.BackColor;
                        tlp_ResultList.Visible = true;
                        tlp_ResultList.Controls.Add(errormsg);
                    }
                } 
                else
                {
                    label_ListResult.Text = "Error";
                    label_ListResult.ForeColor = Color.Red;
                }
                

            }
            else
            {
                if (rootFolder == null)
                {
                    loc.Text = "tidak ada input";
                    loc.ForeColor = Color.Red;
                }
                if (fileName == null)
                {
                    label_fileName.Text = "tidak ada input";
                    label_fileName.ForeColor = Color.Red;
                }
                if (searchMode == null)
                {
                    label_searchMethod.Text = "Pilih salah satu!";
                    label_searchMethod.ForeColor = Color.Red;
                }
            }
        }

        private void resultLink_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel linkLabel = sender as LinkLabel;
            int index = linkLabel.Text.LastIndexOf("\\");
            string openFolder = linkLabel.Text.Substring(0, index);
            Console.WriteLine(openFolder);
            System.Diagnostics.Process.Start($@"{openFolder}");
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            loc.Text = "(Location)";
            loc.ForeColor = Color.White;
            rootFolder = null;
            pic_Result.Image = null;
            tB_InputFile.Text = null;
            label_fileName.Text = null;
            label_fileName.ForeColor = Color.White;
            label_searchMethod.Text = null;
            searchMode = null;
            cb_FindAllDataOccurance.Checked = false;
            findAllOccurence = false;
            opt_BFS.Checked = false;
            opt_DFS.Checked = false;
            label_ListResult.Text = null;
            label_ListResult.ForeColor = Color.Black;
            label_TimeSpent.Text = null;
            for (int i = tlp_ResultList.Controls.Count - 1; i >= 0; --i)
                tlp_ResultList.Controls[i].Dispose();

            tlp_ResultList.Controls.Clear();
            tlp_ResultList.RowCount = 0;
            tlp_ResultList.Visible = false;
        }

        private void ClearResultList()
        {
            if (tlp_ResultList.Controls.Count > 0)
            {
                for (int i = tlp_ResultList.Controls.Count - 1; i >= 0; --i)
                    tlp_ResultList.Controls[i].Dispose();

                tlp_ResultList.Controls.Clear();
                tlp_ResultList.RowCount = 0;
            }
        }

        private void pic_Result_Click(object sender, EventArgs e)
        {
            if (pic_Result.SizeMode == PictureBoxSizeMode.Zoom)
            {
                pic_Result.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            else if (pic_Result.SizeMode == PictureBoxSizeMode.AutoSize)
            {
                pic_Result.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void cb_FindAllDataOccurance_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}