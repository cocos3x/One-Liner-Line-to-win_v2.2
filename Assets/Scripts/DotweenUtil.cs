using DG.Tweening;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using YouYou;

public static class DotweenUtil
{
	private sealed class _003C_003Ec__DisplayClass0_0<T> where T : Tween
	{
		public ETTask<T> task;

		public T t;

		internal void _003COnComplete_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	private struct _003COnComplete_003Ed__0<T> : IAsyncStateMachine where T : Tween
	{
		public int _003C_003E1__state;

		public ETAsyncTaskMethodBuilder<T> _003C_003Et__builder;

		public T t;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public static ETTask<T> OnComplete<T>(this T t) where T : Tween
	{
		return null;
	}
}
