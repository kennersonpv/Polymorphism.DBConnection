namespace Polymorphism.DBConnection;

public class SqlConnection : DbConnection
{
    public SqlConnection(string connectionString) : base(connectionString)
    {
    }

    public override void OpenConnection()
    {
        Console.WriteLine("Sql Connection is Open");
    }

    public override void CloseConnection()
    {
        Console.WriteLine("Sql Connection is Closed");
    }
}