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

		private class Normal : IPool
		{
			private T WXB_002ENodePools_003CT_003E_002EIPool_002EGet()
			{
				return null;
			}

			private void WXB_002ENodePools_003CT_003E_002EIPool_002EFree(T value)
			{
			}

			private void WXB_002ENodePools_003CT_003E_002EIPool_002ERelease()
			{
			}
		}

		private class Pool : IPool
		{
			private Queue<T> bufs;

			public Pool(int num)
			{
			}

			private T WXB_002ENodePools_003CT_003E_002EIPool_002EGet()
			{
				return null;
			}

			private void WXB_002ENodePools_003CT_003E_002EIPool_002EFree(T value)
			{
			}

			private void WXB_002ENodePools_003CT_003E_002EIPool_002ERelease()
			{
			}
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
