using System;

public class ABData
{
	public string abField;

	public bool abSwitchDefault;

	public string abCutomField;

	public float abLocalDefaultValue;

	public Func<float> sdkAb;

	public bool ABSwitch
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float ABLocal
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float GetState()
	{
		return 0f;
	}
}
