namespace Polymorphism.DBConnection
{ 
    static partial class Program
    {
        static void Main(string[] args)
        {
            var sqlConnection = new SqlConnection("SqlConnection");
            var sqlCommand = new DbCommand(sqlConnection);
            sqlCommand.Execute("select * from SQLtable");

            var oracleConnection = new OracleConnection("OracleConnection");
            var oracleCommand = new DbCommand(oracleConnection);
            oracleCommand.Execute("select * from oracleTable");
        }
    }
}

