using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace WXB
{
	public class TextNode : NodeBase
	{
		private struct Helper
		{
			public RenderCache cache;

			public float x;

			public uint yline;

			public List<Line> lines;

			public Anchor xFormatting;

			public float offsetX;

			public float offsetY;

			public StringBuilder sb;

			public float pixelsPerUnit;

			private Vector2 pt;

			private float alignedX;

			private TextNode node;

			private float maxWidth;

			private float fHeight;

		

			private void DrawCurrent(bool isnewLine, Around around, float lineX)
			{
			}

			public void Draw(TextNode n, float lineX)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass9_0
		{
			public TextNode _003C_003E4__this;

			public int fontsize;

			public float wordSpacing;

			public float unitsPerPixel;

			internal float _003CUpdateWidthList_003Eb__0(char code)
			{
				return 0f;
			}
		}

		private Vector2 size;

		private List<Element> d_widthList;

		public string d_text;

		public Font d_font;

		public int d_fontSize;

		public FontStyle d_fontStyle;

		public bool d_bUnderline;

		public bool d_bStrickout;

		public bool d_bDynUnderline;

		public bool d_bDynStrickout;

		public int d_dynSpeed;

		public EffectType effectType;

		public Color effectColor;

		public Vector2 effectDistance;



		public new long keyPrefix => 0L;

		public bool isFontSame(TextNode n)
		{
			return false;
		}

		public override void Reset(Owner o, Anchor hf)
		{
		}

		protected virtual bool isUnderLine()
		{
			return false;
		}

		public override float getHeight()
		{
			return 0f;
		}

		public override float getWidth()
		{
			return 0f;
		}

		public virtual bool IsHyText()
		{
			return false;
		}

		public override void render(float maxWidth, RenderCache cache, ref float x, ref uint yline, List<Line> lines, float offsetX, float offsetY)
		{
		}

		public override void SetConfig(TextParser.Config c)
		{
		}

		protected override void ReleaseSelf()
		{
		}
	}
}
