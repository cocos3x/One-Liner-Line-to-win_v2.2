using sdk.bridge.interf;

namespace sdk
{
	public static class SdkAb
	{
	
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
