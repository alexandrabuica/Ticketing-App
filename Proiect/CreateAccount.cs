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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            this.CenterToScreen();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DataBase.accdb");
           
            if (tbName.Text == "")
                errorProvider1.SetError(tbName, "Name cannot be empty!");
            else if (tbPhone.Text == "")
                errorProvider1.SetError(tbPhone, "Telephone cannot be empty!");
            else if (tbUsername.Text == "")
                errorProvider1.SetError(tbUsername, "Username cannot be empty!");
            else if (tbPhone.Text == "")
                errorProvider1.SetError(tbPassword, "Telephone cannot be empty!");
            else if (tbPassword.Text == "" || tbPassword.TextLength < 5)
                errorProvider1.SetError(tbPassword, "Password has to be at least 5 characters length!");
            else
            {
                try
                {
                    conexiune.Open();
                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;
                    if (rbUs.Checked == true)
                    {
                        comanda.CommandText = "SELECT MAX(ID) FROM Users";
                        int id = Convert.ToInt32(comanda.ExecuteScalar());

                        comanda.CommandText = "INSERT INTO Users VALUES(?,?,?,?,?)";
                        comanda.Parameters.Add("ID", OleDbType.Integer).Value = id + 1;
                        comanda.Parameters.Add("fullName", OleDbType.Char).Value = tbName.Text;
                        comanda.Parameters.Add("telephone", OleDbType.Char).Value = tbPhone.Text;
                        comanda.Parameters.Add("username", OleDbType.Char).Value = tbUsername.Text;
                        comanda.Parameters.Add("password", OleDbType.Char).Value = tbPassword.Text;
                        comanda.ExecuteNonQuery();
                    }
                    else if (rbDev.Checked==true)
                    {
                        comanda.CommandText = "SELECT MAX(ID) FROM Programmers";
                        int id = Convert.ToInt32(comanda.ExecuteScalar());

                        comanda.CommandText = "INSERT INTO Programmers VALUES(?,?,?,?,?)";
                        comanda.Parameters.Add("ID", OleDbType.Integer).Value = id + 1;
                        comanda.Parameters.Add("fullName", OleDbType.Char).Value = tbName.Text;
                        comanda.Parameters.Add("telephone", OleDbType.Char).Value = tbPhone.Text;
                        comanda.Parameters.Add("username", OleDbType.Char).Value = tbUsername.Text;
                        comanda.Parameters.Add("password", OleDbType.Char).Value = tbPassword.Text;
                        comanda.ExecuteNonQuery();
                    }
                    MessageBox.Show("Registration successful!");
                    this.Close();
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
                    tbName.Clear();
                    tbPhone.Clear();
                    tbUsername.Clear();
                    tbPassword.Clear();
                    conexiune.Close();
                }
            }
        }
        
    }
}
