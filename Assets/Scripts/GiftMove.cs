using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class GiftMove : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler
{
	[StructLayout(3)]
	private struct _003COnPointerEnter_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GiftMove _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	private struct _003COnEnable_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GiftMove _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}
