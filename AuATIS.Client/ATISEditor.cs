using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;

namespace AuATIS.Client
{
    public partial class ATISEditor : Form
    {
        public ATISEditor()
        {
            InitializeComponent();
        }

        private void ATISEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ATISEditor_Load(object sender, EventArgs e)
        {

        }

        private void l_TimeCheck_Click(object sender, EventArgs e)
        {
        }

        private void l_ATIS_AZ_Click(object sender, EventArgs e)
        {
        }

        private void i_AirportICAO_TextChanged(object sender, EventArgs e)
        {
            if (i_AirportICAO.Text.Length == 4)
            {
                i_ATISFreq.Text = Program.FrequencyHandle.Find(i_AirportICAO.Text);
            }
            else
            {
                i_ATISFreq.Text = "";
            }
        }

        private async void l_GetMETAR_Click(object sender, EventArgs e)
        {
            string AResult = "No METAR";
            if (i_AirportICAO.Text.Length == 4)
            {
                AResult = await Program.ApiHandle.HttpGet(Program.ApiHandle.METARUrl + "?id=" + i_AirportICAO.Text);
                if (AResult == "")
                {
                    AResult = "No METAR";
                }
            }
            l_METAR.Text = AResult;
            // Process METAR
        }
    }
}
