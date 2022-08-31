namespace Polymorphism.DBConnection;

public class OracleConnection : DbConnection
{
    public OracleConnection(string connectionString) : base(connectionString)
    {
    }

    public override void OpenConnection()
    {
        Console.WriteLine("Oracle Connection is Open");
    }

    public override void CloseConnection()
    {
        Console.WriteLine("Oracle Connection is Closed");
    }
}