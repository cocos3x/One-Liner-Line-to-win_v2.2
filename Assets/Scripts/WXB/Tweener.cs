using System;

namespace WXB
{
	public class Tweener
	{
		public enum Method
		{
			Linear,
			EaseIn,
			EaseOut,
			EaseInOut,
			BounceIn,
			BounceOut
		}

		public enum Style
		{
			Once,
			Loop,
			PingPong
		}

		public Method method;

		public Style style;

		public float duration;

		private float mDuration;

		private float mAmountPerDelta;

		private float mFactor;

		public Action<float, bool> OnUpdate;

		public float amountPerDelta => 0f;

		public float tweenFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void Update(float delta)
		{
		}

		public void Sample(float factor, bool isFinished)
		{
		}

		private float BounceLogic(float val)
		{
			return 0f;
		}

		public void Play(bool forward)
		{
		}

		public void ResetToBeginning()
		{
		}

		public void Toggle()
		{
		}
	}
}
