using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Copyright : UserControl
    {
        public Copyright()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();

            labelName.Text = "Buica Elena Alexandra";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LabelDate.Text=  System.DateTime.Now.ToString();
        }
    }
}
