namespace AuATIS.Client
{
    public static class Program
    {
        public static Frequencies FrequencyHandle;
        public static Translator TranslatorHandle;
        public static ATISOrder ATISOrderHandle;
        public static Utility UtilityHandle;

        public static MainForm MainWindow;
        public static ATISEditor EditorWindow;
        public static SelectProfile ProfileWindow;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UtilityHandle = new Utility();
            FrequencyHandle = new Frequencies();
            TranslatorHandle = new Translator();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ProfileWindow = new SelectProfile();
            EditorWindow = new ATISEditor();
            MainWindow = new MainForm();
            Application.Run(MainWindow);
        }
    }
}