namespace jet.exceptions
{
    public class JetException : Exception
    {
        public JetException()
        {

        }

        public JetException(string message) : base(message)
        {
        }

        public JetException(string message, Exception ex) : base(message, ex)
        {
        }
    }
}
