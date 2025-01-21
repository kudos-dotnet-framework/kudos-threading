using System;
using Kudos.Threading.Utils;
using System.Threading;
using System.Threading.Tasks;
using Kudos.Coring.Types;

namespace Kudos.Threading.Types
{
    public class SemaphorizedObject
    {
        private readonly SemaphoreSlim _ss;

        public SemaphorizedObject() : this(1) { }
        public SemaphorizedObject(Int32 iInitialCount) : this(iInitialCount, iInitialCount) { }
        public SemaphorizedObject(Int32 iInitialCount, Int32 iMaxCount) { _ss = new SemaphoreSlim(iInitialCount, iMaxCount); }

        protected Exception? _WaitSemaphore() { return SemaphoreUtils.Wait(_ss); }
        protected async Task<Exception?> _WaitSemaphoreAsync() { return await SemaphoreUtils.WaitAsync(_ss); }
        protected SmartResult<Int32?> _ReleaseSemaphore() { return SemaphoreUtils.Release(_ss); }
    }
}