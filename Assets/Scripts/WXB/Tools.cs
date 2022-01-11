using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace WXB
{
	public static class Tools
	{
		public const int s_dyn_default_speed = 320;

		public const int s_offset_default_speed = 320;

		private static readonly VertexHelper s_VertexHelper;

		private static Font DefaultFont;

		private static Func<string, ISprite> _003Cs_get_sprite_003Ek__BackingField;

		public static Func<string, Font> s_get_font;

		public static Func<string, Cartoon> s_get_cartoon;

		public static Action<List<Cartoon>> s_get_cartoons;

		public static VertexHelper vertexHelper => null;

		public static Func<string, ISprite> s_get_sprite
		{
			private get
			{
				return null;
			}
			set
			{
			}
		}

		public static void LB2LT(ref Vector2 pos, float height)
		{
		}

		public static void LT2LB(ref Vector2 pos, float height)
		{
		}

		public static Font GetFont(string name)
		{
			return null;
		}

		public static Font GetDefaultFont()
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

		public static void GetAllCartoons(List<Cartoon> cartoons)
		{
		}

		public static void AddLine(VertexHelper vh, Vector2 leftPos, Vector2 uv, float width, float height, Color color)
		{
		}

		public static bool IsHexadecimal(char c)
		{
			return false;
		}

		public static float stringToFloat(string str, float df)
		{
			return 0f;
		}

		public static int stringToInt(string str, int df)
		{
			return 0;
		}

		public static Font ParserFontName(string text, ref int startpos)
		{
			return null;
		}

		public static bool ScreenPointToWorldPointInRectangle(RectTransform rectTrans, Vector2 screenPoint, Camera cam, out Vector2 worldPoint)
		{
			return false;
		}

		public static Color ParseColor(string text, int offset, Color defc)
		{
			return (Color)null;
		}

		public static bool ParseColor(string text, int offset, out Color color)
		{
			return false;
		}

		public static Color ParseColor24(string text, int offset)
		{
			return (Color)null;
		}

		public static Color ParseColor32(string text, int offset)
		{
			return (Color)null;
		}

		public static int HexToDecimal(char ch)
		{
			return 0;
		}

		public static Color ParserColorName(string text, Color dc)
		{
			return (Color)null;
		}

		public static Color ParserColorName(string text, ref int startpos, Color dc)
		{
			return (Color)null;
		}

		public static T AddChild<T>(this GameObject go) where T : MonoBehaviour
		{
			return null;
		}

		public static void AddChild(this GameObject go, GameObject child)
		{
		}

		public static void Destroy(GameObject go)
		{
		}

		public static void UpdateRect(RectTransform child, Vector2 offset)
		{
		}
	}
}
