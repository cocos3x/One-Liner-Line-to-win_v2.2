using System.Collections.Generic;
using UnityEngine;

public class PUIRoot : MonoBehaviour
{
	private Camera _UICamera;

	private Dictionary<PUILEVELTYPE, Transform> _rootGroup;

	public void Init()
	{
	}

	public Camera GetUICamera()
	{
		return null;
	}

	public void ShowUI(PUIBase uibase)
	{
	}

	public void ShowUI(PUIBase ubase, int siblingIndex)
	{
	}

	public void HideUI(PUIBase uibase)
	{
	}
}
