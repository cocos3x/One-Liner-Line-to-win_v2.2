using System;
using UnityEngine;

namespace WXB
{
	[Serializable]
	public class DSprite : ISprite
	{
		public Sprite sprite;

		public int width => 0;

		public int height => 0;

		public DSprite(Sprite sprite)
		{
		}

		public void AddRef()
		{
		}

		public void SubRef()
		{
		}

		public Sprite Get()
		{
			return null;
		}
	}
}
