namespace WXB
{
	public class EffectDrawObjec : DrawObject
	{
		protected IEffect[] m_Effects;

		public override void UpdateSelf(float deltaTime)
		{
		}

		protected bool GetOpen(int index)
		{
			return false;
		}

		protected void SetOpen<T>(int index, bool value) where T : IEffect, new()
		{
		}
	}
}
