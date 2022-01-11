using DG.Tweening;
using Spine;
using Spine.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class GiftPanel : PUIBase
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__22_0;

		internal void _003CCloseAni_003Eb__22_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public bool _isAni;

		public GiftPanel _003C_003E4__this;

		public GameObject _moenyFly;

		public int _index;

		public TweenCallback _003C_003E9__0;

		internal void _003CGet2_003Eb__0()
		{
		}
	}

	private sealed class _003CGet2_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GiftPanel _003C_003E4__this;

		private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

		private int _003Cindex_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CGet2_003Ed__27(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[StructLayout(3)]
	private struct _003CGift_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GiftPanel _003C_003E4__this;

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
	private struct _003CGiftAni_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public GiftPanel _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public Image maskImg;

	public Transform content;

	public Button closeBtn;

	public List<Button> getBtn;

	public Text diamondText;

	public GameObject flyMoney;

	public GameObject flowLight;

	public SkeletonGraphic skeleton;

	public ParticleSystem particle;

	private float m_Value;

	private int m_timerLimit;

	private int m_timer;

	private int FreeTimer
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override void OnEnter()
	{
	}

	public override void OnResume()
	{
	}

	public override void OnPause()
	{
	}

	public override void OnExit()
	{
	}

	public override void AddMonitor()
	{
	}

	public override void RemoveMonitor()
	{
	}

	public override void OpenAni()
	{
	}

	public override void CloseAni()
	{
	}

	private void AdaptiveNotchScreen()
	{
	}

	private void Close()
	{
	}

	private void Get()
	{
	}

	private void GetNoAD()
	{
	}

	private IEnumerator Get2()
	{
		return null;
	}

	private void Init(params object[] param)
	{
	}

	public void Gift()
	{
	}

	private void GiftAni(TrackEntry trackEntry)
	{
	}

	private void _003COpenAni_003Eb__21_0()
	{
	}

	private void _003CGet_003Eb__25_0()
	{
	}
}
