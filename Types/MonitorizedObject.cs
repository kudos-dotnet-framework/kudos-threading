using System;
using Kudos.Threading.Utils;

namespace Kudos.Threading.Types
{
    public class MonitorizedObject
    {
        private readonly Object _lck;

        public MonitorizedObject() { _lck = new object(); }

        protected Boolean _TryEnterMonitor() { return MonitorUtils.TryEnter(_lck); }
        protected Boolean _TryEnterMonitor(int iTimeout) { return MonitorUtils.TryEnter(_lck, iTimeout); }
        protected void _EnterMonitor() { MonitorUtils.Enter(_lck); }
        protected void _ExitMonitor() { MonitorUtils.Exit(_lck); }
    }
}