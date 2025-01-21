using System;
using System.Threading;
using System.Threading.Tasks;
using Kudos.Coring.Constants;
using Kudos.Coring.Types;

namespace Kudos.Threading.Utils
{
	public static class TaskUtils
	{
        public static SmartResult<V> WaitResult<V>(Task<V>? t) { return WaitResult<V>(t, CancellationToken.None); }
        public static SmartResult<V> WaitResult<V>(Task<V>? t, CancellationToken? ct)
        {
            Exception? exc = Wait(t, ct);

            if (exc == null)
                try { V v = t.Result; return new SmartResult<V>(exc, v); }
                catch (Exception exc0) { exc = exc0; }

            return new SmartResult<V>(exc);
        }

        public static async Task<SmartResult<V>> WaitResultAsync<V>(Task<V>? t) { return await WaitResultAsync<V>(t, CancellationToken.None); }
        public static async Task<SmartResult<V>> WaitResultAsync<V>(Task<V>? t, CancellationToken? ct)
        {
            Exception? exc = await WaitAsync(t, ct);

            if (exc == null)
                try { V v = t.Result; return new SmartResult<V>(exc, v); }
                catch (Exception exc0) { exc = exc0; }

            return new SmartResult<V>(exc);
        }

        public static Exception? Wait(Task? t) { return Wait(t, CancellationToken.None); }
        public static Exception? Wait(Task? t, CancellationToken? ct)
        {
            if (t == null || ct == null) return CException.ArgumentNullException;
            try { t.Wait(ct.Value); return null; } catch (Exception exc) { return exc; }
        }

        public static async Task<Exception?> WaitAsync(Task? t) { return await WaitAsync(t, CancellationToken.None); }
        public static async Task<Exception?> WaitAsync(Task? t, CancellationToken? ct)
		{
            if (t == null || ct == null) return CException.ArgumentNullException;
            try { await t.WaitAsync(ct.Value); return null; } catch (Exception? exc) { return exc; }
		}
    }
}