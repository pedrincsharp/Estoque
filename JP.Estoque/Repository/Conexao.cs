using MySqlConnector;

namespace JP.Estoque.Repository
{
    internal class Conexao
    {
        private string _server = string.Empty;
        private string _username = string.Empty;
        private string _password = string.Empty;
        private string _port = string.Empty;
        private string _database = string.Empty;

        public Conexao(string server, string username, string password, string port, string database)
        {
            _server = server;
            _username = username;
            _password = password;
            _port = port;
            _database = database;
        }

        public Conexao()
        {
            _server = "localhost";
            _username = "root";
            _password = "123";
            _port = "3306";
            _database = "sistema_estoque";
        }

        private string MontaConnectionString()
        {
            return $"Server={_server};Port={_port};Database={_database};Uid={_username};Pwd={_password};ConvertZeroDateTime=True;";
        }

        public MySqlConnection AbrirConexao()
        {
            var con = new MySqlConnection(MontaConnectionString());
            con.Open();
            return con;
        }
    }
}
