using System;
using Kudos.Coring.Types;
using Kudos.Threading.Utils;

namespace Kudos.Threading.Types
{
    public sealed class SmartMonitor
    {
        private readonly Object _lck;

        public SmartMonitor() { _lck = new object(); }

        public SmartResult<Boolean?> TryEnterMonitor() { return MonitorUtils.TryEnter(_lck); }
        public SmartResult<Boolean?> TryEnterMonitor(int iTimeout) { return MonitorUtils.TryEnter(_lck, iTimeout); }
        public Exception? EnterMonitor() { return MonitorUtils.Enter(_lck); }
        public Exception? ExitMonitor() { return MonitorUtils.Exit(_lck); }

    }
}