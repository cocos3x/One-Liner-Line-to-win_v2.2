using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class GetAllPanel65 : PUIBase
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


	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public GetAllPanel65 _003C_003E4__this;

		public int _index;

		internal void _003CRotateLight_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public bool _isAni;

		public GameObject _amazonFly;

		public int _index;

		public GetAllPanel65 _003C_003E4__this;

		public TweenCallback _003C_003E9__0;

		internal void _003CConfirm2_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass34_1
	{
		public bool _isAni;

		public GameObject _moenyFly;

		public int _index;

		public GetAllPanel65 _003C_003E4__this;

		public TweenCallback _003C_003E9__1;

		internal void _003CConfirm2_003Eb__1()
		{
		}
	}

	
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public GameObject _debrisFly;

		public PiecesSkin65.PiecesInfo piecesInfo;

		internal void _003CDebrisAni_003Eb__0()
		{
		}
	}


	public Image maskImg;

	public Button closeBtn;

	public Transform contentTra;

	public List<Transform> rotateLight;

	public List<GameObject> flyHides;

	public List<Transform> flyTra;

	public List<RectTransform> finallyPointTra;

	public Sprite amazonSprite;

	public Sprite moneySprite;

	public ParticleSystem moneyBoom;

	public GameObject flyMoney;

	public GameObject flyAmazon;

	public GameObject flyDebris;

	public Transform flyPar;

	public Transform tempPar;

	private BoxInfo _boxInfo;

	private bool m_isConfirm;

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

	private IEnumerator WaitMove()
	{
		return null;
	}

	private int ProduceIndex(int curIndex)
	{
		return 0;
	}

	private void Debris(Transform _good, List<Sprite> sprite, PiecesSkin65.PiecesInfo piecesInfo)
	{
	}

	private void RotateLight(int _index)
	{
	}

	private void Confirm()
	{
	}

	private IEnumerator Confirm2()
	{
		return null;
	}

	private void DebrisAni(GameObject _debrisFly, PiecesSkin65.PiecesInfo piecesInfo)
	{
	}

	private void TurnCard(Transform trans, int effectIndex)
	{
	}

	private IEnumerator T2(Transform trans)
	{
		return null;
	}

	private void _003COpenAni_003Eb__21_0()
	{
	}
}
