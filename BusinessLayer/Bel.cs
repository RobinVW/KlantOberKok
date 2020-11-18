using BusinessLayer.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Bel
    {
        public event EventHandler<BestelEventArgs> RingEvent;

        public void Ring(BestelEventArgs args)
        {
            RingEvent?.Invoke(this, args);
        }
    }
}
