namespace Tubes2Stima_DeathFromStima_FolderCrawler
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
            this.btn_ChooseFolder = new System.Windows.Forms.Button();
            this.label_Input = new System.Windows.Forms.Label();
            this.tB_InputFile = new System.Windows.Forms.TextBox();
            this.lbl_ChooseStartDir = new System.Windows.Forms.Label();
            this.label_InputFile = new System.Windows.Forms.Label();
            this.cb_FindAllDataOccurance = new System.Windows.Forms.CheckBox();
            this.label_MetodePencarian = new System.Windows.Forms.Label();
            this.opt_DFS = new System.Windows.Forms.RadioButton();
            this.opt_BFS = new System.Windows.Forms.RadioButton();
            this.btn_Search = new System.Windows.Forms.Button();
            this.loc = new System.Windows.Forms.Label();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.label_searchMethod = new System.Windows.Forms.Label();
            this.label_fileName = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.panel_Bar = new System.Windows.Forms.Panel();
            this.label_SearchResult = new System.Windows.Forms.Label();
            this.panel_pb = new System.Windows.Forms.Panel();
            this.pic_Result = new System.Windows.Forms.PictureBox();
            this.label_ListResult = new System.Windows.Forms.Label();
            this.label_TimeSpent = new System.Windows.Forms.Label();
            this.panel_ResultList = new System.Windows.Forms.Panel();
            this.tlp_ResultList = new System.Windows.Forms.TableLayoutPanel();
            this.panel_Menu.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            this.panel_Bar.SuspendLayout();
            this.panel_pb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Result)).BeginInit();
            this.panel_ResultList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ChooseFolder
            // 
            this.btn_ChooseFolder.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_ChooseFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChooseFolder.FlatAppearance.BorderSize = 0;
            this.btn_ChooseFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChooseFolder.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChooseFolder.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_ChooseFolder.Location = new System.Drawing.Point(48, 111);
            this.btn_ChooseFolder.Name = "btn_ChooseFolder";
            this.btn_ChooseFolder.Size = new System.Drawing.Size(144, 34);
            this.btn_ChooseFolder.TabIndex = 0;
            this.btn_ChooseFolder.Text = "Choose Folder ...";
            this.btn_ChooseFolder.UseVisualStyleBackColor = false;
            this.btn_ChooseFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Input
            // 
            this.label_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Input.AutoSize = true;
            this.label_Input.BackColor = System.Drawing.Color.Transparent;
            this.label_Input.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Input.ForeColor = System.Drawing.Color.White;
            this.label_Input.Location = new System.Drawing.Point(59, 9);
            this.label_Input.Name = "label_Input";
            this.label_Input.Size = new System.Drawing.Size(122, 58);
            this.label_Input.TabIndex = 1;
            this.label_Input.Text = "Input";
            this.label_Input.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tB_InputFile
            // 
            this.tB_InputFile.Location = new System.Drawing.Point(16, 244);
            this.tB_InputFile.Name = "tB_InputFile";
            this.tB_InputFile.Size = new System.Drawing.Size(181, 20);
            this.tB_InputFile.TabIndex = 2;
            this.tB_InputFile.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_ChooseStartDir
            // 
            this.lbl_ChooseStartDir.AutoSize = true;
            this.lbl_ChooseStartDir.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ChooseStartDir.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChooseStartDir.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_ChooseStartDir.Location = new System.Drawing.Point(12, 87);
            this.lbl_ChooseStartDir.Name = "lbl_ChooseStartDir";
            this.lbl_ChooseStartDir.Size = new System.Drawing.Size(175, 21);
            this.lbl_ChooseStartDir.TabIndex = 4;
            this.lbl_ChooseStartDir.Text = "Choose Starting Directory";
            this.lbl_ChooseStartDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_InputFile
            // 
            this.label_InputFile.AutoSize = true;
            this.label_InputFile.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InputFile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_InputFile.Location = new System.Drawing.Point(12, 220);
            this.label_InputFile.Name = "label_InputFile";
            this.label_InputFile.Size = new System.Drawing.Size(114, 21);
            this.label_InputFile.TabIndex = 5;
            this.label_InputFile.Text = "Input File Name";
            this.label_InputFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_FindAllDataOccurance
            // 
            this.cb_FindAllDataOccurance.AutoSize = true;
            this.cb_FindAllDataOccurance.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_FindAllDataOccurance.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cb_FindAllDataOccurance.Location = new System.Drawing.Point(16, 301);
            this.cb_FindAllDataOccurance.Name = "cb_FindAllDataOccurance";
            this.cb_FindAllDataOccurance.Size = new System.Drawing.Size(185, 25);
            this.cb_FindAllDataOccurance.TabIndex = 6;
            this.cb_FindAllDataOccurance.Text = "Find All Data Occurance";
            this.cb_FindAllDataOccurance.UseVisualStyleBackColor = true;
            // 
            // label_MetodePencarian
            // 
            this.label_MetodePencarian.AutoSize = true;
            this.label_MetodePencarian.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MetodePencarian.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label_MetodePencarian.Location = new System.Drawing.Point(12, 339);
            this.label_MetodePencarian.Name = "label_MetodePencarian";
            this.label_MetodePencarian.Size = new System.Drawing.Size(109, 21);
            this.label_MetodePencarian.TabIndex = 7;
            this.label_MetodePencarian.Text = "Search Method";
            // 
            // opt_DFS
            // 
            this.opt_DFS.AutoSize = true;
            this.opt_DFS.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_DFS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.opt_DFS.Location = new System.Drawing.Point(16, 363);
            this.opt_DFS.Name = "opt_DFS";
            this.opt_DFS.Size = new System.Drawing.Size(73, 35);
            this.opt_DFS.TabIndex = 8;
            this.opt_DFS.TabStop = true;
            this.opt_DFS.Text = "DFS";
            this.opt_DFS.UseVisualStyleBackColor = true;
            this.opt_DFS.CheckedChanged += new System.EventHandler(this.opt_DFS_CheckedChanged);
            // 
            // opt_BFS
            // 
            this.opt_BFS.AutoSize = true;
            this.opt_BFS.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_BFS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.opt_BFS.Location = new System.Drawing.Point(16, 404);
            this.opt_BFS.Name = "opt_BFS";
            this.opt_BFS.Size = new System.Drawing.Size(71, 35);
            this.opt_BFS.TabIndex = 9;
            this.opt_BFS.TabStop = true;
            this.opt_BFS.Text = "BFS";
            this.opt_BFS.UseVisualStyleBackColor = true;
            this.opt_BFS.CheckedChanged += new System.EventHandler(this.opt_BFS_CheckedChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Search.Location = new System.Drawing.Point(48, 489);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(144, 34);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.button2_Click);
            // 
            // loc
            // 
            this.loc.AutoSize = true;
            this.loc.BackColor = System.Drawing.Color.Transparent;
            this.loc.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loc.ForeColor = System.Drawing.Color.White;
            this.loc.Location = new System.Drawing.Point(12, 148);
            this.loc.MaximumSize = new System.Drawing.Size(220, 200);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(74, 21);
            this.loc.TabIndex = 15;
            this.loc.Text = "(Location)";
            this.loc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_Menu.Controls.Add(this.label_searchMethod);
            this.panel_Menu.Controls.Add(this.label_fileName);
            this.panel_Menu.Controls.Add(this.btn_Reset);
            this.panel_Menu.Controls.Add(this.loc);
            this.panel_Menu.Controls.Add(this.panel_Logo);
            this.panel_Menu.Controls.Add(this.tB_InputFile);
            this.panel_Menu.Controls.Add(this.cb_FindAllDataOccurance);
            this.panel_Menu.Controls.Add(this.label_MetodePencarian);
            this.panel_Menu.Controls.Add(this.opt_DFS);
            this.panel_Menu.Controls.Add(this.opt_BFS);
            this.panel_Menu.Controls.Add(this.btn_Search);
            this.panel_Menu.Controls.Add(this.lbl_ChooseStartDir);
            this.panel_Menu.Controls.Add(this.btn_ChooseFolder);
            this.panel_Menu.Controls.Add(this.label_InputFile);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(240, 681);
            this.panel_Menu.TabIndex = 16;
            // 
            // label_searchMethod
            // 
            this.label_searchMethod.AutoSize = true;
            this.label_searchMethod.BackColor = System.Drawing.Color.Transparent;
            this.label_searchMethod.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_searchMethod.ForeColor = System.Drawing.Color.Red;
            this.label_searchMethod.Location = new System.Drawing.Point(12, 442);
            this.label_searchMethod.MaximumSize = new System.Drawing.Size(220, 200);
            this.label_searchMethod.Name = "label_searchMethod";
            this.label_searchMethod.Size = new System.Drawing.Size(0, 21);
            this.label_searchMethod.TabIndex = 18;
            this.label_searchMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_fileName
            // 
            this.label_fileName.AutoSize = true;
            this.label_fileName.BackColor = System.Drawing.Color.Transparent;
            this.label_fileName.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fileName.ForeColor = System.Drawing.Color.White;
            this.label_fileName.Location = new System.Drawing.Point(12, 267);
            this.label_fileName.MaximumSize = new System.Drawing.Size(220, 200);
            this.label_fileName.Name = "label_fileName";
            this.label_fileName.Size = new System.Drawing.Size(0, 21);
            this.label_fileName.TabIndex = 17;
            this.label_fileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Reset.Location = new System.Drawing.Point(48, 553);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(144, 34);
            this.btn_Reset.TabIndex = 16;
            this.btn_Reset.Text = "Reset Input";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel_Logo.Controls.Add(this.label_Input);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(240, 75);
            this.panel_Logo.TabIndex = 0;
            // 
            // panel_Bar
            // 
            this.panel_Bar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel_Bar.Controls.Add(this.label_SearchResult);
            this.panel_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Bar.Location = new System.Drawing.Point(240, 0);
            this.panel_Bar.Name = "panel_Bar";
            this.panel_Bar.Size = new System.Drawing.Size(1024, 75);
            this.panel_Bar.TabIndex = 17;
            // 
            // label_SearchResult
            // 
            this.label_SearchResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_SearchResult.AutoSize = true;
            this.label_SearchResult.BackColor = System.Drawing.Color.Transparent;
            this.label_SearchResult.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SearchResult.ForeColor = System.Drawing.Color.White;
            this.label_SearchResult.Location = new System.Drawing.Point(393, 12);
            this.label_SearchResult.Name = "label_SearchResult";
            this.label_SearchResult.Size = new System.Drawing.Size(247, 54);
            this.label_SearchResult.TabIndex = 0;
            this.label_SearchResult.Text = "Search Result\r\n";
            this.label_SearchResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_pb
            // 
            this.panel_pb.AutoScroll = true;
            this.panel_pb.Controls.Add(this.pic_Result);
            this.panel_pb.Location = new System.Drawing.Point(240, 81);
            this.panel_pb.Name = "panel_pb";
            this.panel_pb.Size = new System.Drawing.Size(1024, 382);
            this.panel_pb.TabIndex = 18;
            // 
            // pic_Result
            // 
            this.pic_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_Result.Location = new System.Drawing.Point(0, 0);
            this.pic_Result.Name = "pic_Result";
            this.pic_Result.Size = new System.Drawing.Size(1024, 382);
            this.pic_Result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Result.TabIndex = 0;
            this.pic_Result.TabStop = false;
            this.pic_Result.Click += new System.EventHandler(this.pic_Result_Click);
            // 
            // label_ListResult
            // 
            this.label_ListResult.AutoSize = true;
            this.label_ListResult.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ListResult.ForeColor = System.Drawing.Color.Black;
            this.label_ListResult.Location = new System.Drawing.Point(247, 470);
            this.label_ListResult.Name = "label_ListResult";
            this.label_ListResult.Size = new System.Drawing.Size(0, 21);
            this.label_ListResult.TabIndex = 20;
            // 
            // label_TimeSpent
            // 
            this.label_TimeSpent.AutoSize = true;
            this.label_TimeSpent.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TimeSpent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label_TimeSpent.Location = new System.Drawing.Point(1037, 466);
            this.label_TimeSpent.Name = "label_TimeSpent";
            this.label_TimeSpent.Size = new System.Drawing.Size(0, 21);
            this.label_TimeSpent.TabIndex = 21;
            // 
            // panel_ResultList
            // 
            this.panel_ResultList.Controls.Add(this.tlp_ResultList);
            this.panel_ResultList.Location = new System.Drawing.Point(251, 506);
            this.panel_ResultList.Name = "panel_ResultList";
            this.panel_ResultList.Size = new System.Drawing.Size(1001, 163);
            this.panel_ResultList.TabIndex = 22;
            // 
            // tlp_ResultList
            // 
            this.tlp_ResultList.AutoScroll = true;
            this.tlp_ResultList.AutoSize = true;
            this.tlp_ResultList.ColumnCount = 1;
            this.tlp_ResultList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_ResultList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ResultList.Location = new System.Drawing.Point(0, 0);
            this.tlp_ResultList.Name = "tlp_ResultList";
            this.tlp_ResultList.RowCount = 1;
            this.tlp_ResultList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_ResultList.Size = new System.Drawing.Size(1001, 163);
            this.tlp_ResultList.TabIndex = 0;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel_ResultList);
            this.Controls.Add(this.label_TimeSpent);
            this.Controls.Add(this.label_ListResult);
            this.Controls.Add(this.panel_pb);
            this.Controls.Add(this.panel_Bar);
            this.Controls.Add(this.panel_Menu);
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(480, 270);
            this.Name = "Form1";
            this.Text = "Folder Crawler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            this.panel_Logo.ResumeLayout(false);
            this.panel_Logo.PerformLayout();
            this.panel_Bar.ResumeLayout(false);
            this.panel_Bar.PerformLayout();
            this.panel_pb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Result)).EndInit();
            this.panel_ResultList.ResumeLayout(false);
            this.panel_ResultList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ChooseFolder;
        private System.Windows.Forms.Label label_Input;
        private System.Windows.Forms.TextBox tB_InputFile;
        private System.Windows.Forms.Label lbl_ChooseStartDir;
        private System.Windows.Forms.Label label_InputFile;
        private System.Windows.Forms.CheckBox cb_FindAllDataOccurance;
        private System.Windows.Forms.Label label_MetodePencarian;
        private System.Windows.Forms.RadioButton opt_DFS;
        private System.Windows.Forms.RadioButton opt_BFS;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label loc;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Panel panel_Bar;
        private System.Windows.Forms.Label label_SearchResult;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label_fileName;
        private System.Windows.Forms.Label label_searchMethod;
        private System.Windows.Forms.Panel panel_pb;
        private System.Windows.Forms.PictureBox pic_Result;
        private System.Windows.Forms.Label label_ListResult;
        private System.Windows.Forms.Label label_TimeSpent;
        private System.Windows.Forms.Panel panel_ResultList;
        private System.Windows.Forms.TableLayoutPanel tlp_ResultList;
    }
}

