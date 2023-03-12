using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vatsim.Network;

namespace AuATIS.Client
{
    public partial class Connection : Form
    {

        public Connection()
        {
            InitializeComponent();

            c_Servers.DataSource = new List<string>(Program.ApiHandle.Servers.Keys);
            c_Ratings.DataSource = Enum.GetNames(typeof(NetworkRating)).ToList<string>();
        }

        private void Connection_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        public void Preload()
        {
            t_RealName.Text = Program.ConfigHandle.Config.user.name;
            t_VatsimID.Text = Program.ConfigHandle.Config.user.cid;
            c_Ratings.Text = Program.ApiHandle.RatingsReverseL[Program.ConfigHandle.Config.user.rating];
            c_Servers.Text = Program.ConfigHandle.Config.user.server;
        }

        private void l_Connect_Click(object sender, EventArgs e)
        {
            Program.ConfigHandle.Config.user.name = t_RealName.Text;
            Program.ConfigHandle.Config.user.cid = t_VatsimID.Text;
            Program.ConfigHandle.Config.user.rating = Program.ApiHandle.Ratings[c_Ratings.Text];
            Program.ConfigHandle.Config.user.server = c_Servers.SelectedText;
            Program.ConfigHandle.SaveData();
        }
    }
}
