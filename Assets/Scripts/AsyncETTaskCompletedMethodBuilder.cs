using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace YouYou
{
	
	public struct AsyncETTaskCompletedMethodBuilder
	{
	
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
