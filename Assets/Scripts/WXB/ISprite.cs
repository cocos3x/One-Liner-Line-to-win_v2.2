using UnityEngine;

namespace WXB
{
	public interface ISprite
	{
		int width
		{
			get;
		}

		int height
		{
			get;
		}

		void AddRef();

		void SubRef();

		Sprite Get();
	}
}
