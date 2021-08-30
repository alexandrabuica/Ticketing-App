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

namespace Proiect
{
    public partial class Pie : Form
    {
        ListView lview;
        const int mg = 10;
        public Pie(ListView lv)
        {
            InitializeComponent();
            this.CenterToScreen();
            lview = lv;
        }

        private void Pie_Paint(object sender, PaintEventArgs e)
        {
            Graphics g2 = e.Graphics;
            Rectangle rectangle = new Rectangle(this.ClientRectangle.X + mg, this.ClientRectangle.Y + 2 * mg,
                  this.ClientRectangle.Width - 2 * mg, panel1.ClientRectangle.Y + 42 * mg);
            Pen myPen = new Pen(Color.LimeGreen, 3);
            g2.DrawRectangle(myPen, rectangle);
            int[] Values = new int[4];
            int p1 = 0, p2 = 0, p3 = 0, p4 = 0;
            foreach (ListViewItem itm in lview.Items)
            {

                if (itm.SubItems[4].Text == "1") p1++;
                if (itm.SubItems[4].Text == "2") p2++;
                if (itm.SubItems[4].Text == "3") p3++;
                if (itm.SubItems[4].Text == "4") p4++;

                Values[0] = p1;
                Values[1] = p2;
                Values[2] = p3;
                Values[3] = p4;
            }

            Brush[] SliceBrushes =
            {
                Brushes.Aqua,
                Brushes.Purple,
                Brushes.Orange,
                Brushes.Red,
            };
            Pen pen = new Pen(Color.Black, 2);
            int total = Values.Sum();
            float start_angle = 0;
            for (int i = 0; i < Values.Length; i++)
            {
                float sweep_angle = Values[i] * 360f / total;
                Rectangle rc = new Rectangle(30, 40, 300, 300);
                g2.FillPie(SliceBrushes[i], rc, start_angle, sweep_angle);
                g2.DrawPie(pen, rc, start_angle, sweep_angle);
                start_angle += sweep_angle;

            }

            int sp = 40;
            string[] legend = { "Priority 1 - Low  ", "Priority 2 - Medium  ", "Priority 3 - High  ", "Priority 4 - Urgent" };

            Rectangle[] rec = new Rectangle[4];
            for (int i = 0; i < Values.Length; i++)
            {
                rec[i] = new Rectangle(370, sp, 10, 10);
                g2.DrawRectangle(pen, rec[i]);
                g2.FillRectangle(SliceBrushes[i], rec[i]);
                g2.DrawString(legend[i], new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(Color.Black), new Point(380, sp - 4));
                sp += 30;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g2 = e.Graphics;
            Rectangle rectangle = new Rectangle(panel1.ClientRectangle.X + mg, panel1.ClientRectangle.Y + 2 * mg,
                 panel1.ClientRectangle.Width - 2 * mg, panel1.ClientRectangle.Y + 42 * mg);
            Pen myPen = new Pen(Color.LimeGreen, 3);
            g2.DrawRectangle(myPen, rectangle);
            int[] Values = new int[4];
            int p1 = 0, p2 = 0, p3 = 0, p4 = 0;
            foreach (ListViewItem itm in lview.Items)
            {

                if (itm.SubItems[4].Text == "1") p1++;
                if (itm.SubItems[4].Text == "2") p2++;
                if (itm.SubItems[4].Text == "3") p3++;
                if (itm.SubItems[4].Text == "4") p4++;

                Values[0] = p1;
                Values[1] = p2;
                Values[2] = p3;
                Values[3] = p4;
            }

            Brush[] SliceBrushes =
            {
                Brushes.Aqua,
                Brushes.Lime,
                Brushes.Orange,
                Brushes.Red,
            };
            Pen pen = new Pen(Color.Black, 2);
            int total = Values.Sum();
            float start_angle = 0;
            for (int i = 0; i < Values.Length; i++)
            {
                float sweep_angle = Values[i] * 360f / total;
                Rectangle rc = new Rectangle(30, 40, 300, 300);
                g2.FillPie(SliceBrushes[i], rc, start_angle, sweep_angle);
                g2.DrawPie(pen, rc, start_angle, sweep_angle);
                start_angle += sweep_angle;

            }

            int sp = 40;
            string[] legend = { "Priority 1 - Low  ", "Priority 2 - Medium  ", "Priority 3 - High  ", "Priority 4 - Urgent" };

            Rectangle[] rec = new Rectangle[4];
            for (int i = 0; i < Values.Length; i++)
            {
                rec[i] = new Rectangle(370, sp, 10, 10);
                g2.DrawRectangle(pen, rec[i]);
                g2.FillRectangle(SliceBrushes[i], rec[i]);
                g2.DrawString(legend[i], new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(Color.Black), new Point(380, sp - 4));
                sp += 30;
            }
        }
        private void save(Control c, string name)
        {
            bt1.Visible = false;
            Bitmap img = new Bitmap(panel1.Width, panel1.Height);
            c.DrawToBitmap(img, new Rectangle(panel1.ClientRectangle.X, panel1.ClientRectangle.Y,
                panel1.ClientRectangle.Width, panel1.ClientRectangle.Height));
            img.Save(name);
            img.Dispose();
            bt1.Visible = true;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            save(panel1, "imagePie.bmp");
            MessageBox.Show("Picture saved!");
        }

        private void pdPrint(object sender, PrintPageEventArgs e)
        {
            Graphics g2 = e.Graphics;
            Rectangle rectangle = new Rectangle(e.PageBounds.X + mg, e.PageBounds.Y + 2 * mg,
                e.PageBounds.Width - 2 * mg, e.PageBounds.Y + 42 * mg);
            Pen myPen = new Pen(Color.LimeGreen, 3);
            g2.DrawRectangle(myPen, rectangle);
            int[] Values = new int[4];
            int p1 = 0, p2 = 0, p3 = 0, p4 = 0;
            foreach (ListViewItem itm in lview.Items)
            {

                if (itm.SubItems[4].Text == "1") p1++;
                if (itm.SubItems[4].Text == "2") p2++;
                if (itm.SubItems[4].Text == "3") p3++;
                if (itm.SubItems[4].Text == "4") p4++;

                Values[0] = p1;
                Values[1] = p2;
                Values[2] = p3;
                Values[3] = p4;
            }

            Brush[] SliceBrushes =
            {
                Brushes.Aqua,
                Brushes.Lime,
                Brushes.Orange,
                Brushes.Red,
            };
            Pen pen = new Pen(Color.Black, 2);
            int total = Values.Sum();
            float start_angle = 0;
            for (int i = 0; i < Values.Length; i++)
            {
                float sweep_angle = Values[i] * 360f / total;
                Rectangle rc = new Rectangle(30, 40, 300, 300);
                g2.FillPie(SliceBrushes[i], rc, start_angle, sweep_angle);
                g2.DrawPie(pen, rc, start_angle, sweep_angle);
                start_angle += sweep_angle;

            }

            int sp = 40;
            string[] legend = { "Priority 1 - Low  ", "Priority 2 - Medium  ", "Priority 3 - High  ", "Priority 4 - Urgent" };

            Rectangle[] rec = new Rectangle[4];
            for (int i = 0; i < Values.Length; i++)
            {
                rec[i] = new Rectangle(370, sp, 10, 10);
                g2.DrawRectangle(pen, rec[i]);
                g2.FillRectangle(SliceBrushes[i], rec[i]);
                g2.DrawString(legend[i], new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(Color.Black), new Point(380, sp - 4));
                sp += 30;
            }
        }
        
    }
}