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
