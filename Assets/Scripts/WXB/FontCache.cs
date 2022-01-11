using System.Collections.Generic;
using UnityEngine;

namespace WXB
{
	public static class FontCache
	{
		private static CharacterInfo s_Info;

		private static Dictionary<long, int> FontLineHeight;

		private static TextGenerator sCachedTextGenerator;

		private static Dictionary<long, int> FontAdvances;

		public static int GetLineHeight(Font font, int size, FontStyle fs)
		{
			return 0;
		}

		public static int GetAdvance(Font font, int size, FontStyle fs, char ch)
		{
			return 0;
		}
	}
}
