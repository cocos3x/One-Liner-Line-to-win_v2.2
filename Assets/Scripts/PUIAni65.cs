using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class PUIAni65 : MonoBehaviour
{
	[StructLayout(3)]
	private struct _003COpenAni1_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Transform _content;

		public Button _close;

		public Image _mask;

		public Action _action;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public Button _close;

		internal void _003CCloseAni1_003Eb__0()
		{
		}
	}

	[StructLayout(3)]
	private struct _003CCloseAni1_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Button _close;

		public float _timer1;

		public Image _mask;

		public float _timer2;

		public Transform _content;

		public Action _action;

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
	private struct _003COpenAni2_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Transform _content;

		public Action _action;

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
		public CanvasGroup canvasGroup;

		internal float _003CCloseAni2_003Eb__0()
		{
			return 0f;
		}

		internal void _003CCloseAni2_003Eb__1(float x)
		{
		}
	}

	[StructLayout(3)]
	private struct _003CCloseAni2_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public CanvasGroup canvasGroup;

		public Action _action;

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
	private struct _003COpenAni3_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Transform _content;

		public GameObject roll;

		public Button doubleBtn;

		public Button nothanksBtn;

		public Image _mask;

		public Action _action;

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
	private struct _003COpenAni3_2_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Transform _content;

		public GameObject roll;

		public Button doubleBtn;

		public Button nothanksBtn;

		public Image _mask;

		public Button claimBtn;

		public Action _action;

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
	private struct _003CCloseAni3_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Image _mask;

		public GameObject roll;

		public Button doubleBtn;

		public Button nothanksBtn;

		public Transform _content;

		public Action _action;

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
	private struct _003COpenAni4_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Transform _content;

		public Button getBtn;

		public Image _mask;

		public Action _action;

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
	private struct _003CCloseAni4_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Image _mask;

		public Button doubleBtn;

		public Transform _content;

		public Action _action;

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
	private struct _003COpenAni5_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Image _mask;

		public Transform _content;

		public Action _action;

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
	private struct _003COpenAni6_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public Image _mask;

		public Action _action;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public static PUIAni65 Instance;

	private void Awake()
	{
	}

	public void OpenAni1(Image _mask, Button _close, Transform _content, [Optional] Action _action)
	{
	}

	public void CloseAni1(Image _mask, Button _close, Transform _content, Action _action, float _timer1 = 0.3f, float _timer2 = 0.4f)
	{
	}

	public void OpenAni2(Transform _content, Action _action)
	{
	}

	public void CloseAni2(CanvasGroup canvasGroup, Action _action)
	{
	}

	public void OpenAni3(Transform _content, Image _mask, GameObject roll, Button doubleBtn, Button nothanksBtn, Action _action)
	{
	}

	public void OpenAni3_2(Transform _content, Image _mask, GameObject roll, Button doubleBtn, Button nothanksBtn, Button claimBtn, Action _action)
	{
	}

	public void CloseAni3(Transform _content, Image _mask, GameObject roll, Button doubleBtn, Button nothanksBtn, Action _action)
	{
	}

	public void OpenAni4(Transform _content, Image _mask, Button getBtn, [Optional] Action _action)
	{
	}

	public void CloseAni4(Transform _content, Image _mask, Button doubleBtn, Action _action)
	{
	}

	public void OpenAni5(Image _mask, Transform _content, Action _action)
	{
	}

	public void OpenAni6(Image _mask, Action _action)
	{
	}
}
