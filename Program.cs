using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatepart
{
    class Program
    {
        static void Main(string[] args)
        {
            Agent agent = new Agent();
            agent.newInfoEvent += new NewInfoEventHandler(MikeFamily);
            agent.newInfoEvent += new NewInfoEventHandler(TomFamily);
            agent.newInfoEvent += new NewInfoEventHandler(YancyFamily);

            agent.startWork("New information!!");
        }

        public static void MikeFamily(NewInfoEventArgs e)
        {
            Console.WriteLine("Mike got " + e._newInfo);
        }

        public static void TomFamily(NewInfoEventArgs e)
        {
            Console.WriteLine("Tom got " + e._newInfo);
        }

        public static void YancyFamily(NewInfoEventArgs e)
        {
            Console.WriteLine("Yancy got " + e._newInfo);
        }
    }
}
