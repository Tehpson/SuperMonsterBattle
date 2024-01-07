using System;
using System.Collections.Generic;
using System.Text;

namespace AngeredSimulator.Logic
{
    internal class StoreManager
    {
        public DateTime NextUpdate { get; internal set; }

        internal void UpdateStore()
        {
            Manager.state = State.Menu;
        }

        internal void VisitStore()
        {
            Manager.state = State.Menu;

        }
    }
}
