using sdk.bridge.interf;

namespace sdk
{
	public static class SdkAb
	{
		public static T GetFunAb<T>(string serverName, string key, T defaultValue)
		{
			return (T)null;
		}

		public static bool IsRateOpen()
		{
			return false;
		}

		public static bool IsFunOpen()
		{
			return false;
		}

		public static bool IsAuditMode()
		{
			return false;
		}

		public static void AddAbListener(string serverName, AbAction action)
		{
		}

		public static void RemoveAbListener(string serverName, AbAction action)
		{
		}
	}
}
