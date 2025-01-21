using System;
using System.Threading;
using System.Threading.Tasks;
using Kudos.Coring.Types;
using Kudos.Threading.Types;

namespace Kudos.Threading.Constants
{
	public static class CType
	{
		public static readonly Type
            Thread = fastTypeOf<Thread>.Value,
            Task = fastTypeOf<Task>.Value,
			Semaphore = fastTypeOf<Semaphore>.Value,
			SemaphoreSlim = fastTypeOf<SemaphoreSlim>.Value,
			MonitorizedObject = fastTypeOf<MonitorizedObject>.Value,
			SemaphorizedObject = fastTypeOf<SemaphorizedObject>.Value;
	}
}