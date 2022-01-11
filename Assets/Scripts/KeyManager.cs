public class KeyManager
{
	private static KeyManager _instance;

	private int keyAmount;

	private int nextKeyLevel;

	public static KeyManager Instance => null;

	public int KeyAmount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int NextKeyLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool GenerateKey(int _level, double _money)
	{
		return false;
	}

	public void RefreshNextKey(int _level)
	{
	}
}
