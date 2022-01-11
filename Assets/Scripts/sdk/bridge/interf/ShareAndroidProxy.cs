using UnityEngine;

namespace sdk.bridge.interf
{
	public class ShareAndroidProxy : IShare
	{
		private AndroidJavaObject _androidJavaObject;

		private const string SDK_MAIN_CLASS = "com.connect.share.ShareMgr";

		private const string SDK_SHARE_CALLBACK_CLASS = "com.connect.share.interf.IShareCallback";

		public static ShareAndroidProxy create()
		{
			return null;
		}

		public void OnGameInit()
		{
		}

		public void CheckShare()
		{
		}

		public void EnterShare(int from)
		{
		}

		public void SetShareAppSwitch(bool open)
		{
		}

		public void AddFissionAppListener(ShareAction action)
		{
		}
	}
}
