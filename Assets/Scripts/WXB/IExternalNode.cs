using UnityEngine;

namespace WXB
{
	public interface IExternalNode
	{
		float width
		{
			get;
		}

		float height
		{
			get;
		}

		void OnDestroy();

		void OnRender(Owner owner, Rect rect);
	}
}
