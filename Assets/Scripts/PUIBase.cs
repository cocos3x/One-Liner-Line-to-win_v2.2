using UnityEngine;

public abstract class PUIBase : MonoBehaviour
{
	public PUITYPE UIType;

	public PUILEVELTYPE UILevelType;

	public PUIOUTTYPE UIOutType;

	public int SiblingIndex;

	protected bool _handleAble;

	public virtual void OnEnter()
	{
	}

	public virtual void OnResume()
	{
	}

	public virtual void OnPause()
	{
	}

	public virtual void OnExit()
	{
	}

	public virtual void AddMonitor()
	{
	}

	public virtual void RemoveMonitor()
	{
	}

	public virtual void OpenAni()
	{
	}

	public virtual void CloseAni()
	{
	}
}
