namespace LibraryManager.Database.Data
{
    public static class Configuration
    {
        public static string ConnectionString = @$"Data Source={ConfigurationConstants.SERVER_NAME};Database=LibraryManager;Trusted_Connection=True";
    }
}
