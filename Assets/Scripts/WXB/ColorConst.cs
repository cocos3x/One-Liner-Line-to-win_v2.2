using System.Collections.Generic;
using UnityEngine;

namespace WXB
{
	public static class ColorConst
	{
		public static Color aqua;

		public static Color brown;

		public static Color darkblue;

		public static Color fuchsia;

		public static Color lightblue;

		public static Color lime;

		public static Color maroon;

		public static Color navy;

		public static Color olive;

		public static Color orange;

		public static Color purple;

		public static Color silver;

		public static Color teal;

		public static Dictionary<string, Color> NameToColors;

		public static void Set(string name, Color c)
		{
		}

		public static bool Get(string name, out Color color)
		{
			return false;
		}

		public static Color Get(string name, Color d)
		{
			return (Color)null;
		}
	}
}
