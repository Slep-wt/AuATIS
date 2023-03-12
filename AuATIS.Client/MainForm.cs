using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Runtime;
using System.Windows.Forms;

namespace AuATIS.Client
{
    public partial class MainForm : Form
    {

        /* ATIS Field Variables */


        /* End ATIS Field Variables */
        public MainForm()
        {
            InitializeComponent();
            string profile = Program.ConfigHandle.Config.user.profile;
            if (profile == "" || !Program.UtilityHandle.Profiles.ContainsKey(profile))
            {
                Program.ProfileWindow.Show();
                Program.ProfileWindow.TopMost = true;
            }
            else
            {
                Program.FrequencyHandle.Initialise(profile);
                Program.TranslatorHandle.Initialise(profile);
                l_ProfileCurrent.Text = profile;
                Program.ConnectionWindow.Preload();
            }
            l_Atis1.Text = "New...";
        }



        private bool l_Settings_State_Clicked = false;
        private void l_Settings_Click(object sender, MouseEventArgs e)
        {
            if (!l_Settings_State_Clicked)
            {
                l_Settings_State_Clicked = true;
                l_d_Connection.Show();
                l_d_ChangeProfile.Show();
            }
            else
            {
                l_Settings_State_Clicked = false;
                l_d_Connection.Hide();
                l_d_ChangeProfile.Hide();
            }
        }

        private void l_d_Connection_Click(object sender, EventArgs e)
        {
            Program.ConnectionWindow.Show();
        }

        private void l_d_ChangeProfile_Click(object sender, EventArgs e)
        {
            Program.ProfileWindow.Show();
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            l_d_Connection.Hide();
            l_d_ChangeProfile.Hide();
        }

        bool l_Editor_State_Clicked = false;
        private void l_Editor_MouseClick(object sender, MouseEventArgs e)
        {
            if (!l_Editor_State_Clicked)
            {
                l_Editor_State_Clicked = true;
                l_Atis1.Show();
            }
            else
            {
                l_Editor_State_Clicked = false;
                l_Atis1.Hide();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing /*&& Program.Variables.ATISAlive*/)
            {
                const string Alert = "Are you sure you want to quit?";
                const string Title = "Close AuATIS";
                DialogResult Res = MessageBox.Show(Alert, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Res == DialogResult.Yes)
                {
                    Program.ConfigHandle.SaveData();
                    Application.Exit();
                }
                else
                    e.Cancel = true;
            }
        }

        public void Taskbar_MouseEnter(object sender, EventArgs e)
        {
            Label source = (Label)sender;
            source.BackColor = Color.FromArgb(130, 146, 146);
        }

        public void Taskbar_MouseLeave(object sender, EventArgs e)
        {
            Label source = (Label)sender;
            source.BackColor = Color.FromArgb(160, 170, 170);
        }
    }
}