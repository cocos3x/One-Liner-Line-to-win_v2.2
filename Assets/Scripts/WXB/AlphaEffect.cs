namespace WXB
{
	public class AlphaEffect : IEffect
	{
		protected float last_update_time;

		protected bool isFoward;

		protected float space_timer;

		protected float alpha;

		public void UpdateEffect(Draw draw, float deltaTime)
		{
		}

		public void Release()
		{
		}
	}
}
