using DG.Tweening;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;

namespace GF
{
	public class Util
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

		[Serializable]
		private class LocalStorageTypeData<T>
		{
			public T data;
		}

		private class LocalStorage
		{
			private static Dictionary<string, object> m_Cache;

			private static string JsonFilePath(string localStorageKey)
			{
				return "";
			}

			

			public static void SetItem<T>(string localStorageKey, T value, bool isObject)
			{
			}

			

			private static void WriteItem<T>(string localStorageKey, T value, bool isObject)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public float time;

			internal float _003CDelay2Do_003Eb__0()
			{
				return 0f;
			}

			internal void _003CDelay2Do_003Eb__1(float x)
			{
			}
		}

		private Dictionary<string, object> m_ConfigDataDictionary;

		private static Util _instance;

		private static AndroidJavaClass unityPlayer;

		private static AndroidJavaObject currentActivity;

		private AndroidJavaObject vibrator;

		public static Util Instance => null;

		private string streamingAssetsPath => "";

		private string persistentDataPath => "";

	

		public Tweener Delay2Do(float time, TweenCallback complete, [Optional] TweenCallback update)
		{
			return null;
		}

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

		
		public void WriteToPersistentData<T>(string jsonFilePath, T data, bool append = false)
		{
		}

		

		public void SetItem<T>(string localStorageKey, T value)
		{
		}

		public string GetItem(string localStorageKey, string defaultValue)
		{
			return "";
		}

		public void SetItem(string localStorageKey, string value)
		{
		}

		public int GetItem(string localStorageKey, int defaultValue)
		{
			return 0;
		}

		public void SetItem(string localStorageKey, int value)
		{
		}

		public double GetItem(string localStorageKey, double defaultValue)
		{
			return 0.0;
		}

		public void SetItem(string localStorageKey, double value)
		{
		}

		public bool GetItem(string localStorageKey, bool defaultValue)
		{
			return false;
		}

		public void SetItem(string localStorageKey, bool value)
		{
		}

		public bool IsNetworkReachability()
		{
			return false;
		}

		public void Vibrate()
		{
		}

		public void Vibrate(long milliseconds)
		{
		}

		public void Vibrate(long[] pattern, int repeat)
		{
		}

		public void Cancel()
		{
		}

		private bool isAndroid()
		{
			return false;
		}
	}
}
