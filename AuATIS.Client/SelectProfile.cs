using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuATIS.Client
{
    public partial class SelectProfile : Form
    {
        public SelectProfile()
        {
            InitializeComponent();
            i_Profiles.DataSource = Program.UtilityHandle.Profiles.Keys.ToList<string>();
        }

        private void i_Profiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Program.FrequencyHandle.Initialise((string)i_Profiles.SelectedItem);
            Program.TranslatorHandle.Initialise((string)i_Profiles.SelectedItem);
            Program.MainWindow.l_ProfileCurrent.Text = (string)i_Profiles.SelectedItem;
            Hide();
        }

        private void ChildForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
