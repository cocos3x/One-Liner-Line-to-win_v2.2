using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace YouYou
{
	public struct ETAsyncTaskMethodBuilder
	{
		private ETTask tcs;

		[DebuggerHidden]
		public ETTask Task => null;

	

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
	public struct ETAsyncTaskMethodBuilder<T>
	{
		private ETTask<T> tcs;

		[DebuggerHidden]
		public ETTask<T> Task => null;

		[MethodImpl(256)]
		[DebuggerHidden]
	
		public void SetException(Exception exception)
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void SetResult(T ret)
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
