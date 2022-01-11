using System.Collections.Generic;

namespace WXB
{
	public class ESFactory
	{
		private static Dictionary<string, ElementSegment> TypeList;

		static ESFactory()
		{
		}

		public static void Add(string name, ElementSegment es)
		{
		}

		public static bool Remove(string name)
		{
			return false;
		}

		public static ElementSegment Get(string name)
		{
			return null;
		}

		public static List<string> GetAllName()
		{
			return null;
		}
	}
}
