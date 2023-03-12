using System.Net;
using System.Runtime;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Timers;

namespace AuATIS.Client
{
    public static class Program
    {
        public static SystemConfig ConfigHandle;
        public static Frequencies FrequencyHandle;
        public static Translator TranslatorHandle;
        public static ATISOrder ATISOrderHandle;
        public static Utility UtilityHandle;
        public static Api ApiHandle;

        public static MainForm MainWindow;
        public static ATISEditor EditorWindow;
        public static SelectProfile ProfileWindow;
        public static Connection ConnectionWindow;

        public static class Variables
        {
            static bool ATISRunning = false;

            static readonly Tuple<string, Uri> VATSIMServer = new Tuple<string, Uri>("AUTOMATIC", new Uri("fsd.connect.vatsim.net"));
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigHandle = new SystemConfig();
            UtilityHandle = new Utility();
            FrequencyHandle = new Frequencies();
            TranslatorHandle = new Translator();
            ApiHandle = new Api();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ProfileWindow = new SelectProfile();
            ConnectionWindow = new Connection();
            EditorWindow = new ATISEditor();
            MainWindow = new MainForm();

            // Start Program Clock
            Thread UTCTimer = new Thread(UTCUpdateThread);
            UTCTimer.Start();
            Application.Run(MainWindow);
        }

        // UTC Update Thread Environment
        internal static System.Timers.Timer ClientTick = null;
        public static void UTCUpdateThread()
        {
            ClientTick = new System.Timers.Timer();
            ClientTick.Interval = 200; // Update time in ms
            ClientTick.Elapsed += new ElapsedEventHandler(EH_TimeUTCUpdate);
            ClientTick.Start();
        }

        private static void EH_TimeUTCUpdate(object sender, ElapsedEventArgs e)
        {
            string UTCLong = DateTime.UtcNow.ToLongTimeString();
            MainWindow.t_TimeUTC.Invoke((MethodInvoker)delegate
            {
                MainWindow.t_TimeUTC.Text = UTCLong;
            });
        }
        // End UTC Update Thread Environment
    }
}