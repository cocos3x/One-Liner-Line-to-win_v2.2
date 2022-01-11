using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace YouYou
{
	[StructLayout(0, Size = 1)]
	public struct ETTaskCompleted : ICriticalNotifyCompletion, INotifyCompletion
	{
		[DebuggerHidden]
		public bool IsCompleted => false;

		[DebuggerHidden]
		public ETTaskCompleted GetAwaiter()
		{
			return (ETTaskCompleted)null;
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void GetResult()
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void OnCompleted(Action continuation)
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void UnsafeOnCompleted(Action continuation)
		{
		}
	}
}
