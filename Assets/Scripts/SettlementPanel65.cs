using DG.Tweening;
using Spine.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class SettlementPanel65 : PUIBase
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__37_0;

		public static Action _003C_003E9__37_1;

		public static Action _003C_003E9__37_2;

		public static Action _003C_003E9__38_0;

		public static TweenCallback _003C_003E9__56_2;

		internal void _003COpenAni_003Eb__37_0()
		{
		}

		internal void _003COpenAni_003Eb__37_1()
		{
		}

		internal void _003COpenAni_003Eb__37_2()
		{
		}

		internal void _003CCloseAni_003Eb__38_0()
		{
		}

		internal void _003CDoubleEvent_003Eb__56_2()
		{
		}
	}

	[StructLayout(3)]
	private struct _003CMode2_003Ed__55 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SettlementPanel65 _003C_003E4__this;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public SettlementPanel65 _003C_003E4__this;

		public int _ran;

		public CallBack callBack;

		internal Rect _003CDoubleEvent_003Eb__0()
		{
			return (Rect)null;
		}

		internal void _003CDoubleEvent_003Eb__1(Rect x)
		{
		}

		internal void _003CDoubleEvent_003Eb__3()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass59_0
	{
		public float _curValue;

		public SettlementPanel65 _003C_003E4__this;

		internal float _003CGetMoney_003Eb__0()
		{
			return 0f;
		}

		internal void _003CGetMoney_003Eb__1(float x)
		{
		}

		internal void _003CGetMoney_003Eb__2()
		{
		}

		internal void _003CGetMoney_003Eb__3()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public bool _isAni;

		public SettlementPanel65 _003C_003E4__this;

		public GameObject _moenyFly;

		public int _index;

		public TweenCallback _003C_003E9__0;

		internal void _003CFlyMoney_003Eb__0()
		{
		}
	}

	private sealed class _003CFlyMoney_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SettlementPanel65 _003C_003E4__this;

		private _003C_003Ec__DisplayClass60_0 _003C_003E8__1;

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
		public _003CFlyMoney_003Ed__60(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass61_0
	{
		public SettlementPanel65 _003C_003E4__this;

		public int _originValue;

		internal Vector3 _003CBoxPlan_003Eb__0()
		{
			return (Vector3)null;
		}

		internal void _003CBoxPlan_003Eb__1(Vector3 x)
		{
		}

		internal int _003CBoxPlan_003Eb__2()
		{
			return 0;
		}

		internal void _003CBoxPlan_003Eb__3(int x)
		{
		}

		internal void _003CBoxPlan_003Eb__4()
		{
		}
	}

	private sealed class _003CBoxPlan_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SettlementPanel65 _003C_003E4__this;

		private _003C_003Ec__DisplayClass61_0 _003C_003E8__1;

		private float _003C_dest_003E5__2;

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
		public _003CBoxPlan_003Ed__61(int _003C_003E1__state)
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
	private struct _003C_003CMode2_003Eb__55_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public SettlementPanel65 _003C_003E4__this;

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

	public Transform contentTra;

	public Transform rotateLight;

	private float showTime;

	public Transform billParent;

	public RectTransform boxPlanRect;

	public Text boxPlanText;

	public GameObject boxBarEntirety;

	public RawImage rollBar;

	public Sprite[] specialMutis;

	public Image specialImg;

	public GameObject machineObj;

	public Transform moneyTra;

	public Transform flyEffect;

	public GameObject flyMoney;

	public SkeletonGraphic boxSpine;

	public GameObject[] getMode;

	private float m_addBill;

	private bool m_isAccounts;

	private bool m_close;

	private int m_plan;

	public Button doubleBtn;

	public Button doubleNoADBtn;

	public Button noThanksBtn;

	public Button claimBtn;

	public Button doubleBtn2;

	public Button doubleNoADBtn2;

	public Button getBtn2;

	public Text text;

	public RectTransform multi;

	private bool m_mode;

	private List<float> m_mults;

	private float m_zeroPosIndex;

	private int m_turns;

	private float m_mult;

	private float m_addNum;

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

	private void Init(params object[] param)
	{
	}

	private void DataDeal()
	{
	}

	private void RotateLight()
	{
	}

	private void ShakeBtn()
	{
	}

	private void Double()
	{
	}

	private void Double2()
	{
	}

	private void DoubleNoAD()
	{
	}

	private void DoubleNoAD2()
	{
	}

	private void NoThanks()
	{
	}

	private void Mode1()
	{
	}

	private void Mode2()
	{
	}

	private void DoubleEvent(int _ran, CallBack callBack)
	{
	}

	private void Next()
	{
	}

	private void GetMoney(bool isAni = false, [Optional] CallBack callBack)
	{
	}

	private IEnumerator FlyMoney()
	{
		return null;
	}

	private IEnumerator BoxPlan()
	{
		return null;
	}

	private void Claim()
	{
	}

	private void _003CRotateLight_003Eb__43_0()
	{
	}

	private void _003CShakeBtn_003Eb__44_0()
	{
	}

	private void _003CShakeBtn_003Eb__44_1()
	{
	}

	private void _003CDouble_003Eb__48_0()
	{
	}

	private void _003CDouble2_003Eb__49_0()
	{
	}

	private void _003CDouble2_003Eb__49_1()
	{
	}

	private void _003CDoubleNoAD2_003Eb__51_0()
	{
	}

	private void _003CNoThanks_003Eb__53_0()
	{
	}

	private void _003CNoThanks_003Eb__53_2()
	{
	}

	private void _003CNoThanks_003Eb__53_1()
	{
	}

	private void _003CNoThanks_003Eb__53_3()
	{
	}

	private void _003CMode1_003Eb__54_0()
	{
	}

	private void _003CMode1_003Eb__54_1()
	{
	}

	private void _003CMode2_003Eb__55_0()
	{
	}
}
