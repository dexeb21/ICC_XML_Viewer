namespace ICCXMLViewer
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getCurrentDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getLast7DayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newInstanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelUserCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelFileCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPack = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelPackCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.getLast3DayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getYesterDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Propertyv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valuev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Textv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(12, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(791, 450);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.Color.Gainsboro;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(280, 444);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Propertyv,
            this.Valuev,
            this.Textv});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 18;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(495, 444);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getCurrentDayToolStripMenuItem,
            this.getYesterDayToolStripMenuItem,
            this.getLast3DayToolStripMenuItem,
            this.getLast7DayToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.filterToolStripMenuItem.Text = "Get Tree";
            // 
            // getCurrentDayToolStripMenuItem
            // 
            this.getCurrentDayToolStripMenuItem.Name = "getCurrentDayToolStripMenuItem";
            this.getCurrentDayToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.getCurrentDayToolStripMenuItem.Text = "Get Current Day";
            this.getCurrentDayToolStripMenuItem.Click += new System.EventHandler(this.currentDayToolStripMenuItem_Click);
            // 
            // getLast7DayToolStripMenuItem
            // 
            this.getLast7DayToolStripMenuItem.Name = "getLast7DayToolStripMenuItem";
            this.getLast7DayToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.getLast7DayToolStripMenuItem.Text = "Get Last 7 Day";
            this.getLast7DayToolStripMenuItem.Click += new System.EventHandler(this.currentDayToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newInstanceToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // newInstanceToolStripMenuItem
            // 
            this.newInstanceToolStripMenuItem.Name = "newInstanceToolStripMenuItem";
            this.newInstanceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newInstanceToolStripMenuItem.Text = "New Instance";
            this.newInstanceToolStripMenuItem.Click += new System.EventHandler(this.newInstanceToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 483);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(785, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "XML File Name";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelPack,
            this.toolStripStatusLabelPackCount,
            this.toolStripStatusLabelFile,
            this.toolStripStatusLabelFileCount,
            this.toolStripStatusLabelUser,
            this.toolStripStatusLabelUserCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 506);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(815, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUser
            // 
            this.toolStripStatusLabelUser.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabelUser.Name = "toolStripStatusLabelUser";
            this.toolStripStatusLabelUser.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabelUser.Text = "User count:";
            // 
            // toolStripStatusLabelUserCount
            // 
            this.toolStripStatusLabelUserCount.Name = "toolStripStatusLabelUserCount";
            this.toolStripStatusLabelUserCount.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabelUserCount.Text = "0";
            // 
            // toolStripStatusLabelFile
            // 
            this.toolStripStatusLabelFile.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabelFile.Name = "toolStripStatusLabelFile";
            this.toolStripStatusLabelFile.Size = new System.Drawing.Size(61, 17);
            this.toolStripStatusLabelFile.Text = "File count:";
            // 
            // toolStripStatusLabelFileCount
            // 
            this.toolStripStatusLabelFileCount.Name = "toolStripStatusLabelFileCount";
            this.toolStripStatusLabelFileCount.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabelFileCount.Text = "0";
            // 
            // toolStripStatusLabelPack
            // 
            this.toolStripStatusLabelPack.Name = "toolStripStatusLabelPack";
            this.toolStripStatusLabelPack.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabelPack.Text = "Pack count:";
            // 
            // toolStripStatusLabelPackCount
            // 
            this.toolStripStatusLabelPackCount.Name = "toolStripStatusLabelPackCount";
            this.toolStripStatusLabelPackCount.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabelPackCount.Text = "0";
            // 
            // getLast3DayToolStripMenuItem
            // 
            this.getLast3DayToolStripMenuItem.Name = "getLast3DayToolStripMenuItem";
            this.getLast3DayToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.getLast3DayToolStripMenuItem.Text = "Get Last 3 Day";
            this.getLast3DayToolStripMenuItem.Click += new System.EventHandler(this.currentDayToolStripMenuItem_Click);
            // 
            // getYesterDayToolStripMenuItem
            // 
            this.getYesterDayToolStripMenuItem.Name = "getYesterDayToolStripMenuItem";
            this.getYesterDayToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.getYesterDayToolStripMenuItem.Text = "Get Yesterday";
            this.getYesterDayToolStripMenuItem.Click += new System.EventHandler(this.currentDayToolStripMenuItem_Click);
            // 
            // Propertyv
            // 
            this.Propertyv.HeaderText = "Property";
            this.Propertyv.Name = "Propertyv";
            this.Propertyv.Visible = false;
            this.Propertyv.Width = 150;
            // 
            // Valuev
            // 
            this.Valuev.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Valuev.FillWeight = 200F;
            this.Valuev.HeaderText = "Value";
            this.Valuev.Name = "Valuev";
            this.Valuev.Visible = false;
            // 
            // Textv
            // 
            this.Textv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Textv.FillWeight = 200F;
            this.Textv.HeaderText = "Text";
            this.Textv.Name = "Textv";
            this.Textv.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 528);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ICC XML Viewer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getCurrentDayToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem getLast7DayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newInstanceToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUserCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFile;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFileCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPack;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPackCount;
        private System.Windows.Forms.ToolStripMenuItem getLast3DayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getYesterDayToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propertyv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valuev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Textv;
    }
}

