using UnityEngine;

namespace WXB
{
	public class CartoonNode : RectNode
	{
		public Cartoon cartoon;

		public override float getWidth()
		{
			return 0f;
		}

		protected override void OnRectRender(RenderCache cache, Line line, Rect rect)
		{
		}

		protected override void ReleaseSelf()
		{
		}
	}
}
