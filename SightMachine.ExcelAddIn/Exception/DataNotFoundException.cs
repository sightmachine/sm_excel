namespace ExcelAddIn.Exception
{
    public class DataNotFoundException : System.Exception
    {
        public DataNotFoundException()
        {
        }

        public DataNotFoundException(string message)
            : base(message)
        {
        }

        public DataNotFoundException(string message, System.Exception inner)
            : base(message, inner)
        {
        }
    }
}