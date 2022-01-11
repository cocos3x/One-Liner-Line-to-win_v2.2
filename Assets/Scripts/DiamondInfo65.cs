using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class DiamondInfo65 : MonoBehaviour
{
	private sealed class _003CSubstep_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DiamondInfo65 _003C_003E4__this;

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
		public _003CSubstep_003Ed__17(int _003C_003E1__state)
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

	public GameType gameType;

	public Expend expend;

	public int expendNum;

	public Produce produce;

	public int produceNum;

	public Button visitBtn;

	public Image currency;

	public Image currencys;

	public Text text;

	public ConditionType conditionType;

	public Text progressText;

	public int progressFullValue;

	public RectTransform progressBar;

	private Vector2 m_size;

	private Vector2 m_pos;

	public void Awake()
	{
	}

	private void Start()
	{
	}

	private void Visit()
	{
	}

	private void Init()
	{
	}

	private IEnumerator Substep()
	{
		return null;
	}

	private void Change(object userData)
	{
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public void MaskTypeProgressBar(RectTransform progressBar, float percent)
	{
	}
}
