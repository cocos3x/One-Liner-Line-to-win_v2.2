using System.Collections.Generic;

namespace WXB
{
	public class XSpaceNode : NodeBase
	{
		public float d_offset;

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

		protected override void ReleaseSelf()
		{
		}
	}
}
