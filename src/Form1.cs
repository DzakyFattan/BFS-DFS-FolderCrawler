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
        private Point startingPoint = Point.Empty;
        private Point movingPoint = Point.Empty;
        private bool isPanning = false;

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
            lokasi = loc.Text;
            pic_Result.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Start Search
            if (lokasi != null && fileName != null && searchMode != null)
            {
                picBoxWidth = pic_Result.Size.Width;
                picBoxHeight = pic_Result.Size.Height;
                pic_Result.Image = GetPicture();
            } else
            {
                if (lokasi == null)
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
                    label_searchMethod.ForeColor= Color.Red;
                }
            }
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
        }
        private void opt_BFS_CheckedChanged(object sender, EventArgs e)
        {
            searchMode = "BFS";
        }

        private void cb_FindAllDataOccurance_CheckedChanged(object sender, EventArgs e)
        {
            findAllOccurence = true;
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            loc.Text = "(Location)";
            loc.ForeColor= Color.White;
            lokasi = null;
            pic_Result.Image = null;
            tB_InputFile.Text = null;
            label_fileName.Text = null;
            label_fileName.ForeColor = Color.White;
            label_searchMethod.Text = null;
            label_searchMethod.ForeColor = Color.White;
            searchMode = null;
            cb_FindAllDataOccurance.Checked = false;
            opt_BFS.Checked = false;
            opt_DFS.Checked = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Not Implemented
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Not Implemented
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Not Implemented
        }

        private void title_Click(object sender, EventArgs e)
        {
            // Not Implemented
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Not Implemented
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loc_Click(object sender, EventArgs e)
        {
            // Not Implemented
        }

        private void pic_Result_Click(object sender, EventArgs e)
        {
            if (pic_Result.SizeMode == PictureBoxSizeMode.Zoom)
            {
                pic_Result.SizeMode = PictureBoxSizeMode.AutoSize;
            } else if (pic_Result.SizeMode == PictureBoxSizeMode.AutoSize)
            {
                pic_Result.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
