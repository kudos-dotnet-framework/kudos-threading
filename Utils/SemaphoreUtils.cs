using System;
using System.Threading;
using System.Threading.Tasks;
using Kudos.Coring.Constants;
using Kudos.Coring.Types;

namespace Kudos.Threading.Utils
{
    public static class SemaphoreUtils
    {
        public static Exception? Wait(SemaphoreSlim? ss)
        {
            if (ss == null) return CException.ArgumentNullException;
            try { ss.Wait(); return null; } catch (Exception exc) { return exc; }
        }

        public static async Task<Exception?> WaitAsync(SemaphoreSlim? ss)
        {
            if (ss == null) return CException.ArgumentNullException;
            try { await ss.WaitAsync(); return null; } catch (Exception exc) { return exc; }
        }

        public static SmartResult<Int32?> Release(SemaphoreSlim? ss)
        {
            if (ss != null) 
                try { return new SmartResult<Int32?>(ss.Release()); }
                catch(Exception exc) { return new SmartResult<Int32?>(exc); }

            return SmartResult<Int32?>.ArgumentNullException;
        }

        public static Exception? Dispose(SemaphoreSlim? ss)
        {
            if (ss == null) return CException.ArgumentNullException;
            try { ss.Dispose(); return null; } catch (Exception exc) { return exc; }
        }
    }
}