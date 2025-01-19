using System;
using System.Threading;
using Kudos.Threading.Types;

namespace Kudos.Threading.Constants
{
	public static class CType
	{
		public static readonly Type
			Semaphore = typeof(Semaphore),
			SemaphoreSlim = typeof(SemaphoreSlim),
			MonitorizedObject = typeof(MonitorizedObject),
			SemaphorizedObject = typeof(SemaphorizedObject);
	}
}

