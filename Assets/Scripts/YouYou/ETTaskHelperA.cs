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
			[StructLayout(3)]
			private struct _003CWaitAsync_003Ed__3 : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public ETAsyncTaskMethodBuilder _003C_003Et__builder;

				public CoroutineBlocker _003C_003E4__this;

				private object _003C_003Eu__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

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

		private sealed class _003C_003Ec__DisplayClass1_0<T>
		{
			[StructLayout(3)]
			private struct _003C_003CWaitAny_003Eg__RunOneTask_007C0_003Ed : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncETVoidMethodBuilder _003C_003Et__builder;

				public ETTask<T> task;

				public _003C_003Ec__DisplayClass1_0<T> _003C_003E4__this;

				private object _003C_003Eu__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			public CoroutineBlocker coroutineBlocker;

			internal ETVoid _003CWaitAny_003Eg__RunOneTask_007C0(ETTask<T> task)
			{
				return (ETVoid)null;
			}
		}

		[StructLayout(3)]
		private struct _003CWaitAny_003Ed__1<T> : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public ETAsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public ETTask<T>[] tasks;

			public ETCancellationToken cancellationToken;

			private object _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass2_0
		{
			[StructLayout(3)]
			private struct _003C_003CWaitAny_003Eg__RunOneTask_007C0_003Ed : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncETVoidMethodBuilder _003C_003Et__builder;

				public ETTask task;

				public _003C_003Ec__DisplayClass2_0 _003C_003E4__this;

				private object _003C_003Eu__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			public CoroutineBlocker coroutineBlocker;

			internal ETVoid _003CWaitAny_003Eg__RunOneTask_007C0(ETTask task)
			{
				return (ETVoid)null;
			}
		}

		[StructLayout(3)]
		private struct _003CWaitAny_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public ETAsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public ETTask[] tasks;

			public ETCancellationToken cancellationToken;

			private object _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass3_0<T>
		{
			[StructLayout(3)]
			private struct _003C_003CWaitAll_003Eg__RunOneTask_007C0_003Ed : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncETVoidMethodBuilder _003C_003Et__builder;

				public ETTask<T> task;

				public _003C_003Ec__DisplayClass3_0<T> _003C_003E4__this;

				private object _003C_003Eu__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			public CoroutineBlocker coroutineBlocker;

			internal ETVoid _003CWaitAll_003Eg__RunOneTask_007C0(ETTask<T> task)
			{
				return (ETVoid)null;
			}
		}

		[StructLayout(3)]
		private struct _003CWaitAll_003Ed__3<T> : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public ETAsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public ETTask<T>[] tasks;

			public ETCancellationToken cancellationToken;

			private object _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass4_0<T>
		{
			[StructLayout(3)]
			private struct _003C_003CWaitAll_003Eg__RunOneTask_007C0_003Ed : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncETVoidMethodBuilder _003C_003Et__builder;

				public ETTask<T> task;

				public _003C_003Ec__DisplayClass4_0<T> _003C_003E4__this;

				private object _003C_003Eu__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			public CoroutineBlocker coroutineBlocker;

			internal ETVoid _003CWaitAll_003Eg__RunOneTask_007C0(ETTask<T> task)
			{
				return (ETVoid)null;
			}
		}

		[StructLayout(3)]
		private struct _003CWaitAll_003Ed__4<T> : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public ETAsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public List<ETTask<T>> tasks;

			public ETCancellationToken cancellationToken;

			private object _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass5_0
		{
			[StructLayout(3)]
			private struct _003C_003CWaitAll_003Eg__RunOneTask_007C0_003Ed : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncETVoidMethodBuilder _003C_003Et__builder;

				public ETTask task;

				public _003C_003Ec__DisplayClass5_0 _003C_003E4__this;

				private object _003C_003Eu__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			public CoroutineBlocker coroutineBlocker;

			internal ETVoid _003CWaitAll_003Eg__RunOneTask_007C0(ETTask task)
			{
				return (ETVoid)null;
			}
		}

		[StructLayout(3)]
		private struct _003CWaitAll_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public ETAsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public ETTask[] tasks;

			public ETCancellationToken cancellationToken;

			private object _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass6_0
		{
			[StructLayout(3)]
			private struct _003C_003CWaitAll_003Eg__RunOneTask_007C0_003Ed : IAsyncStateMachine
			{
				public int _003C_003E1__state;

				public AsyncETVoidMethodBuilder _003C_003Et__builder;

				public ETTask task;

				public _003C_003Ec__DisplayClass6_0 _003C_003E4__this;

				private object _003C_003Eu__1;

				private void MoveNext()
				{
				}

				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			public CoroutineBlocker coroutineBlocker;

			internal ETVoid _003CWaitAll_003Eg__RunOneTask_007C0(ETTask task)
			{
				return (ETVoid)null;
			}
		}

		[StructLayout(3)]
		private struct _003CWaitAll_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public ETAsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			public List<ETTask> tasks;

			public ETCancellationToken cancellationToken;

			private object _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
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
