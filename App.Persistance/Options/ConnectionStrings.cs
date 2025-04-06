namespace App.Persistance.Options
{
    public class ConnectionStrings
    {
        public const string Key = "ConnectionStrings";
        public string DefaultConnection { get; set; } = default!;
        public string SqlServer { get; set; } = default!;
        public string MySql { get; set; } = default!;
    }
}
