using sdk.ad;
using sdk.bridge.interf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace sdk.bridge
{
	public class Mgr
	{
		public static readonly Mgr Instance;

		private readonly Dictionary<string, ArrayList> _abCallbacks;

		private ArrayList _ntpCallbacks;

		private readonly Dictionary<int, ArrayList> _adCallbacks;

		private IBridge _bridge;

		static Mgr()
		{
		}

		private Mgr()
		{
		}

		public void OnGameInit()
		{
		}

		public string GetTestConfig()
		{
			return "";
		}

		public void SetAbTest(bool isTest)
		{
		}

		public void SetLogState(bool isOpen)
		{
		}

		public void OnGameEnter()
		{
		}

		public void LoadAd(int position)
		{
		}

		

		public void SetBannerVisible(bool isVisible)
		{
		}

		public bool HadCache(int position)
		{
			return false;
		}

		

		public string GetBuglyId()
		{
			return "";
		}

		public void PostAbRequest(string serverIdName)
		{
		}

		public string GetAbContent(string serverName)
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

		public void Track(short src, string eventName, string expands)
		{
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

		public void Jump2FbPage()
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

		public bool AllowGameFun()
		{
			return false;
		}

		public bool IsSdkReady()
		{
			return false;
		}

		public void AddAbListener(string abName, AbAction action)
		{
		}

		public void RemoveAbListener(string abName, AbAction action)
		{
		}

		public void PostAbListener(string abName, bool isCache)
		{
		}

		public void PostAllAbListener(bool isCache)
		{
		}

		public void AddNtpListener(Action action)
		{
		}

		private void OnNtpCallback()
		{
		}

		public void RemoveNtpListener(Action action)
		{
		}

		public int GetNotchScreen()
		{
			return 0;
		}

		public int GetAdTimes()
		{
			return 0;
		}

		public int GetFullAdTimes()
		{
			return 0;
		}

		public bool IsUpdateUser()
		{
			return false;
		}

		public void AddAdListener(int position, AdAction action)
		{
		}

		public void RemoveAdListener(int position, AdAction action)
		{
		}

		public void PostAdListener(int position, AdType adType)
		{
		}
	}
}
