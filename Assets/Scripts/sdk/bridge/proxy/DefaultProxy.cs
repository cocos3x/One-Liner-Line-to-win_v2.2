using sdk.ad;
using sdk.bridge.interf;
using System;
using System.Runtime.InteropServices;

namespace sdk.bridge.proxy
{
	public class DefaultProxy : IBridge
	{
		private int fullAdTimes;

		private int rewardAdTimes;

		public static DefaultProxy Create()
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

		

		public void LoadRewardAd(int position)
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
