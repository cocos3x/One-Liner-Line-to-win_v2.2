using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BlockInfo65 : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	private sealed class _003CCountDown_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BlockInfo65 _003C_003E4__this;

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
		public _003CCountDown_003Ed__18(int _003C_003E1__state)
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

	public Transform blockTip;

	public BlockType blockType;

	public Image objImg;

	public int blockId;

	public int blockIndex;

	public bool isSelect;

	public bool isEmoji;

	public GameObject point;

	public bool isKey;

	public GameObject KeyObj;

	private bool m_isreturn;

	private bool m_removeFirst;

	private bool m_isSlide;

	private bool m_clear;

	public int m_dir;

	private void Awake()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	private IEnumerator CountDown()
	{
		return null;
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public bool IsSelectCurBlock()
	{
		return false;
	}

	public void ZoomAni()
	{
	}

	private void Prop()
	{
	}

	public void FirstBlockClick()
	{
	}

	private void ReturnBlock()
	{
	}

	private void ReturnAllBlock()
	{
	}

	private void _003CZoomAni_003Eb__22_0()
	{
	}
}
