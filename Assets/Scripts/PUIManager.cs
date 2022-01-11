using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PUIManager : MonoBehaviour
{
	public static PUIManager Instance;

	public PUIRoot UIRoot;

	private Dictionary<PUITYPE, PUIBase> _dicUIObj;

	private Dictionary<PUILEVELTYPE, List<PUIBase>> _dicVisibleUIObj;

	private PUIBase _003CCurrentUI_003Ek__BackingField;

	public PUIBase CurrentUI
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public Camera UICamera()
	{
		return null;
	}

	private void Awake()
	{
	}

	public void OpenUI(PUITYPE uiType, [Optional] Action<PUIBase> callBack)
	{
	}

	public void OpenUI(PUITYPE uiType, params object[] param)
	{
	}

	public void CloseUI(PUITYPE uiType, [Optional] Action callBack)
	{
	}

	public void CloseUI(PUIBase uiObj, [Optional] Action callBack)
	{
	}

	private void LoadUI(PUITYPE uiType, Action<PUIBase> callback)
	{
	}

	private void LoadUI(PUITYPE uiType, params object[] param)
	{
	}

	private void OnGetUIObject(PUIBase ui)
	{
	}

	private bool AddVisibleUIObj(PUIBase uiObj)
	{
		return false;
	}

	private void RemoveVisibleUIObj(PUIBase uiObj)
	{
	}

	private void RefreshHandleAbleUI()
	{
	}

	public PUIBase GetHandleAbleUI()
	{
		return null;
	}

	private bool UIHadInVisibleList(PUIBase uiObj)
	{
		return false;
	}
}
