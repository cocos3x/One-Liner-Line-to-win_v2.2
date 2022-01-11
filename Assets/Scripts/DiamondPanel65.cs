using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class DiamondPanel65 : PUIBase
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__33_0;

		internal void _003CCloseAni_003Eb__33_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public GameObject _obj;

		public Vector2 _vec;

		public TweenCallback _003C_003E9__1;

		internal void _003CInsufficientTip_003Eb__0()
		{
		}

		internal void _003CInsufficientTip_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public int product;

		public int expend;

		public DiamondPanel65 _003C_003E4__this;
	}

	private sealed class _003C_003Ec__DisplayClass41_1
	{
		public bool _isAni;

		public GameObject _moenyFly;

		public int _index;

		public _003C_003Ec__DisplayClass41_0 CS_0024_003C_003E8__locals1;

		public TweenCallback _003C_003E9__0;

		internal void _003CProductFly2_003Eb__0()
		{
		}
	}


	private sealed class _003C_003Ec__DisplayClass42_0
	{
		public DiamondPanel65 _003C_003E4__this;

		public float _timer;

		internal void _003CRoll_003Eb__0()
		{
		}

		internal void _003CRoll_003Eb__5()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass42_1
	{
		public float _curValue;

		public float _curValue2;

		public _003C_003Ec__DisplayClass42_0 CS_0024_003C_003E8__locals1;

		internal float _003CRoll_003Eb__1()
		{
			return 0f;
		}

		internal void _003CRoll_003Eb__2(float x)
		{
		}

		internal void _003CRoll_003Eb__3()
		{
		}

		internal void _003CRoll_003Eb__4()
		{
		}

		internal float _003CRoll_003Eb__6()
		{
			return 0f;
		}

		internal void _003CRoll_003Eb__7(float x)
		{
		}

		internal void _003CRoll_003Eb__8()
		{
		}

		internal void _003CRoll_003Eb__9()
		{
		}
	}

	public Image maskImg;

	public Button closeBtn;

	public Transform contentTra;

	public Button helpBtn;

	private CanvasGroup canvasGroup;

	public List<Button> mainBtn;

	public Transform titleBtnTra;

	public Transform moveTra;

	public Text coinText;

	public Text diamondText;

	public Transform tipTra;

	public GameObject diamondTip;

	public GameObject coinTip;

	public GameObject levelTip;

	public GameObject diamondPrefab;

	public List<GameObject> guidanceStep;

	public List<Button> guidanceProcess;

	public List<Transform> guidanceProcessWhite;

	public Transform guidanceWhite;

	public Transform guidanceFinger;

	private List<Sprite> topBgSprites;

	public Image topBGImg;

	public GameObject bgEffect;

	public List<Transform> ordersPos;

	public GameObject orderPre;

	public LocalizationRepair localizationRepair;

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

	private void Init(params object[] param)
	{
	}

	private void DataDeal()
	{
	}

	private void Explain()
	{
	}

	private void MainBtn()
	{
	}

	private void InsufficientTip(InsufficientType insufficientType)
	{
	}

	private void ProductFly(InsufficientType insufficientType, Transform originTra, int expend, int product)
	{
	}

	private IEnumerator ProductFly2(InsufficientType insufficientType, Transform originTra, int expend, int product)
	{
		return null;
	}

	private void Roll(FlyObj flyObj, float _value, float _timer = 0.3f, float _pause = 0f)
	{
	}

	private void Guidance0()
	{
	}

	private void Guidance1()
	{
	}

	private void Guidance2()
	{
	}

	private void Guidance3()
	{
	}

	private void Guidance4()
	{
	}

	private void Guidance5()
	{
	}

	private void OrderInit()
	{
	}

	private void CreateItem(int _index, int _orderIndex)
	{
	}

	private void SetSprites()
	{
	}

	private void _003COpenAni_003Eb__32_0()
	{
	}
}
