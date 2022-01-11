using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class GetUsdPanel65 : PUIBase
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__17_0;

		internal void _003CCloseAni_003Eb__17_0()
		{
		}
	}

	private sealed class _003CAni_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GetUsdPanel65 _003C_003E4__this;

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
		public _003CAni_003Ed__21(int _003C_003E1__state)
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

	public Button confirmBtn;

	public Transform rotateLight;

	public Text progressBarText;

	public RectTransform progressBar;

	public Text getTimeText;

	private float getTimeNum;

	public GameObject[] flyHides;

	public Transform flyTra;

	public Transform bg;

	public Image mask;

	public ParticleSystem effect;

	public List<ParticleSystem> flyEffect;

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

	private void RemoveListener()
	{
	}

	private new void CloseAni()
	{
	}

	private void Init(params object[] param)
	{
	}

	private void RotateLight()
	{
	}

	private void Confirm()
	{
	}

	private IEnumerator Ani()
	{
		return null;
	}

	private void _003CRotateLight_003Eb__19_0()
	{
	}

	private void _003CAni_003Eb__21_0()
	{
	}
}
