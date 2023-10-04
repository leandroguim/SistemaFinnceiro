namespace Db
{
    public class Conexao
    {
        private static readonly string server = "DESKTOP-BA373RT\\SQLEXPRESS";
        private static readonly string database = "Financeiro";
        private static readonly string username = "sa";
        private static readonly string password = "77basslg";

        public static string GetStringConnection() => $"Server={server};Database={database};User Id={username};Password={password}";
    }
}