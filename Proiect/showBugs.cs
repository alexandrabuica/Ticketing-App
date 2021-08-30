using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Globalization;
using System.Data.OleDb;
using System.Xml;

namespace Proiect
{
    public partial class showBugs : Form
    {
        string connString;
        List<Bugs> bugsList2 = new List<Bugs>();
        User currentUser;
        public showBugs(User usr)
        {
            InitializeComponent();
            currentUser = usr;
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DataBase.accdb";
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;

                comanda.CommandText = "SELECT * FROM Bugs";

                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem itm = new ListViewItem(reader["ID"].ToString());
                    itm.SubItems.Add(reader["userID"].ToString());
                    itm.SubItems.Add(reader["summary"].ToString());
                    itm.SubItems.Add(reader["category"].ToString());
                    itm.SubItems.Add(reader["priority"].ToString());
                    itm.SubItems.Add(reader["reportDate"].ToString());
                    listView1.Items.Add(itm);
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            
            foreach (ListViewItem itm in listView1.Items)
            {
                if (itm.SubItems[4].Text == "4")
                    itm.BackColor = Color.FromArgb(255, 61, 56);
                else if (itm.SubItems[4].Text == "3")
                    itm.BackColor = Color.FromArgb(248, 135, 52);
                else if (itm.SubItems[4].Text == "2")
                    itm.BackColor = Color.FromArgb(203, 91, 222);
                else if (itm.SubItems[4].Text == "1")
                    itm.BackColor = Color.FromArgb(248, 224, 52);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Chart frm = new Chart(listView1);
            frm.Show();
        }

        private void sortButton_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem itm in listView1.Items)
            {
                if (itm.SubItems[4].Text == "4")
                    itm.BackColor = Color.FromArgb(255, 61, 56);
                else if (itm.SubItems[4].Text == "3")
                    itm.BackColor = Color.FromArgb(248, 135, 52);
                else if (itm.SubItems[4].Text == "2")
                    itm.BackColor = Color.FromArgb(203, 91, 222);
                else if (itm.SubItems[4].Text == "1")
                    itm.BackColor = Color.FromArgb(248, 224, 52);
            }

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("LoadFile.txt");
            string line = null;
            while ((line = sr.ReadLine()) != null)
            {
                try
                {
                    int id = Convert.ToInt32(line.Split('/')[0]);
                    int uID = Convert.ToInt32(line.Split('/')[1]);
                    string summary = line.Split('/')[2];
                    string category = line.Split('/')[4];
                    int priority = Convert.ToInt32(line.Split('/')[5]);
                    string date = line.Split('/')[6];
                    Bugs b = new Bugs(id, uID, summary, category, priority, date);
                    bugsList2.Add(b);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sr.Close();
            foreach (Bugs b in bugsList2)
            {
                ListViewItem itm = new ListViewItem(b.ID.ToString());
                itm.SubItems.Add(b.userID.ToString());
                itm.SubItems.Add(b.Summary);
                itm.SubItems.Add(b.Category);
                itm.SubItems.Add(b.Priority.ToString());
                itm.SubItems.Add(b.date);
                listView1.Items.Add(itm);
                
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked == true)
                    item.BackColor = Color.FromArgb(121, 255, 77);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pie frm = new Pie(listView1);
            frm.Show();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void seeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info frm = new Info(listView1, currentUser);
            frm.Show();
        }

        private void giveSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgrammerSolution frm = new ProgrammerSolution(listView1);
            frm.Show();
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked == true)
                    item.BackColor = Color.FromArgb(121, 255, 77);
            }
        }

        private void listView1_MouseUp(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked == true)
                    item.BackColor = Color.FromArgb(121, 255, 77);
            }
        }

        private void showBugs_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Size = new Size(1074, 689);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemoryStream memStream = new MemoryStream();

            XmlTextWriter writer = new XmlTextWriter(memStream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();

            writer.WriteStartElement("Content");

            foreach (ListViewItem itm in listView1.Items)
            {
                int bugID = Convert.ToInt32(itm.SubItems[0].Text);

                string summary = itm.SubItems[2].Text;

                string category = itm.SubItems[3].Text;

                int priority = Convert.ToInt32(itm.SubItems[4].Text);

                Bugs bug = new Bugs(bugID, summary, category, priority);

                writer.WriteStartElement("Bug");
                writer.WriteStartElement("BugID");
                writer.WriteValue(bug.ID);
                writer.WriteEndElement();
                writer.WriteStartElement("Summary");
                writer.WriteValue(bug.Summary);
                writer.WriteEndElement();
                writer.WriteStartElement("Category");
                writer.WriteValue(bug.Category);
                writer.WriteEndElement();
                writer.WriteStartElement("Priority");
                writer.WriteValue(bug.Priority);
                writer.WriteEndElement();
                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            writer.WriteEndDocument();

            writer.Close();

            string str = Encoding.UTF8.GetString(memStream.ToArray());
            memStream.Close();

            StreamWriter sw = new StreamWriter("fisier.xml");
            sw.WriteLine(str);
            sw.Close();
            MessageBox.Show("File saved");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            OleDbConnection conexiune = new OleDbConnection(connString);
            OleDbDataAdapter adaptor = new OleDbDataAdapter("SELECT * FROM Bugs ORDER BY category", conexiune);

            DataSet ds = new DataSet();
            adaptor.Fill(ds, "Bugs");
            DataTable table = ds.Tables["Bugs"];

            foreach (DataRow rand in table.Rows)
            {
                ListViewItem itm = new ListViewItem(rand["ID"].ToString());
                itm.SubItems.Add(rand["userID"].ToString());
                itm.SubItems.Add(rand["summary"].ToString());
                itm.SubItems.Add(rand["category"].ToString());
                itm.SubItems.Add(rand["priority"].ToString());
                itm.SubItems.Add(rand["reportDate"].ToString());
                listView1.Items.Add(itm);
            }
        }
    }
}

