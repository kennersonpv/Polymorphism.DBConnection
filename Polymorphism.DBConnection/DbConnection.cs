namespace Polymorphism.DBConnection
{
    public abstract class DbConnection
    {
        private string _connectionString;
        private TimeSpan _timeout;

        protected DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException(nameof(connectionString),$"Can't be null");
            }
            _connectionString = connectionString;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}