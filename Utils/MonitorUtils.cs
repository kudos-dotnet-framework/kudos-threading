using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Kudos.Coring.Constants;
using Kudos.Coring.Types;

namespace Kudos.Threading.Utils
{
    public static class MonitorUtils
    {
        private static readonly Int32 __it = Timeout.Infinite;

        public static SmartResult<Boolean?> TryEnter(Object? o) { return TryEnter(o, __it); }
        public static SmartResult<Boolean?> TryEnter(Object? o, int iTimeout)
        {
            if (o == null) return SmartResult<Boolean?>.ArgumentNullException;
            else if (iTimeout < -1) return SmartResult<Boolean?>.ArgumentOutOfRangeException;
            try { return new SmartResult<Boolean?>(Monitor.TryEnter(o, iTimeout)); }
            catch (Exception exc) { return new SmartResult<Boolean?>(exc); }
        }

        public static Exception? Enter(Object? o)
        {
            if (o == null) return CException.ArgumentNullException;
            try { Monitor.Enter(o); return null; } catch (Exception exc) { return exc; }
        }

        public static Exception? Exit(Object? o)
        {
            if (o == null) return CException.ArgumentNullException;
            try { Monitor.Exit(o); return null; } catch (Exception exc) { return exc; }
        }
    }
}