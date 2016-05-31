using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatepart
{
    delegate void NewInfoEventHandler(NewInfoEventArgs e);
    class Agent
    {
        public event NewInfoEventHandler newInfoEvent;

        public void startWork(string newInfo)
        {
            NewInfoEventArgs e = new NewInfoEventArgs();
            e._newInfo = newInfo;

            onNewInfo(e);
        }
        protected virtual void onNewInfo(NewInfoEventArgs e)
        {
            if (newInfoEvent != null)
            {
                newInfoEvent(e);
            }
        }
    }
    class NewInfoEventArgs : EventArgs
    {
        public string _newInfo;
    }
}
