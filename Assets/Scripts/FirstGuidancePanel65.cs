using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class FirstGuidancePanel65 : PUIBase
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__13_0;

		internal void _003CCloseAni_003Eb__13_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public bool _isAni;

		public GameObject _moenyFly;

		public int _index;

		public TweenCallback _003C_003E9__0;

		internal void _003CClose2_003Eb__0()
		{
		}
	}

	private sealed class _003CClose2_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FirstGuidancePanel65 _003C_003E4__this;

		private _003C_003Ec__DisplayClass16_0 _003C_003E8__1;

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
		public _003CClose2_003Ed__16(int _003C_003E1__state)
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

	public Image maskImg;

	public Button closeBtn;

	public Transform contentTra;

	public Text diamondText;

	public GameObject flyMoney;

	public Transform rotateLight;

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

	private IEnumerator Close2()
	{
		return null;
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

	private void _003COpenAni_003Eb__12_0()
	{
	}

	private void _003CRotateLight_003Eb__19_0()
	{
	}
}
