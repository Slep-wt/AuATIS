using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Runtime;
using System.Windows.Forms;

namespace AuATIS.Client
{
    public partial class MainForm : Form
    {
        internal System.Windows.Forms.Timer ClientTick = null;
        public MainForm()
        {
            StartClientTimer();
            InitializeComponent();
            Program.ProfileWindow.Show();
            Program.ProfileWindow.TopMost = true;

        }


        private void StartClientTimer()
        {
            ClientTick = new System.Windows.Forms.Timer();
            ClientTick.Interval = 500; // Update time in ms
            ClientTick.Tick += new EventHandler(t_TimeUTCUpdate);
            ClientTick.Start();
        }

        private void t_TimeUTCUpdate(object sender, EventArgs e)
        {
            t_TimeUTC.Text = DateTime.UtcNow.ToLongTimeString();
        }


        private void l_Settings_Click(object sender, EventArgs e)
        {
            l_d_Connection.Show();
            l_d_ChangeProfile.Show();
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

        private void l_Editor_MouseClick(object sender, MouseEventArgs e)
        {
            Program.EditorWindow.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing /*&& Program.Variables.ATISAlive*/)
            {
                const string Alert = "Are you sure you want to quit?";
                const string Title = "Close AuATIS";
                DialogResult Res = MessageBox.Show(Alert, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Res == DialogResult.Yes)
                    Application.Exit();
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