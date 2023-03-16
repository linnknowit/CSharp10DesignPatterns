namespace Singleton
{
  public class Logger
    {
        private static readonly Lazy<Logger> _lazyLogger 
            = new Lazy<Logger>(() => new Logger());

        //private static Logger? _instance;

        public static Logger? Instance
        {
            get
            {
                return _lazyLogger.Value;
                //_instance ??= new Logger();
                //return _instance;
            }
        }
        protected Logger() 
        {
            
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
