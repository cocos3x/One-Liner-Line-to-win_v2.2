using System;

namespace WXB
{
	[Serializable]
	public class Cartoon
	{
		public class Frame
		{
			public ISprite sprite;

			public float delay;
		}

		public string name;

		public Frame[] frames;

		public float space;

		public int width;

		public int height;
	}
}
