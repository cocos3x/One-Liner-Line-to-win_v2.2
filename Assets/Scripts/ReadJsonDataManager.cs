using UnityEngine;

public class ReadJsonDataManager : MonoBehaviour
{
	private static ReadJsonDataManager _instance;

	public const string scene1JsonPathName = "Data.json";

	private LevelDataMsg dataJson;

	public static ReadJsonDataManager Instance => null;

	private void Start()
	{
	}

	public string getTextForStreamingAssets(string path)
	{
		return "";
	}

	public void ReadJsonData()
	{
	}
}
