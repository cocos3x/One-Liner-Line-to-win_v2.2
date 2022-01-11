using System.Security.Cryptography;

public class JsonHelper
{
	private class Crypto
	{
		private static byte[] m_Key;

		public static string Encrypt(string toEncrypt)
		{
			return "";
		}

		public static string Decrypt(string toDecrypt)
		{
			return "";
		}

		private static RijndaelManaged CreateRijndaelManaged()
		{
			return null;
		}
	}

	private string streamingAssetsPath => "";

	private string persistentDataPath => "";

	public string GetPathsInfo()
	{
		return "";
	}

	private string GetFilePathOfStreamingAssetsPath(string filePath)
	{
		return "";
	}

	private string __ReadFromStreamAssets(string jsonFilePath)
	{
		return "";
	}

	public T ReadFromStreamAssets<T>(string jsonFilePath)
	{
		return (T)null;
	}

	public string GetFilePathOfPersistentDataPath(string filePath)
	{
		return "";
	}

	public bool IsFileExistInPersistentDataPath(string filePath)
	{
		return false;
	}

	public void RemoveFile(string jsonFilePath)
	{
	}

	public T ReadFromPersistentData<T>(string jsonFilePath)
	{
		return (T)null;
	}

	public void WriteToPersistentData<T>(string jsonFilePath, T data, bool append = false)
	{
	}
}
