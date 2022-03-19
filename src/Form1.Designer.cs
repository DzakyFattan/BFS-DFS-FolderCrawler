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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_ChooseStartDir = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DFSButton = new System.Windows.Forms.RadioButton();
            this.BFSButton = new System.Windows.Forms.RadioButton();
            this.btn_Search = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loc = new System.Windows.Forms.Label();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.panel_Bar = new System.Windows.Forms.Panel();
            this.label_SearchResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Menu.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            this.panel_Bar.SuspendLayout();
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
            this.label_Input.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.lbl_ChooseStartDir.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(13, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Input File Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox1.Location = new System.Drawing.Point(16, 279);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(185, 25);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Find All Data Occurance";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Metode Pencarian";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DFSButton
            // 
            this.DFSButton.AutoSize = true;
            this.DFSButton.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DFSButton.ForeColor = System.Drawing.Color.Snow;
            this.DFSButton.Location = new System.Drawing.Point(14, 363);
            this.DFSButton.Name = "DFSButton";
            this.DFSButton.Size = new System.Drawing.Size(73, 35);
            this.DFSButton.TabIndex = 8;
            this.DFSButton.TabStop = true;
            this.DFSButton.Text = "DFS";
            this.DFSButton.UseVisualStyleBackColor = true;
            // 
            // BFSButton
            // 
            this.BFSButton.AutoSize = true;
            this.BFSButton.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFSButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BFSButton.Location = new System.Drawing.Point(14, 404);
            this.BFSButton.Name = "BFSButton";
            this.BFSButton.Size = new System.Drawing.Size(71, 35);
            this.BFSButton.TabIndex = 9;
            this.BFSButton.TabStop = true;
            this.BFSButton.Text = "BFS";
            this.BFSButton.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Search.Location = new System.Drawing.Point(48, 462);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(144, 34);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(292, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(937, 569);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // loc
            // 
            this.loc.AutoSize = true;
            this.loc.BackColor = System.Drawing.Color.Transparent;
            this.loc.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loc.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.loc.Location = new System.Drawing.Point(12, 158);
            this.loc.MaximumSize = new System.Drawing.Size(220, 200);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(66, 21);
            this.loc.TabIndex = 15;
            this.loc.Text = "Location";
            this.loc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loc.Click += new System.EventHandler(this.loc_Click);
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_Menu.Controls.Add(this.loc);
            this.panel_Menu.Controls.Add(this.panel_Logo);
            this.panel_Menu.Controls.Add(this.textBox1);
            this.panel_Menu.Controls.Add(this.checkBox1);
            this.panel_Menu.Controls.Add(this.label4);
            this.panel_Menu.Controls.Add(this.DFSButton);
            this.panel_Menu.Controls.Add(this.BFSButton);
            this.panel_Menu.Controls.Add(this.btn_Search);
            this.panel_Menu.Controls.Add(this.lbl_ChooseStartDir);
            this.panel_Menu.Controls.Add(this.btn_ChooseFolder);
            this.panel_Menu.Controls.Add(this.label2);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(240, 681);
            this.panel_Menu.TabIndex = 16;
            this.panel_Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
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
            this.label_SearchResult.Click += new System.EventHandler(this.title_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel_Bar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_Menu);
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(480, 270);
            this.Name = "Form1";
            this.Text = "Folder Crawler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            this.panel_Logo.ResumeLayout(false);
            this.panel_Logo.PerformLayout();
            this.panel_Bar.ResumeLayout(false);
            this.panel_Bar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ChooseFolder;
        private System.Windows.Forms.Label label_Input;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_ChooseStartDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton DFSButton;
        private System.Windows.Forms.RadioButton BFSButton;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label loc;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Panel panel_Bar;
        private System.Windows.Forms.Label label_SearchResult;
    }
}

