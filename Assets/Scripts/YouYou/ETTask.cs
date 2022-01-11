using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace YouYou
{
	public class ETTask : ICriticalNotifyCompletion, INotifyCompletion
	{
		[StructLayout(3)]
		private struct _003CInnerCoroutine_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncETVoidMethodBuilder _003C_003Et__builder;

			public ETTask _003C_003E4__this;

			private object _003C_003Eu__1;

			[DebuggerHidden]
			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static readonly Queue<ETTask> queue;

		private bool fromPool;

		private AwaiterStatus state;

		private object callback;

		public static ETTaskCompleted CompletedTask => (ETTaskCompleted)null;

		public bool IsCompleted
		{
			[MethodImpl(256)]
			[DebuggerHidden]
			get
			{
				return false;
			}
		}

		public static ETTask Create(bool fromPool = false)
		{
			return null;
		}

		private void Recycle()
		{
		}

		private ETTask()
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		private ETVoid InnerCoroutine()
		{
			return (ETVoid)null;
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void Coroutine()
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public ETTask GetAwaiter()
		{
			return null;
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void UnsafeOnCompleted(Action action)
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void OnCompleted(Action action)
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void GetResult()
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void SetResult()
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void SetException(Exception e)
		{
		}
	}
	public class ETTask<T> : ICriticalNotifyCompletion, INotifyCompletion
	{
		[StructLayout(3)]
		private struct _003CInnerCoroutine_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncETVoidMethodBuilder _003C_003Et__builder;

			public ETTask<T> _003C_003E4__this;

			private object _003C_003Eu__1;

			[DebuggerHidden]
			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static readonly Queue<ETTask<T>> queue;

		private bool fromPool;

		private AwaiterStatus state;

		private T value;

		private object callback;

		public bool IsCompleted
		{
			[MethodImpl(256)]
			[DebuggerHidden]
			get
			{
				return false;
			}
		}

		public static ETTask<T> Create(bool fromPool = false)
		{
			return null;
		}

		private void Recycle()
		{
		}

		private ETTask()
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		private ETVoid InnerCoroutine()
		{
			return (ETVoid)null;
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void Coroutine()
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public ETTask<T> GetAwaiter()
		{
			return null;
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public T GetResult()
		{
			return (T)null;
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void UnsafeOnCompleted(Action action)
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void OnCompleted(Action action)
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void SetResult(T result)
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void SetException(Exception e)
		{
		}
	}
}
