using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDVILibDI03.Classes
{
    public class DarkModeChangedEventArgs : EventArgs
    {
        private bool toSend;

        public DarkModeChangedEventArgs(bool dark)
        {
            toSend = dark;
        }

        public bool getDarkMode { get { return toSend; } }
    }
}
