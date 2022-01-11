using System.Runtime.InteropServices;

public class JsonManager
{
	private JsonHelper jsonHelper;

	private DataExistPath dataExistPath;

	private string m_jsonFileFolder;

	private string m_jsonFileName;

	public void Save<T>(T _data, [Optional] string _jsonFileName, [Optional] string _jsonFileFolder, DataExistPath _dataExistPath = DataExistPath.None)
	{
	}

	

	public void Remove([Optional] string _jsonFileName, [Optional] string _jsonFileFolder, DataExistPath _dataExistPath = DataExistPath.None)
	{
	}
}
