namespace SingletonPattern
{
    /// <summary>
    /// 
    /// Not a thread safe implementation.
    /// For alternative versions: http://csharpindepth.com/Articles/General/Singleton.aspx 
    /// 
    /// </summary>
    public class Singleton
    {
        private static Singleton uniqueInstance;

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Singleton();
            }

            return uniqueInstance;
        }

        // other useful methods here
    }


    // fully lazily-loaded, thread-safe, simple and highly performant version

    //public sealed class Singleton
    //{
    //    private static readonly Lazy<Singleton> lazy =
    //        new Lazy<Singleton>(() => new Singleton());

    //    public static Singleton Instance { get { return lazy.Value; } }

    //    private Singleton()
    //    {
    //    }
    //}
}
