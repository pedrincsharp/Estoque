namespace JP.Estoque
{
    internal static class Program
    {

        public static Color COLOR_BACKGROUND;
        public static Color COLOR_WINDOW;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            COLOR_BACKGROUND = Color.FromArgb(0, 127, 129);
            COLOR_WINDOW = Color.FromArgb(191, 192, 192);

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}