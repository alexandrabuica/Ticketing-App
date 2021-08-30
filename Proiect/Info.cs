using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.OleDb;

namespace Proiect
{
    public partial class Info : Form
    {
        ListView lview2;
        string connString;
        User currentUser;
        public Info(ListView lview, User usr)
        {
            InitializeComponent();
            lview2 = lview;
            this.CenterToScreen();
            currentUser = usr;
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DataBase.accdb";
        }

        private void clientInfo_Paint(object sender, PaintEventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            int spacing = 60;
            Font font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            Graphics g = e.Graphics;
            Brush br = new SolidBrush(Color.Black);
            g.DrawString("Bug details", new Font(FontFamily.GenericSansSerif, 18, FontStyle.Bold), br, new Point(40, 20));
            foreach (ListViewItem itm in lview2.Items)
            {
                if (itm.Selected)
                {
                    g.DrawString("ID: " + itm.SubItems[0].Text, font, br, new Point(40, spacing));
                    spacing += 30;
                    g.DrawString("User ID: " + itm.SubItems[1].Text, font, br, new Point(40, spacing));
                    spacing += 30;
                    g.DrawString("Summary: " + itm.SubItems[2].Text, font, br, new Point(40, spacing));
                    spacing += 30;

                    try
                    {
                        conexiune.Open();
                        OleDbCommand comanda = new OleDbCommand();
                        comanda.Connection = conexiune;
                        int id = Convert.ToInt32(itm.SubItems[1].Text);
                        comanda.CommandText = "SELECT description FROM Bugs WHERE userID=" + id;
                        OleDbDataReader reader = comanda.ExecuteReader();
                        
                            while (reader.Read())
                            {
                                g.DrawString("Description: " + reader["description"].ToString(), font, br, new Point(40, spacing));
                            }
                            reader.Close();
                            spacing += 30;
                            g.DrawString("Category: " + itm.SubItems[3].Text, font, br, new Point(40, spacing));
                            spacing += 30;
                            g.DrawString("Priority: " + itm.SubItems[4].Text, font, br, new Point(40, spacing));
                            spacing += 30;
                            g.DrawString("Date: " + itm.SubItems[5].Text, font, br, new Point(40, spacing));
                            spacing += 40;
                            g.DrawString("Solution details", new Font(FontFamily.GenericSansSerif, 18, FontStyle.Bold), br, new Point(40, spacing));
                            spacing += 40;
                            comanda.CommandText = "SELECT details FROM Solutions WHERE userID=" + id;
                            reader = comanda.ExecuteReader();
                            while (reader.Read())
                            {
                                g.DrawString("Explanation: " + reader["details"].ToString(), font, br, new Point(40, spacing));
                                spacing += 40;
                                g.DrawString("Solved: yes ", font, new SolidBrush(Color.FromArgb(80, 215, 38)), new Point(40, spacing));
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
                }
            }


        }
        private void pdPrint(object sender, PrintPageEventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            int spacing = 60;
            Font font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            Graphics g = e.Graphics;
            Brush br = new SolidBrush(Color.Black);
            g.DrawString("Bug details", new Font(FontFamily.GenericSansSerif, 18, FontStyle.Bold), br, new Point(40, 20));
            foreach (ListViewItem itm in lview2.Items)
            {
                if (itm.Selected)
                {
                    g.DrawString("ID: " + itm.SubItems[0].Text, font, br, new Point(40, spacing));
                    spacing += 30;
                    g.DrawString("User ID: " + itm.SubItems[1].Text, font, br, new Point(40, spacing));
                    spacing += 30;
                    g.DrawString("Summary: " + itm.SubItems[2].Text, font, br, new Point(40, spacing));
                    spacing += 30;
                    try
                    {
                        conexiune.Open();
                        OleDbCommand comanda = new OleDbCommand();
                        comanda.Connection = conexiune;
                        int id = Convert.ToInt32(itm.SubItems[1].Text);
                        comanda.CommandText = "SELECT description FROM Bugs WHERE userID=" + id;
                        OleDbDataReader reader = comanda.ExecuteReader();
                        
                            while (reader.Read())
                            {
                                g.DrawString("Description: " + reader["description"].ToString(), font, br, new Point(40, spacing));
                            }
                            reader.Close();
                            spacing += 30;
                            g.DrawString("Category: " + itm.SubItems[3].Text, font, br, new Point(40, spacing));
                            spacing += 30;
                            g.DrawString("Priority: " + itm.SubItems[4].Text, font, br, new Point(40, spacing));
                            spacing += 30;
                            g.DrawString("Date: " + itm.SubItems[5].Text, font, br, new Point(40, spacing));
                            spacing += 40;
                            g.DrawString("Solution details", new Font(FontFamily.GenericSansSerif, 18, FontStyle.Bold), br, new Point(40, spacing));
                            spacing += 40;
                            comanda.CommandText = "SELECT details FROM Solutions WHERE userID=" + id;
                            reader = comanda.ExecuteReader();
                            while (reader.Read())
                            {
                                g.DrawString("Explanation: " + reader["details"].ToString(), font, br, new Point(40, spacing));
                                spacing += 40;
                                g.DrawString("Solved: yes ", font, new SolidBrush(Color.FromArgb(80, 215, 38)), new Point(40, spacing));
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
                }
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            int spacing = 60;
            Font font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
            Graphics g = e.Graphics;
            Brush br = new SolidBrush(Color.Black);
            g.DrawString("Bug details", new Font(FontFamily.GenericSansSerif, 18, FontStyle.Bold), br, new Point(40, 20));
            foreach (ListViewItem itm in lview2.Items)
            {
                if (itm.Selected)
                {
                    g.DrawString("ID: " + itm.SubItems[0].Text, font, br, new Point(40, spacing));
                    spacing += 30;
                    g.DrawString("User ID: " + itm.SubItems[1].Text, font, br, new Point(40, spacing));
                    spacing += 30;
                    g.DrawString("Summary: " + itm.SubItems[2].Text, font, br, new Point(40, spacing));
                    spacing += 30;
                    try
                    {
                        conexiune.Open();
                        OleDbCommand comanda = new OleDbCommand();
                        comanda.Connection = conexiune;
                        int id = Convert.ToInt32(itm.SubItems[1].Text);
                        comanda.CommandText = "SELECT description FROM Bugs WHERE userID=" + id+" AND NOT solved=1";
                        OleDbDataReader reader = comanda.ExecuteReader();
                        
                        while (reader.Read())
                        {
                            g.DrawString("Description: " + reader["description"].ToString(), font, br, new Point(40, spacing));
                        }
                        reader.Close();
                        spacing += 30;
                        g.DrawString("Category: " + itm.SubItems[3].Text, font, br, new Point(40, spacing));
                        spacing += 30;
                        g.DrawString("Priority: " + itm.SubItems[4].Text, font, br, new Point(40, spacing));
                        spacing += 30;
                        g.DrawString("Date: " + itm.SubItems[5].Text, font, br, new Point(40, spacing));
                        spacing += 40;
                        g.DrawString("Solution details", new Font(FontFamily.GenericSansSerif, 18, FontStyle.Bold), br, new Point(40, spacing));
                        spacing += 40;
                        comanda.CommandText = "SELECT details FROM Solutions WHERE userID=" + id;
                        reader = comanda.ExecuteReader();

                        while (reader.Read())
                        {
                            g.DrawString("Explanation: " + reader["details"].ToString(), font, br, new Point(40, spacing));
                            spacing += 40;
                            g.DrawString("Solved: yes ", font, new SolidBrush(Color.FromArgb(80, 215, 38)), new Point(40, spacing));
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
                }
            }
            
        }

        private void printReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pdPrint);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }
    }
}
