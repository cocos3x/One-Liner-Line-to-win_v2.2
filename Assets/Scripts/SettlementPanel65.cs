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

	
	private void Next()
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
