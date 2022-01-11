using System.Collections.Generic;

namespace WXB
{
	public static class NodePools<T> where T : NodeBase, new()
	{
		public interface IPool
		{
			T Get();

			void Free(T value);

			void Release();
		}

	

		private static IPool pool;

		public static void SetNoPool()
		{
		}

		public static T Get()
		{
			return null;
		}

		public static void Free(T t)
		{
		}

		public static void Release()
		{
		}

		public static void Reset(int num)
		{
		}
	}
}
