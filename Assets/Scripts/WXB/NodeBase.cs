using System;
using System.Collections.Generic;
using UnityEngine;

namespace WXB
{
	public abstract class NodeBase
	{
		public struct Element
		{
			private List<float> widthList;

			private float totalWidth;

			public float totalwidth => 0f;

			public List<float> widths => null;

			public int count => 0;

		
		}

		public Owner owner;

		private float d_nextLineX;

		protected float NextLineX;

		public Anchor formatting;

		protected static List<Element> TempElementList;

		protected bool d_bNewLine;

		public bool d_bBlink;

		public bool d_bOffset;

		public Rect d_rectOffset;

		public Color d_color;

		public LineAlignment lineAlignment;

		private object _003Cuserdata_003Ek__BackingField;

		public Action<NodeBase> free;

		public object userdata
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long keyPrefix => 0L;

		public virtual void Reset(Owner o, Anchor hf)
		{
		}

		protected static float AlignedFormatting(Owner owner, Anchor formatting, float maxWidth, float curWidth, float lineX)
		{
			return 0f;
		}

		public abstract float getHeight();

		public abstract float getWidth();

		public void setNewLine(bool line)
		{
		}

		public bool isNewLine()
		{
			return false;
		}

		public abstract void render(float maxWidth, RenderCache cache, ref float x, ref uint yline, List<Line> lines, float offsetX, float offsetY);

		protected virtual void AlterX(ref float x, float maxWidth)
		{
		}

		public virtual void fill(ref Vector2 currentpos, List<Line> lines, float maxWidth, float pixelsPerUnit)
		{
		}

		

		public virtual void onMouseEnter()
		{
		}

		public virtual void onMouseLeave()
		{
		}

		public virtual void SetConfig(TextParser.Config c)
		{
		}

		public void Release()
		{
		}

		protected abstract void ReleaseSelf();
	}
}
