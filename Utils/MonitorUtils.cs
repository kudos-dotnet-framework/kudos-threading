using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kudos.Threading.Utils
{
    public static class MonitorUtils
    {
        private static readonly Int32 __it = Timeout.Infinite;

        public static Boolean TryEnter(Object? o) { return TryEnter(o, __it); }
        public static Boolean TryEnter(Object? o, int iTimeout)
        {
            if (o != null && iTimeout > -2)
                try { return Monitor.TryEnter(o, iTimeout); } catch { }

            return false;
        }

        public static void Enter(Object? o) { if (o != null) try { Monitor.Enter(o); } catch { } }
        public static void Exit(Object? o) { if(o != null) try { Monitor.Exit(o); } catch { } }
    }
}