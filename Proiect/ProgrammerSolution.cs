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
using System.IO;

namespace Proiect
{
    public partial class ProgrammerSolution : Form
    {
        ListView listView;
        Random rnd = new Random();
        string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DataBase.accdb";
        public ProgrammerSolution(ListView lw)
        {
            InitializeComponent();
            this.CenterToScreen();
            listView = lw;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Image myImage;
        //    OpenFileDialog dlg = new OpenFileDialog();
        //    dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

        //    if (dlg.ShowDialog() == DialogResult.OK)
        //    {
        //        myImage = Image.FromFile(dlg.FileName);
        //    };

        //}

        private void save(Control c, string name)
        {
            Bitmap img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            c.DrawToBitmap(img, new Rectangle(pictureBox1.ClientRectangle.X, pictureBox1.ClientRectangle.Y,
                pictureBox1.ClientRectangle.Width, pictureBox1.ClientRectangle.Height));
            img.Save(name);
            img.Dispose();
        }



        private void solutionButton_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            conexiune.Open();
            try
            {
                int userID;
                foreach (ListViewItem itm in listView.Items)
                {
                    if (itm.Selected)
                    {
                        userID = Convert.ToInt32(itm.SubItems[1].Text);
                        OleDbCommand comanda = new OleDbCommand();
                        comanda.Connection = conexiune;
                        int id = rnd.Next(99, 3000);
                        comanda.CommandText = "INSERT INTO Solutions VALUES(?,?,?)";
                        comanda.Parameters.Add("ID", OleDbType.Integer).Value = id;
                        comanda.Parameters.Add("userID", OleDbType.Integer).Value = userID;
                        comanda.Parameters.Add("details", OleDbType.Char).Value = SolTb.Text;
                        comanda.ExecuteNonQuery();
                        int solved = 1;
                        comanda.CommandText = "UPDATE Bugs SET solved = 1";
                        comanda.Parameters.Add("solved", OleDbType.Integer).Value = solved;
                        comanda.ExecuteNonQuery();
                        save(pictureBox1, "imgSolution.bmp");
                        MessageBox.Show("Solution successfully saved!");
                        comanda.ExecuteNonQuery();
                        itm.BackColor = Color.FromArgb(80, 215, 38);
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
            finally
            {
                conexiune.Close();
                SolTb.Clear();
                pictureBox1.Image = null;
                this.Close();
            }
        }


       

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
           label1.Visible = false;
           string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (data!=null)
            {
                string[] fileNames = data;
                if (fileNames.Length > 0)
                    pictureBox1.Image = Image.FromFile(fileNames[0]);
            }
        }

        private void Solution_Load(object sender, EventArgs e)
        {
            pictureBox1.AllowDrop = true;
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
