using System;
using System.Threading;
using System.Threading.Tasks;

namespace Kudos.Threading.Utils
{
	public static class SemaphoreUtils
	{
        public static void Wait(SemaphoreSlim? ss) { if(ss != null) try { ss.Wait(); } catch { } }
        public static async Task WaitAsync(SemaphoreSlim? ss) { if (ss != null) try { await ss.WaitAsync(); } catch { } }
        public static Int32? Release(SemaphoreSlim? ss) { if(ss != null) try { return ss.Release(); } catch { } return null; }
        public static void Dispose(SemaphoreSlim? ss) { if (ss != null) try { ss.Dispose(); } catch { } }
    }
}