using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace WXB
{
	public class ISpriteDraw : EffectDrawObjec, ICanvasElement
	{
		private List<ISpriteData> mData;

		private bool isRebuild;

		private bool isCurrentEmpty;

		public override DrawType type => (DrawType)null;

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

		public void Add(ISprite sprite, Vector2 leftPos, float width, float height, Color color)
		{
		}

		public override void UpdateSelf(float deltaTime)
		{
		}

		private bool isNeedRebuild()
		{
			return false;
		}

		public void Rebuild(CanvasUpdate executing)
		{
		}

		public override void Release()
		{
		}

		private void ReleaseSelf()
		{
		}

		private void OnDestroy()
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
