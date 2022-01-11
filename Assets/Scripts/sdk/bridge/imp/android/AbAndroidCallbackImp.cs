using sdk.bridge.interf;
using UnityEngine;

namespace sdk.bridge.imp.android
{
	public class AbAndroidCallbackImp : AndroidJavaProxy, IAbCallback
	{
		private string _abName;

		private bool _isCache;

		public static AbAndroidCallbackImp Create(string abName, string javaInterface)
		{
			return null;
		}

		public AbAndroidCallbackImp(string javaInterface)
		{
		}

		public void OnAbSuccess(string abName, bool isCache)
		{
		}

		private void PostAbListener()
		{
		}
	}
}
