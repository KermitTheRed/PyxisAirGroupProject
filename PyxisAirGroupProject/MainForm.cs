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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CustBTN_Click(object sender, EventArgs e)
        {
            CustomerForm custF = new CustomerForm();
            custF.ShowDialog();
        }

        private void FlightBTN_Click(object sender, EventArgs e)
        {
            FlightForm FlightF = new FlightForm();
            FlightF.ShowDialog();
        }

        private void RSVBTN_Click(object sender, EventArgs e)
        {
            ReservationForm RSVF = new ReservationForm();
            RSVF.ShowDialog();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
