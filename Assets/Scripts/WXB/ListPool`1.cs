using System;
using System.Collections.Generic;

namespace WXB
{
	public static class ListPool<T>
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			internal void _003C_002Ecctor_003Eb__3_0(List<T> l)
			{
			}
		}

		private static readonly ObjectPool<List<T>> s_ListPool;

		public static List<T> Get()
		{
			return null;
		}

		public static void Release(List<T> toRelease)
		{
		}
	}
}
