using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BusinessLayer.Events
{
    public class BestelEventArgs : EventArgs
    {
        public string Klant { get; set; }
        public string Product { get; set; }
    }
}
