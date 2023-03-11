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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void b_ATISEditor(object sender, EventArgs e)
        {
            ATISEditor EditWindow = new ATISEditor();
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

        private void b_AEditor_Click(object sender, EventArgs e)
        {
            Program.EditorWindow.Show();
        }

        private void l_Settings_MouseEnter(object sender, EventArgs e)
        {
            l_Settings.BackColor = Color.FromArgb(130, 146, 146);
        }

        private void l_Settings_MouseLeave(object sender, EventArgs e)
        {
            l_Settings.BackColor = Color.FromArgb(160, 170, 170);
        }

        private void l_Settings_Click(object sender, EventArgs e)
        {
            l_d_Connection.Show();
            l_d_ChangeProfile.Show();
        }

        private void l_d_Connection_Click(object sender, EventArgs e)
        {
            //Program.ConnectionWindow.Show();
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

        private void l_d_Connection_MouseEnter(object sender, EventArgs e)
        {
            l_d_Connection.BackColor = Color.FromArgb(130, 146, 146);
        }

        private void l_d_Connection_MouseLeave(object sender, EventArgs e)
        {
            l_d_Connection.BackColor = Color.FromArgb(160, 170, 170);
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void l_d_ChangeProfile_MouseEnter(object sender, EventArgs e)
        {
            l_d_ChangeProfile.BackColor = Color.FromArgb(130, 146, 146);
        }

        private void l_d_ChangeProfile_MouseLeave(object sender, EventArgs e)
        {
            l_d_ChangeProfile.BackColor = Color.FromArgb(160, 170, 170);
        }

        private void l_Editor_MouseClick(object sender, MouseEventArgs e)
        {
            Program.EditorWindow.Show();
        }

        private void l_Editor_MouseEnter(object sender, EventArgs e)
        {
            l_Editor.BackColor = Color.FromArgb(130, 146, 146);
        }

        private void l_Editor_MouseLeave(object sender, EventArgs e)
        {
            l_Editor.BackColor = Color.FromArgb(160, 170, 170);
        }
    }
}