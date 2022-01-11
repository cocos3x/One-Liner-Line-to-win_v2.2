using System;
using System.Collections.Generic;

public class ABManager
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<float> _003C_003E9__9_0;

		public static Func<float> _003C_003E9__9_1;

		public static Func<float> _003C_003E9__9_2;

		public static Func<float> _003C_003E9__9_3;

		public static Func<float> _003C_003E9__9_4;

		public static Func<float> _003C_003E9__9_5;

		public static Func<float> _003C_003E9__9_6;

		internal float _003C_002Ector_003Eb__9_0()
		{
			return 0f;
		}

		internal float _003C_002Ector_003Eb__9_1()
		{
			return 0f;
		}

		internal float _003C_002Ector_003Eb__9_2()
		{
			return 0f;
		}

		internal float _003C_002Ector_003Eb__9_3()
		{
			return 0f;
		}

		internal float _003C_002Ector_003Eb__9_4()
		{
			return 0f;
		}

		internal float _003C_002Ector_003Eb__9_5()
		{
			return 0f;
		}

		internal float _003C_002Ector_003Eb__9_6()
		{
			return 0f;
		}
	}

	public Dictionary<string, ABData> abDatas;

	public ABData abData;

	public float GetABState(string _key)
	{
		return 0f;
	}

	public bool GetABSwitch(string _key)
	{
		return false;
	}

	public float GetABLocal(string _key)
	{
		return 0f;
	}

	public void SetABSwitch(string _key, bool _state)
	{
	}

	public void SetABSwitch(string _key)
	{
	}

	public void SetABLocal(string _key, float _state)
	{
	}

	private static ABData CreatorData(string _abField, bool _abSwitchDefault, string _abCutomField, float _abLocalDefaultValue, Func<float> _sdkAb)
	{
		return null;
	}
}
