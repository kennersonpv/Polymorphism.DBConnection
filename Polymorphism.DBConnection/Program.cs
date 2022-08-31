namespace Polymorphism.DBConnection
{ 
    static partial class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("SqlConnection");
            sqlConnection.OpenConnection();
            sqlConnection.CloseConnection();

            var oracleConnection = new OracleConnection("OracleConnection");
            oracleConnection.OpenConnection();
            oracleConnection.CloseConnection();
        }
    }
}

