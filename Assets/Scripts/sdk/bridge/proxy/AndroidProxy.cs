using sdk.ad;
using sdk.bridge.imp.android;
using sdk.bridge.interf;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

namespace sdk.bridge.proxy
{
	public class AndroidProxy : IBridge
	{
		private AndroidJavaObject _androidJavaObject;

		private const string SdkMainClass = "com.happy.bridge.HappyBridge";

		private const string SdkAdCallbackClass = "com.happy.bridge.interf.IAdCallback";

		private const string SdkAbCallbackClass = "com.happy.bridge.interf.IAbCallback";

		private const string SdkNtpCallbackClass = "com.happy.bridge.interf.INtpCallback";

		private readonly Dictionary<int, AdAndroidCallbackImp> _adCallbacks;

		public static AndroidProxy Create()
		{
			return null;
		}

		public void OnGameInit()
		{
		}

		public string GetTestConfig()
		{
			return "";
		}

		public void OnGameEnter()
		{
		}

		public void AddAbListener(string abName, AbAction action)
		{
		}

		public void AddNtpListener(Action action)
		{
		}

		public void SetAbTest(bool isTest)
		{
		}

		public int GetFullAdTimes()
		{
			return 0;
		}

		public bool GetLogSwitch()
		{
			return false;
		}

		public string GetBuglyId()
		{
			return "";
		}

		public bool IsUpdateUser()
		{
			return false;
		}

		public void SetLogState(bool isOpen)
		{
		}

		public void LoadAd(int position)
		{
		}

		public bool ShowOpenAd(int position, AdEvent adEvent, Action sdkCallback)
		{
			return false;
		}

		private AdAndroidCallbackImp GetSdkAdCallback(int position, bool isReward, Action sdkCallback, [Optional] Action failSdkCallback)
		{
			return null;
		}

		public bool ShowAd(int position, AdEvent adEvent, Action sdkCallback)
		{
			return false;
		}

		public bool Load2ShowAd(int position, AdEvent adEvent, Action sdkCallback)
		{
			return false;
		}

		public void LoadRewardAd(int position)
		{
		}

		public void Load2ShowRewardAd(int position, AdEvent adEvent, Action sdkCallback, [Optional] Action sdkFailCallback)
		{
		}

		public bool ShowRewardAd(int position, AdEvent adEvent, Action sdkCallback, [Optional] Action sdkFailCallback)
		{
			return false;
		}

		public void Load2ShowBanner(int position, AdEvent staticsMsg)
		{
		}

		public void SetBannerVisible(bool isVisible)
		{
		}

		public void AddAdListener(int position, AdAction action)
		{
		}

		public bool HadCache(int position)
		{
			return false;
		}

		public void AdPageShow(int position, AdEvent adEvent)
		{
		}

		public void AdPageClick(int position, AdEvent adEvent)
		{
		}

		public void PostAbRequest(string serverIdName)
		{
		}

		public string GetAbContent(string serverIdName)
		{
			return "";
		}

		public long GetCurrentNtpTime()
		{
			return 0L;
		}

		public bool HadInitNtpTime()
		{
			return false;
		}

		public void Track(int src, string eventName, string expands)
		{
		}

		public string GetAppName()
		{
			return "";
		}

		public string GetEmail()
		{
			return "";
		}

		public string GetSysLanguageCode()
		{
			return "";
		}

		public void SetAppLanguageCode(string code)
		{
		}

		public void SetAppCurrency(string currencyUnit, float currencyRate, int decimalPoint)
		{
		}

		public string GetSysCountryCode()
		{
			return "";
		}

		public string GetNetCountryCode()
		{
			return "";
		}

		public bool IsNetworkOk()
		{
			return false;
		}

		public void Jump2PrivacyCenter(string url = "")
		{
		}

		public void Jump2TermsUseCenter(string url = "")
		{
		}

		public void Jump2Email(string eMai = "")
		{
		}

		public void Jump2GpMark()
		{
		}

		public void Jump2FbPage(string url = "")
		{
		}

		public bool IsLoadingReady()
		{
			return false;
		}

		public int GetNotchScreen()
		{
			return 0;
		}

		public int GetAdTimes()
		{
			return 0;
		}

		public bool AllowGameFun()
		{
			return false;
		}
	}
}
