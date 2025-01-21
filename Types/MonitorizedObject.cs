using System;
using Kudos.Coring.Types;
using Kudos.Threading.Utils;

namespace Kudos.Threading.Types
{
    public class MonitorizedObject
    {
        private readonly Object _lck;

        public MonitorizedObject() { _lck = new object(); }

        protected SmartResult<Boolean?> _TryEnterMonitor() { return MonitorUtils.TryEnter(_lck); }
        protected SmartResult<Boolean?> _TryEnterMonitor(int iTimeout) { return MonitorUtils.TryEnter(_lck, iTimeout); }
        protected Exception? _EnterMonitor() { return MonitorUtils.Enter(_lck); }
        protected Exception? _ExitMonitor() { return MonitorUtils.Exit(_lck); }
    }
}