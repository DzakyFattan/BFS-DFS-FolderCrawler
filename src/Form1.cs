using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void cb_FindAllDataOccurance_CheckedChanged(object sender, EventArgs e)
        {
            findAllOccurence = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Start Search
            if (rootFolder != null && fileName != null && searchMode != null)
            {
                int ms = DateTime.Now.Millisecond;
                picBoxWidth = pic_Result.Size.Width;
                picBoxHeight = pic_Result.Size.Height;
                pic_Result.Image = GetResult();
                if (pic_Result.Image != null)
                {
                    label_ListResult.ForeColor = Color.Black;
                    label_ListResult.Text = "Hasil Pencarian";
                    listBox_Result.Visible = true;
                    ms = DateTime.Now.Millisecond - ms;
                    label_TimeSpent.Text = "Time Spent: " + ms.ToString() + " ms";
                } else
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
            opt_BFS.Checked = false;
            opt_DFS.Checked = false;
            listBox_Result.Visible = false;
            label_ListResult.Text = null;
            label_ListResult.ForeColor = Color.Black;
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
    }
}