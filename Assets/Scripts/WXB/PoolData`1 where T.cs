using System.Collections.Generic;

namespace WXB
{
	public class PoolData<T> where T : new()
	{
		public static List<T> bufs;

		public static T Get()
		{
			return (T)null;
		}

		public static void Free(T t)
		{
		}

		public static void FreeList(List<T> list)
		{
		}
	}
}
