using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace YouYou
{
	
	public struct ETVoid : ICriticalNotifyCompletion, INotifyCompletion
	{
		[DebuggerHidden]
		public bool IsCompleted => false;

		[DebuggerHidden]
		public void Coroutine()
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
