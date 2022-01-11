using System;
using System.Text;

namespace WXB
{
	public static class Pool
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<StringBuilder> _003C_003E9__1_0;

			internal void _003CGetSB_003Eb__1_0(StringBuilder sb)
			{
			}
		}

		private static Factory<StringBuilder> sb_factory;

		public static PD<StringBuilder> GetSB()
		{
			return (PD<StringBuilder>)null;
		}
	}
}
