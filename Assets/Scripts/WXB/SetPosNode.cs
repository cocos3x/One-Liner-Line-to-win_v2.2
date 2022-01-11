using System.Collections.Generic;

namespace WXB
{
	public class SetPosNode : NodeBase
	{
		public TypePosition type;

		public float d_value;

		public override float getHeight()
		{
			return 0f;
		}

		public override float getWidth()
		{
			return 0f;
		}

		protected override void AlterX(ref float x, float maxWidth)
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
