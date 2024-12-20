namespace TrackerUI
{
    internal static class Program
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

            //Initialize database connections
            //TournamentLibrary.GlobalConfig.InitializeConnections(TournamentLibrary.DatabaseType.Sql);
            TournamentLibrary.GlobalConfig.InitializeConnections(TournamentLibrary.DatabaseType.Sql);

            Application.Run(new CreateTeamForm());
            //Application.Run(new TournamentDashboardForm());
        }
    }
}