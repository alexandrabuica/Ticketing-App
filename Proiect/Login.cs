using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Proiect
{
    public partial class Login : Form
    {
        string connString;
        User currentUser;
        Programmer currentProgr;
        public Login()
        {
            InitializeComponent();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DataBase.accdb";
        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            loginPanel.Dock = mainPanelUser.Dock = DockStyle.Fill;
            loginPanel.Parent = mainPanelUser.Parent = mainPanelDev.Parent = this;
            loginPanel.Visible = true;
            mainPanelUser.Visible = false;
            mainPanelDev.Visible = false;
            listBox2.Items.Add("C++/C");
            listBox2.Items.Add("Java");
            listBox2.Items.Add("React");
            listBox2.Items.Add("HTML/CSS");
            listBox2.Items.Add("Python");
            listBox2.Items.Add("PHP");
            listBox2.Items.Add("SQL");
            listBox2.Items.Add("Swift");
            listBox2.Items.Add("Ruby");
            listBox2.Items.Add("Bash/Shell/Powershell");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "")
                errorProvider1.SetError(tbUser, "Enter username!");
            else if (tbPass.Text == "")
                errorProvider1.SetError(tbPass, "Enter password!");
            else if (rbDev.Checked == false && rbUser.Checked == false)
                errorProvider1.SetError(button1, "Select your status (USER/DEVELOPER)");
            else
            {
                try
                {
                        if (rbUser.Checked == true)
                        {
                            currentUser = User.Login(connString, tbUser.Text, tbPass.Text);
                            if (currentUser.ID!=0)
                            {
                                MessageBox.Show("Welcome! Logged in as user.");
                                mainPanelUser.BringToFront();
                                mainPanelUser.Visible = true;
                                labelUsername.Text = currentUser.Username;
                                nameLabel.Text = currentUser.Name;
                                phoneLabel.Text = currentUser.Telephone;
                            try
                            {
                                OleDbConnection conexiune = new OleDbConnection(connString);
                                conexiune.Open();
                                OleDbCommand comanda = new OleDbCommand();
                                comanda.Connection = conexiune;
                                comanda.CommandText = "SELECT COUNT(ID) FROM Bugs WHERE userID=" + currentUser.ID;
                                int nrReported = (int)comanda.ExecuteScalar();
                                numberbugsLabel.Text = nrReported.ToString();

                                comanda.CommandText = "SELECT COUNT(ID) FROM Bugs WHERE userID=" + currentUser.ID + "AND solved=1";
                                int nrSolved = (int)comanda.ExecuteScalar();
                                labelbugsSolved.Text = nrSolved.ToString();
                                conexiune.Close();
                            }
                            catch
                            {
                                numberbugsLabel.Text = "0";
                                labelbugsSolved.Text = "0";
                            }
                            }
                            else
                            {
                                MessageBox.Show("User or password incorrect! --- Do you have an account?");
                                tbPass.Clear();
                            }
                        }

                        if (rbDev.Checked == true)
                        {
                        currentProgr = Programmer.Login(connString, tbUser.Text, tbPass.Text);
                        if (currentProgr.ID != 0)
                        {
                                MessageBox.Show("Welcome! Logged in as developer.");
                                mainPanelDev.BringToFront();
                                mainPanelDev.Visible = true;
                                progUsr.Text = currentProgr.Username;
                                progName.Text = currentProgr.Name;
                                progPhone.Text = currentProgr.Telephone;
                            try
                            {
                                OleDbConnection conexiune = new OleDbConnection(connString);
                                conexiune.Open();
                                OleDbCommand comanda = new OleDbCommand();
                                comanda.Connection = conexiune;
                                comanda.CommandText = "SELECT COUNT(ID) FROM Bugs WHERE userID=" + currentProgr.ID + "AND solved=1";
                                int nrSolved = (int)comanda.ExecuteScalar();
                                progRes.Text = nrSolved.ToString();
                                conexiune.Close();
                            }
                            catch
                            {
                                progRes.Text = "0";
                            }
                        }
                        else
                            {
                                MessageBox.Show("User or password incorrect! --- Do you have an account?");
                                tbPass.Clear();
                            }
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
            }
        }

        private void bugButton_Click(object sender, EventArgs e)
        {
            ReportBug frm = new ReportBug(currentUser);
            frm.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            loginPanel.BringToFront();
            mainPanelUser.SendToBack();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loginPanel.BringToFront();
            mainPanelDev.SendToBack();
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount frm = new CreateAccount();
            frm.Show();
        }
       

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginPanel.SendToBack();
            mainPanelUser.Visible = true;
            mainPanelUser.BringToFront();
        }

        private void goBackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainPanelUser.SendToBack();
            loginPanel.Visible = true;
            loginPanel.BringToFront();
        }

      
        private void bugsReportedbutton_Click(object sender, EventArgs e)
        {
            showBugs frm = new showBugs(currentUser);
            frm.Show();
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.DoDragDrop(listBox2.SelectedItem.ToString(), DragDropEffects.Copy);
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            listBox1.Items.Add(e.Data.GetData(DataFormats.Text));
            listBox2.Items.Remove(e.Data.GetData(DataFormats.Text));
        }

        private void pricingsButton_Click(object sender, EventArgs e)
        {
            Pricings frm = new Pricings();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserSolution frm = new UserSolution(currentUser);
            frm.Show();
        }
        
    }
}
