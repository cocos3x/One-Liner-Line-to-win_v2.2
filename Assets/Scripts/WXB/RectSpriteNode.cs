using System.Collections.Generic;
using UnityEngine;

namespace WXB
{
	public class RectSpriteNode : NodeBase
	{
		public Rect rect;

		private ISprite sprite;

		public Color color;

		public void SetSprite(ISprite sprite)
		{
		}

		public override float getHeight()
		{
			return 0f;
		}

		public override float getWidth()
		{
			return 0f;
		}

		public override void render(float maxWidth, RenderCache cache, ref float x, ref uint yline, List<Line> lines, float offsetX, float offsetY)
		{
		}

		public override void fill(ref Vector2 currentpos, List<Line> Lines, float maxWidth, float pixelsPerUnit)
		{
		}

		protected override void ReleaseSelf()
		{
		}
	}
}
