using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace YouYou
{
	public static class ETTaskHelperA
	{
		private class CoroutineBlocker
		{
			

			private int count;

			private List<ETTask> tcss;

			public CoroutineBlocker(int count)
			{
			}

			public ETTask WaitAsync()
			{
				return null;
			}
		}

	
	
	
		private sealed class _003C_003Ec__DisplayClass3_0<T>
		{
		
			public CoroutineBlocker coroutineBlocker;

			
		}

		
		
	


		public static ETTask<bool> WaitAny<T>(ETTask<T>[] tasks, [Optional] ETCancellationToken cancellationToken)
		{
			return null;
		}

		public static ETTask<bool> WaitAny(ETTask[] tasks, [Optional] ETCancellationToken cancellationToken)
		{
			return null;
		}

		public static ETTask<bool> WaitAll<T>(ETTask<T>[] tasks, [Optional] ETCancellationToken cancellationToken)
		{
			return null;
		}

		public static ETTask<bool> WaitAll<T>(List<ETTask<T>> tasks, [Optional] ETCancellationToken cancellationToken)
		{
			return null;
		}

		public static ETTask<bool> WaitAll(ETTask[] tasks, [Optional] ETCancellationToken cancellationToken)
		{
			return null;
		}

		public static ETTask<bool> WaitAll(List<ETTask> tasks, [Optional] ETCancellationToken cancellationToken)
		{
			return null;
		}
	}
}
