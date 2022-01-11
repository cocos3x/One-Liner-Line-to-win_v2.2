using UnityEngine;

namespace WXB
{
	public class OffsetEffect : IEffect
	{
		private Vector2 offset;

		public float xMin;

		public float yMin;

		public float xMax;

		public float yMax;

		public float speed;

		private Tweener tweener;

		private Draw current;

		public void UpdateEffect(Draw draw, float deltaTime)
		{
		}

		private void UpdateOffset(float val, bool isFin)
		{
		}

		public void Release()
		{
		}
	}
}
