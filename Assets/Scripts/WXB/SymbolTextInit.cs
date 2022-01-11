using System.Collections.Generic;
using UnityEngine;

namespace WXB
{
	public class SymbolTextInit : MonoBehaviour
	{
		private static Dictionary<string, Font> Fonts;

		private static Dictionary<string, DSprite> Sprites;

		private static Dictionary<string, Cartoon> Cartoons;

		[SerializeField]
		private Font[] fonts;

		[SerializeField]
		private Sprite[] sprites;

		[SerializeField]
		private Cartoon[] cartoons;

		private void init()
		{
		}

		private static void Init()
		{
		}

		public static Font GetFont(string name)
		{
			return null;
		}

		public static ISprite GetSprite(string name)
		{
			return null;
		}

		public static Cartoon GetCartoon(string name)
		{
			return null;
		}

		public static void GetCartoons(List<Cartoon> cartoons)
		{
		}
	}
}
