using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Printing;

namespace Proiect
{
    public partial class Chart : Form
    {
        ListView lvw;
        public Chart(ListView list)
        {
            InitializeComponent();
            this.CenterToScreen();
            lvw = list;
            chart1.Parent = panel1;
        }
        private void save(Control c, string name)
        {
            Bitmap img = new Bitmap(panel1.Width, panel1.Height);
            c.DrawToBitmap(img, new Rectangle(panel1.ClientRectangle.X, panel1.ClientRectangle.Y,
                panel1.ClientRectangle.Width, panel1.ClientRectangle.Height));
            img.Save(name);
            img.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int hwr = 0, sfw = 0, net = 0, sec = 0, oth = 0;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            foreach (ListViewItem itm in lvw.Items)
            {

                if (itm.SubItems[3].Text == "Hardware") hwr++;
                if (itm.SubItems[3].Text == "Software") sfw++;
                if (itm.SubItems[3].Text == "Networking") net++;
                if (itm.SubItems[3].Text == "Security") sec++;
                if (itm.SubItems[3].Text == "Other") oth++;

            }
            int[] yValues = { hwr, sfw, net, sec, oth };
            string[] xValues = { "Hardware", "Software", "Networking", "Security", "Other" };
            chart1.Series["Category"].Points.DataBindXY(xValues, yValues);
            
        }
        

        private void saveGraphicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save(panel1, "imageChart.bmp");
            MessageBox.Show("Picture saved!");
        }

        private void pdPrint(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int hwr = 0, sfw = 0, net = 0, sec = 0, oth = 0;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            foreach (ListViewItem itm in lvw.Items)
            {

                if (itm.SubItems[3].Text == "Hardware") hwr++;
                if (itm.SubItems[3].Text == "Software") sfw++;
                if (itm.SubItems[3].Text == "Networking") net++;
                if (itm.SubItems[3].Text == "Security") sec++;
                if (itm.SubItems[3].Text == "Other") oth++;

            }
            int[] yValues = { hwr, sfw, net, sec, oth };
            string[] xValues = { "Hardware", "Software", "Networking", "Security", "Other" };
            chart1.Series["Category"].Points.DataBindXY(xValues, yValues);
        
        }


        private void Chart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int hwr = 0, sfw = 0, net = 0, sec = 0, oth = 0;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            foreach (ListViewItem itm in lvw.Items)
            {

                if (itm.SubItems[3].Text == "Hardware") hwr++;
                if (itm.SubItems[3].Text == "Software") sfw++;
                if (itm.SubItems[3].Text == "Networking") net++;
                if (itm.SubItems[3].Text == "Security") sec++;
                if (itm.SubItems[3].Text == "Other") oth++;

            }
            int[] yValues = { hwr, sfw, net, sec, oth };
            string[] xValues = { "Hardware", "Software", "Networking", "Security", "Other" };
            chart1.Series["Category"].Points.DataBindXY(xValues, yValues);
        }
    }

       
     
}
