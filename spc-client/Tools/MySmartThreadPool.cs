using Amib.Threading;

namespace spc_client.Tools
{
    public class MySmartThreadPool
    {
        static SmartThreadPool Pool = new SmartThreadPool() { MaxThreads = 25 };
        public static SmartThreadPool Instance()
        {
            return Pool;
        }
    }
}
