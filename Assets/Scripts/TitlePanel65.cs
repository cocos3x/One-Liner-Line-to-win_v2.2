using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class TitlePanel65 : PUIBase
{
	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public TitlePanel65 _003C_003E4__this;

		public float _timer;

		public float _pause;

		public TweenCallback _003C_003E9__16;

		public TweenCallback _003C_003E9__19;

		public TweenCallback _003C_003E9__22;

		internal void _003CFly_003Eb__0()
		{
		}

		internal void _003CFly_003Eb__16()
		{
		}

		internal void _003CFly_003Eb__5()
		{
		}

		internal void _003CFly_003Eb__19()
		{
		}

		internal void _003CFly_003Eb__10()
		{
		}

		internal void _003CFly_003Eb__13()
		{
		}

		internal void _003CFly_003Eb__22()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass51_1
	{
		public double _curValue;

		public double _targetValue;

		public float _curValue2;

		public int _i;

		public _003C_003Ec__DisplayClass51_0 CS_0024_003C_003E8__locals1;

		internal double _003CFly_003Eb__1()
		{
			return 0.0;
		}

		internal void _003CFly_003Eb__2(double x)
		{
		}

		internal void _003CFly_003Eb__3()
		{
		}

		internal void _003CFly_003Eb__4()
		{
		}

		internal float _003CFly_003Eb__6()
		{
			return 0f;
		}

		internal void _003CFly_003Eb__7(float x)
		{
		}

		internal void _003CFly_003Eb__8()
		{
		}

		internal void _003CFly_003Eb__9()
		{
		}

		internal int _003CFly_003Eb__11()
		{
			return 0;
		}

		internal void _003CFly_003Eb__12(int x)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass51_2
	{
		public int _n;

		internal int _003CFly_003Eb__14()
		{
			return 0;
		}

		internal void _003CFly_003Eb__15(int x)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass51_3
	{
		public int _n;

		internal int _003CFly_003Eb__17()
		{
			return 0;
		}

		internal void _003CFly_003Eb__18(int x)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass51_4
	{
		public int _n;

		internal int _003CFly_003Eb__20()
		{
			return 0;
		}

		internal void _003CFly_003Eb__21(int x)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public Action _action;

		internal void _003CReturn_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass64_0
	{
		public TitlePanel65 _003C_003E4__this;

		public int _originValue;

		public TweenCallback _003C_003E9__7;

		public TweenCallback _003C_003E9__6;

		internal Vector3 _003CBoxPlan2_003Eb__0()
		{
			return (Vector3)null;
		}

		internal void _003CBoxPlan2_003Eb__1(Vector3 x)
		{
		}

		internal int _003CBoxPlan2_003Eb__2()
		{
			return 0;
		}

		internal void _003CBoxPlan2_003Eb__3(int x)
		{
		}

		internal void _003CBoxPlan2_003Eb__4()
		{
		}

		internal void _003CBoxPlan2_003Eb__5()
		{
		}

		internal void _003CBoxPlan2_003Eb__6()
		{
		}

		internal void _003CBoxPlan2_003Eb__7()
		{
		}
	}

	private sealed class _003CBoxPlan2_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TitlePanel65 _003C_003E4__this;

		private _003C_003Ec__DisplayClass64_0 _003C_003E8__1;

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
		public _003CBoxPlan2_003Ed__64(int _003C_003E1__state)
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__65_0;

		public static Action _003C_003E9__65_1;

		internal void _003CWin_003Eb__65_0()
		{
		}

		internal void _003CWin_003Eb__65_1()
		{
		}
	}

	public Button settingBtn;

	public Button cardBtn;

	public Transform amazonFlyTarget;

	public Button moneyBtn;

	public Transform moneyFlyTarget;

	public Button cashOutBtn;

	public GameObject cashOutObj;

	public Button prizeCenterBtn;

	public Transform debrisFlyTarget;

	public Text titleText;

	public GameObject startPanel;

	public GameObject gamePanel;

	public Button tipBtn;

	public GameObject returnObj;

	public GameObject gameObj;

	public Button returnBtn;

	public Transform moneyAmazonReturnPar;

	public Transform debrisReturnPar;

	public Button awardExplainBtn;

	public Transform bg;

	public ParticleSystem moneyEffect;

	public ParticleSystem amazonEffect;

	public Transform skinLight;

	public Transform diamondLight;

	public Transform skinPra;

	public Transform startTextTra;

	public GameObject firstGuidance;

	public Transform guidanceFinger;

	public RectTransform boxPlanRect;

	public Text boxPlanText;

	public GameObject boxBarEntirety;

	public Transform boxTra;

	public List<Transform> keys;

	public GameObject keysBoard;

	public RectTransform layout;

	private int m_skinIndex;

	private bool m_netGainSwitch;

	private int m_plan;

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

	private void Init()
	{
	}

	private void Adaptive()
	{
	}

	private void SetMode()
	{
	}

	private void SetTitle()
	{
	}

	private void SetTopPanelValue()
	{
	}

	private void Tip()
	{
	}

	private void TipBlock(TipRange _tipRange)
	{
	}

	private void Setting()
	{
	}

	private void Money()
	{
	}

	private void Amazon()
	{
	}

	private void CashExplain()
	{
	}

	private void Collection()
	{
	}

	private void Fly(FlyObj flyObj, float _value, PiecesSkin65.PiecesInfo piecesInfo, float _timer = 0.3f, float _pause = 0f, bool _isBuryPoint = true)
	{
	}

	private void Return(BtnType btnType, [Optional] Action _action)
	{
	}

	private void CutEffect()
	{
	}

	private void CutPrizeCenter()
	{
	}

	private void CutCashOut()
	{
	}

	private void StartTextAni()
	{
	}

	private void AwardExplain()
	{
	}

	private void GameCurrencySwitch(bool boo)
	{
	}

	private void BoxPlanInit()
	{
	}

	public void BoxPlan()
	{
	}

	private IEnumerator BoxPlan2()
	{
		return null;
	}

	private void Win()
	{
	}

	private void KeysInit()
	{
	}

	private void AddKey(object userData)
	{
	}

	private void ShowKey(object userData)
	{
	}

	private void _003CTip_003Eb__44_0()
	{
	}

	private void _003CCutEffect_003Eb__54_0()
	{
	}

	private void _003CCutEffect_003Eb__54_1()
	{
	}

	private void _003CCutEffect_003Eb__54_2()
	{
	}

	private void _003CCutPrizeCenter_003Eb__55_0()
	{
	}

	private void _003CCutCashOut_003Eb__56_0()
	{
	}

	private void _003CStartTextAni_003Eb__57_0()
	{
	}

	private void _003CStartTextAni_003Eb__57_1()
	{
	}
}
