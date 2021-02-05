using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDVILibDI03.Classes
{
    public class SizeClickedEventArgs : EventArgs
    {
        private string toSend;
        
        public SizeClickedEventArgs(int id)
        {
            toSend = id.ToString();
        }

        public string getId { get { return toSend;  } }
    }
}
