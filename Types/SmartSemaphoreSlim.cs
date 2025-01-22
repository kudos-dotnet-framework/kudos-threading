using System;
using Kudos.Threading.Utils;
using System.Threading;
using System.Threading.Tasks;
using Kudos.Coring.Types;

namespace Kudos.Threading.Types
{
    public sealed class SmartSemaphoreSlim : IDisposable
    {
        private readonly SemaphoreSlim _ss;

        public SmartSemaphoreSlim() : this(1) { }
        public SmartSemaphoreSlim(Int32 iInitialCount) : this(iInitialCount, iInitialCount) { }
        public SmartSemaphoreSlim(Int32 iInitialCount, Int32 iMaxCount) { _ss = new SemaphoreSlim(iInitialCount, iMaxCount); }

        public Exception? WaitSemaphore() { return SemaphoreUtils.Wait(_ss); }
        public async Task<Exception?> WaitSemaphoreAsync() { return await SemaphoreUtils.WaitAsync(_ss); }
        public SmartResult<Int32?> ReleaseSemaphore() { return SemaphoreUtils.Release(_ss); }

        public void Dispose()
        {
            SemaphoreUtils.Dispose(_ss);
        }
    }
}