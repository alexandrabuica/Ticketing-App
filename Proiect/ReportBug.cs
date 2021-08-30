using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proiect
{
    public partial class ReportBug : Form
    {
        Random rnd = new Random();
        User currentUser2;
        public ReportBug(User currentUser)
        {
            InitializeComponent();
            this.CenterToScreen();
            currentUser2 = currentUser;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DataBase.accdb");
            if (tbSummary.Text == "")
                errorProvider1.SetError(tbSummary, "Summary field cannot be empty!");
            else if (tbDescription.Text == "")
                errorProvider1.SetError(tbDescription, "Description field cannot be empty! We need more details about your problem.");
            else if (cbCategory.Text == "")
                errorProvider1.SetError(cbCategory, "Please select a category!");
            else if (rbLow.Checked == false && rbMedium.Checked == false && rbHigh.Checked == false && rbUrgent.Checked == false)
                errorProvider1.SetError(labelPriority, "Please select the priority!");
            else
            {
                try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;
                    int id = rnd.Next(99, 3000);
                    comanda.CommandText = "INSERT INTO Bugs VALUES(?,?,?,?,?,?,?,?)";
                    comanda.Parameters.Add("ID", OleDbType.Integer).Value = id;
                    comanda.Parameters.Add("userID", OleDbType.Integer).Value = currentUser2.ID;
                    comanda.Parameters.Add("summary", OleDbType.Char).Value = tbSummary.Text;
                    comanda.Parameters.Add("description", OleDbType.Char).Value = tbDescription.Text;
                    comanda.Parameters.Add("category", OleDbType.Char).Value = cbCategory.Text;
                    int priority = 0;
                    if (rbLow.Checked == true) priority = 1;
                    else if (rbMedium.Checked == true) priority = 2;
                    else if (rbHigh.Checked == true) priority = 3;
                    else if (rbUrgent.Checked == true) priority = 4;
                    comanda.Parameters.Add("priority", OleDbType.Integer).Value = priority;
                    string date = DateTime.Now.ToString("yyyy, MM, dd, HH:mm:ss tt");
                    comanda.Parameters.Add("reportDate", OleDbType.Char).Value = date;
                    int isSolved = 0;
                    comanda.Parameters.Add("solved", OleDbType.Char).Value = isSolved;
                    comanda.ExecuteNonQuery(); 
                    MessageBox.Show("Ticket sent!");
                    this.Close();
                    //lines += b.ToString();
                    //System.IO.StreamWriter file = new System.IO.StreamWriter(@".\File.txt", true); //so it dsnt overwrite
                    //file.WriteLine(lines);
                    //file.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbSummary.Clear();
                    tbDescription.Clear();
                    cbCategory.Text = "";
                    conexiune.Close();
                }
            }
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
