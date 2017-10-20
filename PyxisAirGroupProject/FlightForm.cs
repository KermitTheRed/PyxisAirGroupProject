using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PyxisAirGroupProject
{
    public partial class FlightForm : Form
    {
        public FlightForm()
        {
            InitializeComponent();
        }

        private void flightFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String n;
            n = toolStripTextBox1.Text;
            listBox1.Items.Add(n);
        }

       
    }
}
