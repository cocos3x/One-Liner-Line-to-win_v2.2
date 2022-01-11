using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace YouYou
{
	[StructLayout(0, Size = 1)]
	public struct AsyncETVoidMethodBuilder
	{
		[DebuggerHidden]
		public ETVoid Task => (ETVoid)null;

		[MethodImpl(256)]
		[DebuggerHidden]
		public static AsyncETVoidMethodBuilder Create()
		{
			return (AsyncETVoidMethodBuilder)null;
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void SetException(Exception exception)
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void SetResult()
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}
}
