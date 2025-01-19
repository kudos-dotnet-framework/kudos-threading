using System;
using Kudos.Threading.Utils;
using System.Threading;
using System.Threading.Tasks;

namespace Kudos.Threading.Types
{
    public class SemaphorizedObject
    {
        private readonly SemaphoreSlim _ss;

        public SemaphorizedObject() : this(1) { }
        public SemaphorizedObject(Int32 iInitialCount) : this(iInitialCount, iInitialCount) { }
        public SemaphorizedObject(Int32 iInitialCount, Int32 iMaxCount) { _ss = new SemaphoreSlim(iInitialCount, iMaxCount); }

        protected void _WaitSemaphore() { SemaphoreUtils.Wait(_ss); }
        protected async Task _WaitSemaphoreAsync() { await SemaphoreUtils.WaitAsync(_ss); }
        protected Int32? _ReleaseSemaphore() { return SemaphoreUtils.Release(_ss); }
    }
}