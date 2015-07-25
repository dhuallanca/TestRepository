namespace LoggerDataAccess.Interface
{
    public interface ILogDataAccess
    {
        void InsertMessage(string message, int logType);
    }
}