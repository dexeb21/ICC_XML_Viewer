using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;

namespace ICCXMLViewer
{
    public partial class Form1 : Form
    {
        string DefPatch;
        public Form1()
        {
            InitializeComponent();
            DefPatch = @"\\10.44.60.102\ABBYYExportDocs$\";
        }
        ////////////////////////////////////////////////////////////////////////////////////
        private void currentDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ASD = ((ToolStripMenuItem)sender).Name;
            int start_delta = 0;
            int stop_delta = 0;
            switch (((ToolStripMenuItem)sender).Name)
            {
                case "getCurrentDayToolStripMenuItem":
                    start_delta = 0;
                    stop_delta = 0;
                    break;
                case "getLast7DayToolStripMenuItem":
                    start_delta = 0;
                    stop_delta = 7;
                    break;
                case "getLast3DayToolStripMenuItem":
                    start_delta = 0;
                    stop_delta = 3;
                    break;
                case "getYesterDayToolStripMenuItem":
                    start_delta = 1;
                    stop_delta = 1;
                    break;
            }
            DirectoryInfo dir = new DirectoryInfo(DefPatch);
            treeView1.Nodes.Clear();

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException("The directory does not exist.");
            }
            FileSystemInfo[] infos = dir.GetFileSystemInfos();

            DateTime CurrDate = DateTime.Now;
            TreeNode TN = new TreeNode();
            TreeNode[] TNs;
            int user_count = 0;
            int file_count = 0;
            int pack_count = 0;
            
            
            foreach (FileSystemInfo fsi in infos)
            {
                //if (fsi.CreationTime.DayOfYear == CurrDate.DayOfYear-1 & fsi.Name.Contains(".xml"))
                if (fsi.CreationTime.DayOfYear <= CurrDate.DayOfYear - start_delta & fsi.CreationTime.DayOfYear >= CurrDate.DayOfYear - stop_delta & fsi.Name.Contains(".xml"))
                {
                    XDocument myDoc = XDocument.Load(DefPatch + fsi.Name);
                    XElement FF = myDoc.Descendants("_ScanOperator").First();
                    TNs = treeView1.Nodes.Find(FF.Value, false);
                    if (TNs.Length == 0)
                    {
                        TN = treeView1.Nodes.Add(FF.Value, FF.Value);
                        pack_count = pack_count + DefaultTreeGroup(TN, fsi.Name);
                        user_count++;
                        file_count++;
                    }
                    else
                    {
                        pack_count = pack_count + DefaultTreeGroup(TNs[0], fsi.Name);
                        file_count++;
                    }
                }
            }
            toolStripStatusLabelUserCount.Text = user_count.ToString();
            toolStripStatusLabelPackCount.Text = pack_count.ToString();
            toolStripStatusLabelFileCount.Text = file_count.ToString();
            treeView1.Sort();
        }
        ////////////////////////////////////////////////////////////////////////////////////
        private int DefaultTreeGroup(TreeNode TN, string FileName)
        {
            TreeNode[] TNs;            
            string[] s = FileName.Split('_');
            int ret = 0;
            {                
                TNs = treeView1.Nodes.Find(s[0], true);
                if (TNs.Length == 0)
                {
                    TN = TN.Nodes.Add(s[0], s[0]);
                    TN.Nodes.Add(s[3].Split('.')[0],s[3].Split('.')[0] + "_" + s[2] + "_" + s[1]); // Идусский код рулит!
                    ret = 1;
                }
                else
                {
                    TNs[0].Nodes.Add(s[3].Split('.')[0], s[3].Split('.')[0] + "_" + s[2] + "_" + s[1]); // Идусский код рулит!
                    ret = 0;
                }
            }
            return ret;
        }

        ////////////////////////////////////////////////////////////////////////////////////
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string[] s = e.Node.Text.Split('_');
            dataGridView1.Rows.Clear();
            textBox1.Text = "XML File Name";
            switch (e.Node.Level)
            {
                case 0:
                    PersonAllPackagesToGrid(e.Node);
                    break;
                case 1:
                    AllDocumFromPackageToGrid(e.Node);
                    break;
                case 2:
                    string filename = e.Node.Parent.Text + "_" + s[2] + "_" + s[1] + "_" + s[0] + ".xml";
                    XMLDataToGrid(filename);
                    break;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////
        private void PersonAllPackagesToGrid(TreeNode Node)
        {
            dataGridView1.Columns.Clear();

            dataGridView1.ColumnCount = 3;
            dataGridView1.ColumnHeadersVisible = true;

            dataGridView1.Columns[0].Name = "GUID";
            dataGridView1.Columns[0].Width = 225;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].Name = "IDPack";
            dataGridView1.Columns[1].Width = 225;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].Name = "BatchType";
            dataGridView1.Columns[2].Width = 225;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            int ind = 0;
            foreach (TreeNode child in Node.Nodes)
            {
                string[] row = { child.Text,"Comming Son", "Comming Son"};                
                if (child.Nodes.Count > 0)
                {
                    string[] s = child.Nodes[0].Text.Split('_');
                    string filename = child.Nodes[0].Parent.Text + "_" + s[2] + "_" + s[1] + "_" + s[0] + ".xml";
                    XDocument myDoc = XDocument.Load(DefPatch + filename);
                    IEnumerable<XElement> FF1;
                    IEnumerable<XElement> FF2;

                    try
                    {
                        FF1 = myDoc.Descendants("_IDPack");
                        FF2 = myDoc.Descendants("_BatchType");
                        row[1] = "";
                        row[2] = "";

                        if (FF1.Count() > 0)
                        {
                            row[1] = FF1.First().Value;
                        }
                        if (FF2.Count() > 0)
                        {
                            row[2] = FF2.First().Value;
                        }
                        ind = dataGridView1.Rows.Add(row);                        
                    }
                    catch { }
                }
                dataGridView1.Rows[ind].Cells[0].Style.BackColor = Color.Gainsboro;
                dataGridView1.Rows[ind].Cells[1].Style.BackColor = Color.Gainsboro;
                dataGridView1.Rows[ind].Cells[2].Style.BackColor = Color.Gainsboro;
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////
        private void AllDocumFromPackageToGrid(TreeNode Node)
        {
            dataGridView1.Columns.Clear();

            dataGridView1.ColumnCount = 5;
            dataGridView1.ColumnHeadersVisible = true;

            dataGridView1.Columns[0].Name = "N";
            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[1].Name = "Header";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Name = "Number";
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.Columns[3].Name = "Date";
            dataGridView1.Columns[3].Width = 75;
            dataGridView1.Columns[4].Name = "Barcode";
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].FillWeight = 125;


            int ind = 0;
            string filename = "";
            string[] row = new string[5];
            foreach (TreeNode child in Node.Nodes)
            {
                string[] s = child.Text.Split('_');
                filename = child.Parent.Text + "_" + s[2] + "_" + s[1] + "_" + s[0] + ".xml";

                XDocument myDoc = XDocument.Load(DefPatch + filename);
                IEnumerable<XElement> FF1;
                IEnumerable<XElement> FF2;
                IEnumerable<XElement> FF3;
                IEnumerable<XElement> FF4;
                try
                {
                    FF1 = myDoc.Descendants("_Header");
                    FF2 = myDoc.Descendants("_DocNum");
                    FF3 = myDoc.Descendants("_DateDoc");
                    FF4 = myDoc.Descendants("_Barcode");
                    row[0] = s[0];
                    row[1] = "";
                    row[2] = "";
                    row[3] = "";
                    row[4] = "";

                    if (FF1.Count() > 0)
                    {
                        row[1] = FF1.First().Value;
                    }
                    if (FF2.Count() > 0)
                    {
                        row[2] = FF2.First().Value;
                    }
                    if (FF3.Count() > 0)
                    {
                        row[3] = FF3.First().Value;
                    }
                    if (FF4.Count() > 0)
                    {
                        row[4] = FF4.First().Value;
                    }

                    ind = dataGridView1.Rows.Add(row);

                    dataGridView1.Rows[ind].Cells[0].Style.BackColor = Color.Gainsboro;
                    dataGridView1.Rows[ind].Cells[1].Style.BackColor = Color.Gainsboro;
                    dataGridView1.Rows[ind].Cells[2].Style.BackColor = Color.Gainsboro;
                    dataGridView1.Rows[ind].Cells[3].Style.BackColor = Color.Gainsboro;
                    dataGridView1.Rows[ind].Cells[4].Style.BackColor = Color.Gainsboro;

                }
                catch
                {
                }
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////
        private void XMLDataToGrid(string filename)
        {
            try
            {
                dataGridView1.Columns.Clear();

                dataGridView1.ColumnCount = 3;
                dataGridView1.ColumnHeadersVisible = true;

                dataGridView1.Columns[0].Name = "Property";
                dataGridView1.Columns[0].Width = 150;
                dataGridView1.Columns[1].Name = "Value";
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].FillWeight = 200;
                dataGridView1.Columns[2].Name = "Text";
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[2].FillWeight = 200;                
                string Txt = "";

                XDocument myDoc = XDocument.Load(DefPatch + filename);
                textBox1.Text = filename;
                IEnumerable<XElement> root = myDoc.Root.Descendants("FcField");
                foreach (XElement el in root)
                {
                    XElement FF = el.Elements().First();
                    try
                    {
                        XAttribute Atr = FF.Attribute("Text");
                        Txt = Atr.Value;
                    }
                    catch
                    {
                        Txt = "";
                    }
                    string[] row = { FF.Name.LocalName, FF.Value, Txt };
                    int ind = dataGridView1.Rows.Add(row);

                    DataGridViewCellStyle Style = new DataGridViewCellStyle();

                    switch (FF.Name.LocalName)
                    {
                        case "_DocNum":
                            Style.BackColor = Color.DarkSeaGreen;
                            break;
                        case "_Barcode":
                            Style.BackColor = Color.DarkKhaki;
                            break;
                        case "_ScanOperator":
                            Style.BackColor = Color.DarkSalmon;
                            break;
                        case "_IDPack":
                            Style.BackColor = Color.Beige;
                            break;
                        default:
                            Style.BackColor = Color.Gainsboro;
                            break;
                    }

                    dataGridView1.Rows[ind].Cells[0].Style = Style;
                    dataGridView1.Rows[ind].Cells[1].Style = Style;
                    dataGridView1.Rows[ind].Cells[2].Style = Style;
                }
            }
            catch
            {
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////
        private void newInstanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 NewWindows = new Form1();
            NewWindows.Text = "Search results";
            NewWindows.menuStrip1.Visible = false;
            NewWindows.Show();
        }
        ////////////////////////////////////////////////////////////////////////////////////
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            TreeNode[] TN = treeView1.SelectedNode.Nodes.Find(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), true);
            if (TN.Length > 0)
            {
                treeView1.SelectedNode = TN[0];
                treeView1.SelectedNode.Expand();
            }
        }
        ////////////////////////////////////////////////////////////////////////////////////
        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                treeView1.SelectedNode.Collapse();
                if (treeView1.SelectedNode.Parent != null)
                {
                    treeView1.SelectedNode = treeView1.SelectedNode.Parent;
                }
            }
        }
    }
}
