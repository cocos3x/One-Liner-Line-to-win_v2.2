using System.Collections.Generic;
using UnityEngine;

namespace WXB
{
	internal class LineNode : NodeBase
	{
		public Font font;

		public FontStyle fs;

		public int fontSize;

		private float height;

		public override float getHeight()
		{
			return 0f;
		}

		public override float getWidth()
		{
			return 0f;
		}

		public override void fill(ref Vector2 currentpos, List<Line> lines, float maxWidth, float pixelsPerUnit)
		{
		}

		public override void render(float maxWidth, RenderCache cache, ref float x, ref uint yline, List<Line> lines, float offsetX, float offsetY)
		{
		}

		protected override void ReleaseSelf()
		{
		}
	}
}
