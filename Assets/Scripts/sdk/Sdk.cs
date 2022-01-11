namespace sdk
{
	public static class Sdk
	{
		public const string Version = "HappyFull_9.0.0";

		public static void OnGameInit()
		{
		}

		public static void OnGameEnter()
		{
		}

		public static int GetNotchScreen()
		{
			return 0;
		}

		public static string GetConfigBuglyId()
		{
			return "";
		}

		public static bool IsUpdateUser()
		{
			return false;
		}

		public static bool IsSdkReady()
		{
			return false;
		}

		public static bool HadInitNtpTime()
		{
			return false;
		}

		public static long GetCurrentNtpTime()
		{
			return 0L;
		}

		public static void Jump2Email(string eMai = "")
		{
		}

		public static void Jump2PrivacyCenter(string url = "")
		{
		}

		public static void Jump2TermsUse(string url = "")
		{
		}

		public static void Jump2GpMark()
		{
		}

		public static string GetAppName()
		{
			return "";
		}

		public static string GetEmail()
		{
			return "";
		}

		public static string GetSysLanguageCode()
		{
			return "";
		}

		public static void SetAppLanguageCode(string code)
		{
		}

		public static void SetAppCurrency(string currencyUnit, float currencyRate, int decimalPoint)
		{
		}

		public static string GetSysCountryCode()
		{
			return "";
		}

		public static string GetNetCountryCode()
		{
			return "";
		}

		public static bool IsNetworkOk()
		{
			return false;
		}

		public static bool AllowGameFun()
		{
			return false;
		}

		public static bool NeedLog()
		{
			return false;
		}

		public static void SetNeedLog(bool log)
		{
		}

		public static void SetTestMode(bool isTest)
		{
		}

		public static void Log(object message)
		{
		}
	}
}
