using System;

namespace FuyumiBot
{
    class Program
    {
        static void Main(string[] args)
        {
            var bot = new FuyumiBot();
            bot.RunAsync().GetAwaiter().GetResult();
        }
    }
}
