using System.Threading;
using System;
using System.Threading.Tasks;

namespace PixelatedUtilities.Threading
{
    static public class Threading
    {
        static void Test()
        {

        }
        static public Task WaitToExecute(int ms)
        {
            Thread.Sleep(ms);
            return Task.CompletedTask;
        }
    }
}