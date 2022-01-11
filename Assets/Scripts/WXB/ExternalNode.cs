using UnityEngine;

namespace WXB
{
	public class ExternalNode : RectNode
	{
		private IExternalNode node;

		public void Set(IExternalNode node)
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

		protected override void ReleaseSelf()
		{
		}

		protected override void OnRectRender(RenderCache cache, Line line, Rect rect)
		{
		}
	}
}
