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
    public partial class UserSolution : Form
    {
        string connString;
        User currentUser;
        public UserSolution(User usr)
        {
            InitializeComponent();
            this.CenterToScreen();
            currentUser = usr;
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DataBase.accdb";

            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT details FROM Solutions WHERE userID=" + currentUser.ID;
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    tbsolutions.Text = reader["details"].ToString();
                }

                label1.Visible = false;
                pictureBox1.Image = new Bitmap("imgSolution.bmp");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void solutionButton_Click(object sender, EventArgs e)
        {
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DataBase.accdb";

            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "DELETE FROM Solutions WHERE userID=" + currentUser.ID;
                comanda.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexiune.Close();
                this.Close();
            }
        }
    }
}
