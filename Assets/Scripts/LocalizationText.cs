using System;
using UnityEngine.UI;

[Serializable]
public class LocalizationText : Text
{
	private string key;

	public string Key
	{
		get
		{
			return "";
		}
		set
		{
		}
	}

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void OnLocalize()
	{
	}
}
