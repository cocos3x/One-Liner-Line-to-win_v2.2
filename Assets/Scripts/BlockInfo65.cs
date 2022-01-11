using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BlockInfo65 : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	
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
