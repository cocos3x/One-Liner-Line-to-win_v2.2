using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace WXB
{
	public class TextParser
	{
		public struct Config
		{
			public Anchor anchor;

			public Font font;

			public FontStyle fontStyle;

			public int fontSize;

			public Color fontColor;

			public bool isUnderline;

			public bool isStrickout;

			public bool isBlink;

			public bool isDyncUnderline;

			public bool isDyncStrickout;

			public int dyncSpeed;

			public bool isOffset;

			public Rect offsetRect;

			public EffectType effectType;

			public Color effectColor;

			public Vector2 effectDistance;

			public LineAlignment lineAlignment;

			public int nextLineX;

			public void Clear()
			{
			}

			public void Set(Config c)
			{
			}

			public bool isSame(Config c)
			{
				return false;
			}
		}

		private delegate void OnFun(string c);

		private class HyConfig
		{
			private delegate void OnFunHy(string text);

			public string text;

			public HyperlinkNode node;

			public int startPos;

			public int lenght;

			private StringBuilder sb;

			public TextParser parser;

			private OnFunHy[] OnFunHys;

			public HyConfig(TextParser p)
			{
			}

			private void ParserOutputChar(string text)
			{
			}

			private void ParserSureColor(string text)
			{
			}

			private void ParserFontColor(string text)
			{
			}

			private void ParserRestore(string text)
			{
			}

			private void ParserFontSize(string text)
			{
			}

			private void ParserFont(string text)
			{
			}

			public void Clear()
			{
			}

			public void BeginParser(StringBuilder s)
			{
			}

			private void _003C_002Ector_003Eb__8_0(string text)
			{
			}

			private void _003C_002Ector_003Eb__8_1(string text)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass57_0
		{
			public Action<string, TagAttributes> fun;

			public string type;

			internal void _003CReg_003Eb__0(string key, string param)
			{
			}
		}

		private Owner mOwner;

		private Func<TagAttributes, IExternalNode> getExternalNode;

		private static char[] s_tag_key;

		protected int d_curPos;

		protected Config startConfig;

		protected Config currentConfig;

		protected List<NodeBase> d_nodeList;

		protected StringBuilder d_text;

		protected bool d_bBegin;

		private OnFun[] OnFuns;

		public static int max_cartoon_length;

		private static HyConfig hyConfig;

		private Dictionary<string, Action<string, string>> TagFuns;

		private static TagAttributes s_TagAttributes;

		public T CreateNode<T>() where T : NodeBase, new()
		{
			return null;
		}

		private static void FreeNode<T>(NodeBase nb) where T : NodeBase, new()
		{
		}

		private static bool Get(char c, out Anchor a)
		{
			return false;
		}

		private static bool Get(char c, out LineAlignment a)
		{
			return false;
		}

		private static bool ParserInt(ref int d_curPos, string text, ref int value, int num = 3)
		{
			return false;
		}

		private static bool ParserFloat(ref int d_curPos, string text, ref float value, int num = 3)
		{
			return false;
		}

		public void parser(Owner owner, string text, Config config, List<NodeBase> vList, Func<TagAttributes, IExternalNode> getExternalNode)
		{
		}

		protected void save(bool isNewLine)
		{
		}

		protected void saveX(float value)
		{
		}

		protected void saveY(float value)
		{
		}

		protected void saveZ(float value)
		{
		}

		protected void saveHy()
		{
		}

		protected void clear()
		{
		}

		private static Color GetColour(uint code)
		{
			return (Color)null;
		}

		private void Reg()
		{
		}

		private void ParserNextLineX(string text)
		{
		}

		private bool ParserCartoon(string text)
		{
			return false;
		}

		private void ParserDynSpeed(string text)
		{
		}

		private void ParserDynUnderline(string text)
		{
		}

		private void ParserDynStrickout(string text)
		{
		}

		private void ParserRestoreColor(string text)
		{
		}

		private void ParserRestore(string text)
		{
		}

		private void ParserSureColor(string text)
		{
		}

		private void ParserBlink(string text)
		{
		}

		private void ParserLineAlignment(string text)
		{
		}

		private void ParserFormatting(string text)
		{
		}

		private static bool GetFontStyle(char c, out FontStyle fs)
		{
			return false;
		}

		private void ParserFontStyle(string text)
		{
		}

		private void ParserStrickout(string text)
		{
		}

		private void ParserFontColorS(string text)
		{
		}

		private void ParserFontColor(string text)
		{
		}

		private void ParserUnderLine(string text)
		{
		}

		private void ParserNewLine(string text)
		{
		}

		private void ParserOutputChar(string text)
		{
		}

		private void ParserHyperlink(string text)
		{
		}

		private void ParserFontSize(string text)
		{
		}

		private void ParserXYZ(string text)
		{
		}

		private void ParserFont(string text)
		{
		}

		private void ParseHyText(string text, HyperlinkNode data)
		{
		}

		private void Reg(string type, Action<string, TagAttributes> fun)
		{
		}

		private static Color ParserColorName(string name, int startpos, Color c)
		{
			return (Color)null;
		}

		private static void SetDefaultConfig(NodeBase nb, TagAttributes att)
		{
		}

		private static void SetSizeConfig(RectNode nb, TagAttributes att, Vector2 size)
		{
		}

		private void RegTag()
		{
		}

		private static void ParamEffectType(ref Config config, TagAttributes att)
		{
		}

		private Action<string, string> GetTagAction(string tag)
		{
			return null;
		}

		private void _003CRegTag_003Eb__61_0(string tag, TagAttributes att)
		{
		}

		private void _003CRegTag_003Eb__61_1(string tag, TagAttributes att)
		{
		}

		private void _003CRegTag_003Eb__61_2(string tag, TagAttributes att)
		{
		}

		private void _003CRegTag_003Eb__61_3(string tag, TagAttributes att)
		{
		}

		private void _003CRegTag_003Eb__61_4(string tag, TagAttributes att)
		{
		}

		private void _003CRegTag_003Eb__61_5(string tag, string param)
		{
		}

		private void _003CRegTag_003Eb__61_6(string tag, string param)
		{
		}

		private void _003CRegTag_003Eb__61_7(string tag, string param)
		{
		}

		private void _003CRegTag_003Eb__61_8(string tag, string param)
		{
		}

		private void _003CRegTag_003Eb__61_9(string tag, string param)
		{
		}

		private void _003CRegTag_003Eb__61_10(string tag, string param)
		{
		}

		private void _003CRegTag_003Eb__61_11(string tag, string param)
		{
		}

		private void _003CRegTag_003Eb__61_12(string tag, string param)
		{
		}

		private void _003CRegTag_003Eb__61_13(string tag, TagAttributes att)
		{
		}

		private void _003CRegTag_003Eb__61_14(string tag, string param)
		{
		}

		private void _003CRegTag_003Eb__61_15(string tag, TagAttributes att)
		{
		}

		private void _003CRegTag_003Eb__61_16(string tag, string param)
		{
		}

		private void _003CRegTag_003Eb__61_17(string tag, TagAttributes att)
		{
		}

		private void _003CRegTag_003Eb__61_18(string tag, TagAttributes att)
		{
		}
	}
}
