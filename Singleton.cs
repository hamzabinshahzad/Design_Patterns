
namespace Design_Patterns
{
    public sealed class Singleton
    {
        private static Singleton _instance;
        private static object _lock = new object(); // To be used in locking

        private Singleton() { }

        // To let calling services get the instance:
        public static Singleton GetInstance()
        {
            // Implement Double Check locking pattern: We use this to make sure we prevent unneccasry call to lock block because it adds performance issues.
            // We call it "Double Check" because we have two conditionals, we are checking the condition twice.
            if(_instance == null )
            { 
                lock(_lock) // Used to only allow a single thread to create instance in multithreaded applications.
                {
                    if(_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }

    }
}
