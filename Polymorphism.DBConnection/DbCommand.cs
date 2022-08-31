namespace Polymorphism.DBConnection;

public class DbCommand
{
    private DbConnection _dbConnection;
    public DbCommand(DbConnection dbConnection)
    {
        _dbConnection = dbConnection ?? throw new ArgumentNullException(nameof(dbConnection), "Can't be null");
    }

    public void Execute(string sqlCommand)
    {
        _dbConnection.OpenConnection();
        Console.WriteLine($"Command executed: @{sqlCommand}");
        _dbConnection.CloseConnection();
    }
}