using UnityEngine;

namespace WXB
{
	public class SpriteNode : RectNode
	{
		private ISprite sprite;

		public void SetSprite(ISprite sprite)
		{
		}

		protected override void OnRectRender(RenderCache cache, Line line, Rect rect)
		{
		}

		protected override void ReleaseSelf()
		{
		}
	}
}
