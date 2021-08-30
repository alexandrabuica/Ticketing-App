using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Pricings : Form
    {
        public Pricings()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        int packValue;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox1.BackColor = System.Drawing.SystemColors.Window;
        }

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hScrollBar1.Value = Convert.ToInt32(tbNumber.Text);
            }
            catch
            {
                hScrollBar1.Value = 1;
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            tbNumber.Text = hScrollBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbPackage.Text == "")
                errorProvider1.SetError(cbPackage, "Please select a pacakage!");
            else if (cbPay.Text == "")
                errorProvider1.SetError(cbPay, "Please select a way of payment!");
            else if (tbNumber.Text == "")
                errorProvider1.SetError(tbNumber, "Enter the number of client users!");
            else if (rb24.Checked == false && rbwh.Checked == false && rbonline.Checked == false)
                errorProvider1.SetError(label4, "Select support type!");
            else
            {
                try
                {
                    int number = Convert.ToInt32(tbNumber.Text);
                    if (cbPackage.Text == "Standard" && cbPay.Text == "Monthly") { packValue = 18; }
                    else if (cbPackage.Text == "Standard" && cbPay.Text == "Yearly") { packValue = 13; }
                    else if (cbPackage.Text == "Premium" && cbPay.Text == "Monthly") { packValue = 60; }
                    else if (cbPackage.Text == "Premium" && cbPay.Text == "Yearly") { packValue = 45; }
                    else
                    {
                        packValue = 0;
                        number = 0;
                        packValue += 2 * number;
                    }
                    packValue += 2 * number;

                    string payment = cbPay.Text;
                    string support = null;
                    if (rb24.Checked == true) { packValue += 10; support = rb24.Text; }
                    else if (rbwh.Checked == true) { packValue += 6; support = rbwh.Text; }
                    else if (rbonline.Checked == true) { packValue += 3; support = rbonline.Text; }
                    tbPrice.Text = packValue.ToString();
                    Price p = new Price(payment, number, support, packValue);
                    MessageBox.Show(p.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbPrice.Clear();
                    cbPackage.Text = "";
                    cbPay.Text = "";
                    tbNumber.Clear();
                    rb24.Checked = rbonline.Checked = rbwh.Checked = false;
                }
            }
        }

        private void cbPackage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Pricings_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbPay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rb24_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbonline_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void rbwh_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
