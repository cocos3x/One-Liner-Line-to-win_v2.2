using sdk.ad;
using System;
using System.Runtime.InteropServices;

namespace sdk.bridge.interf
{
	public interface IBridge
	{
		void LoadAd(int position);

		bool ShowOpenAd(int position, AdEvent adEvent, Action sdkCallback);

		bool ShowAd(int position, AdEvent adEvent, Action sdkCallback);

		bool Load2ShowAd(int position, AdEvent adEvent, Action sdkCallback);

		void LoadRewardAd(int position);

		void Load2ShowRewardAd(int position, AdEvent adEvent, Action sdkCallback, [Optional] Action sdkFailCallback);

		bool ShowRewardAd(int position, AdEvent adEvent, Action sdkCallback, [Optional] Action sdkFailCallback);

		void Load2ShowBanner(int position, AdEvent staticsMsg);

		void SetBannerVisible(bool isVisible);

		bool HadCache(int position);

		void AdPageShow(int position, AdEvent adEvent);

		void AdPageClick(int position, AdEvent adEvent);

		void AddAdListener(int position, AdAction action);

		void OnGameInit();

		string GetTestConfig();

		void OnGameEnter();

		void Jump2PrivacyCenter(string url = "");

		void Jump2TermsUseCenter(string url = "");

		void Jump2Email(string email = "");

		void Jump2GpMark();

		void Jump2FbPage(string url = "");

		bool IsLoadingReady();

		int GetNotchScreen();

		int GetAdTimes();

		int GetFullAdTimes();

		string GetBuglyId();

		bool IsUpdateUser();

		void SetLogState(bool isOpen);

		void PostAbRequest(string serverIdName);

		string GetAbContent(string serverIdName);

		long GetCurrentNtpTime();

		bool HadInitNtpTime();

		void AddAbListener(string abName, AbAction action);

		void AddNtpListener(Action action);

		void SetAbTest(bool isTest);

		void Track(int src, string eventName, string expands);

		string GetAppName();

		string GetEmail();

		string GetSysLanguageCode();

		void SetAppLanguageCode(string code);

		void SetAppCurrency(string currencyUnit, float currencyRate, int decimalPoint);

		string GetSysCountryCode();

		string GetNetCountryCode();

		bool IsNetworkOk();

		bool AllowGameFun();
	}
}
