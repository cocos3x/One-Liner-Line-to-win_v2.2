using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace WXB
{
	public class CartoonDraw : EffectDrawObjec, ICanvasElement
	{
		private Cartoon _003Ccartoon_003Ek__BackingField;

		private int frameIndex;

		private float mDelta;

		private List<SpriteData> mData;

		private bool currentIsEmpty;

	

		public Cartoon cartoon
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isOpenAlpha
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isOpenOffset
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void UpdateAnim(float deltaTime)
		{
		}

		public void Add(Vector2 leftPos, float width, float height, Color color)
		{
		}

		public override void UpdateSelf(float deltaTime)
		{
		}

		public void Rebuild(CanvasUpdate executing)
		{
		}

		public override void Release()
		{
		}

		public void GraphicUpdateComplete()
		{
		}

		public bool IsDestroyed()
		{
			return false;
		}

		public void LayoutComplete()
		{
		}

		private Transform UnityEngine_002EUI_002EICanvasElement_002Eget_transform()
		{
			return null;
		}
	}
}
