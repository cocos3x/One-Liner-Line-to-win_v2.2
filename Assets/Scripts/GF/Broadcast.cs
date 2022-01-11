using System;
using System.Collections.Generic;

namespace GF
{
	public class Broadcast
	{
		private static Dictionary<string, Delegate> m_EventTable;

		private static void OnListenerAdding(string eventName, Delegate callBack)
		{
		}

		private static void OnListenerRemoving(string eventName, Delegate callBack)
		{
		}

		private static void OnListenerRemoved(string eventName)
		{
		}

		public static void AddListener(string eventName, CallBack callBack)
		{
		}

		public static void AddListener<T>(string eventName, CallBack<T> callBack)
		{
		}

		public static void AddListener<T, X>(string eventName, CallBack<T, X> callBack)
		{
		}

		public static void AddListener<T, X, Y>(string eventName, CallBack<T, X, Y> callBack)
		{
		}

		public static void AddListener<T, X, Y, Z>(string eventName, CallBack<T, X, Y, Z> callBack)
		{
		}

		public static void AddListener<T, X, Y, Z, W>(string eventName, CallBack<T, X, Y, Z, W> callBack)
		{
		}

		public static void RemoveListener(string eventName, CallBack callBack)
		{
		}

		public static void RemoveListener<T>(string eventName, CallBack<T> callBack)
		{
		}

		public static void RemoveListener<T, X>(string eventName, CallBack<T, X> callBack)
		{
		}

		public static void RemoveListener<T, X, Y>(string eventName, CallBack<T, X, Y> callBack)
		{
		}

		public static void RemoveListener<T, X, Y, Z>(string eventName, CallBack<T, X, Y, Z> callBack)
		{
		}

		public static void RemoveListener<T, X, Y, Z, W>(string eventName, CallBack<T, X, Y, Z, W> callBack)
		{
		}

		public static void SendEnevt(string eventName)
		{
		}

		public static void SendEnevt<T>(string eventName, T arg)
		{
		}

		public static void SendEnevt<T, X>(string eventName, T arg1, X arg2)
		{
		}

		public static void SendEnevt<T, X, Y>(string eventName, T arg1, X arg2, Y arg3)
		{
		}

		public static void SendEnevt<T, X, Y, Z>(string eventName, T arg1, X arg2, Y arg3, Z arg4)
		{
		}

		public static void SendEnevt<T, X, Y, Z, W>(string eventName, T arg1, X arg2, Y arg3, Z arg4, W arg5)
		{
		}
	}
}
