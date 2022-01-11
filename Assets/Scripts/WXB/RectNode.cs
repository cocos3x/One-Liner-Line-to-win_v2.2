using System.Collections.Generic;
using UnityEngine;

namespace WXB
{
	public abstract class RectNode : NodeBase
	{
		public float width;

		public float height;

		public override float getHeight()
		{
			return 0f;
		}

		public override float getWidth()
		{
			return 0f;
		}

		protected override void ReleaseSelf()
		{
		}

		protected abstract void OnRectRender(RenderCache cache, Line line, Rect rect);

		public override void render(float maxWidth, RenderCache cache, ref float x, ref uint yline, List<Line> lines, float offsetX, float offsetY)
		{
		}
	}
}
