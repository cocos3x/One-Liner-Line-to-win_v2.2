using DG.Tweening;
using Spine;
using Spine.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class BoxPanel65 : PUIBase
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__22_0;

		public static Action _003C_003E9__23_0;

		internal void _003COpenAni_003Eb__22_0()
		{
		}

		internal void _003CCloseAni_003Eb__23_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public GameObject _obj;

		public int _index;

		public BoxPanel65 _003C_003E4__this;

		internal void _003COpenBox_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public BoxPanel65 _003C_003E4__this;

		public int _index;

		internal void _003COpenAni_003Eb__0(TrackEntry _003Cp0_003E)
		{
		}
	}

	private sealed class _003COpenAni_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BoxPanel65 _003C_003E4__this;

		public int _index;

		public GameObject _obj;

		private _003C_003Ec__DisplayClass30_0 _003C_003E8__1;

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
		public _003COpenAni_003Ed__30(int _003C_003E1__state)
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

	private sealed class _003CIsConfirm_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BoxPanel65 _003C_003E4__this;

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
		public _003CIsConfirm_003Ed__33(int _003C_003E1__state)
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

	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public GameObject _obj;

		public BoxPanel65 _003C_003E4__this;

		public TweenCallback _003C_003E9__2;

		public TweenCallback _003C_003E9__1;

		internal void _003COpenAmazon_003Eb__0()
		{
		}

		internal void _003COpenAmazon_003Eb__1()
		{
		}

		internal void _003COpenAmazon_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public GameObject _obj;

		public BoxPanel65 _003C_003E4__this;

		public TweenCallback _003C_003E9__2;

		public TweenCallback _003C_003E9__1;

		internal void _003COpenMoney_003Eb__0()
		{
		}

		internal void _003COpenMoney_003Eb__1()
		{
		}

		internal void _003COpenMoney_003Eb__2()
		{
		}
	}

	public Image maskImg;

	public Button closeBtn;

	public Button closeBtnNone;

	public Transform contentTra;

	public List<Button> openBtn;

	public Sprite amazonSprite;

	public Sprite moneySprite;

	public List<SkeletonGraphic> boxSpines;

	public Sprite ADsprite;

	public ParticleSystem[] effect;

	public Transform titleTra;

	public Transform subhead;

	public List<Sprite> ml_debrisSprites;

	public List<Sprite> ff_debrisSprites;

	public List<Sprite> rl_debrisSprites;

	public List<ParticleSystem> effectPar;

	private float m_getTimeNum;

	private bool m_click;

	private bool isConfirm;

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

	private void OpenBox()
	{
	}

	private IEnumerator OpenAni(GameObject _obj, int _index)
	{
		return null;
	}

	private void Debris(Transform _good, int _index, List<Sprite> sprites, PiecesSkin65.PiecesInfo piecesInfo)
	{
	}

	private IEnumerator IsConfirm()
	{
		return null;
	}

	private void Close()
	{
	}

	private void Close(object useData)
	{
	}

	private void Continue()
	{
	}

	private void OpenAmazon(GameObject _obj)
	{
	}

	private void OpenMoney(GameObject _obj)
	{
	}

	private void GetBoxInfo()
	{
	}

	private void SetDebrisData(PiecesSkin65.PiecesInfo piecesInfo, int _index)
	{
	}

	private void _003COpenBox_003Eb__29_1()
	{
	}

	private void _003CClose_003Eb__35_0()
	{
	}

	private void _003CClose_003Eb__35_1()
	{
	}
}
