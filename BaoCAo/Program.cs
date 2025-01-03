using BaoCAo.Class.Component;

namespace BaoCAo
{
    /*    internal static class Program
        {
            /// <summary>
            ///  The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main()
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new Main());
            }
        }*/
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (Login loginForm = new Login())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Assuming loginForm contains a property for the logged-in user
                    User user = loginForm.USN;
                    if (user != null)
                    {
                        Main m = new Main();
                        m.u = user;
                        Application.Run(m);
                    }
                }
            }
        }
    }
}