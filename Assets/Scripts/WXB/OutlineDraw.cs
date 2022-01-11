using UnityEngine;
using UnityEngine.UI;

namespace WXB
{
	public class OutlineDraw : EffectDrawObjec, ICanvasElement
	{
		private DrawLineStruct m_Data;

		private float currentWidth;

		private float maxWidth;

		

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

		public override void UpdateSelf(float deltaTime)
		{
		}

		public void AddLine(TextNode n, Vector2 left, float width, float height, Color color, Vector2 uv, int speed)
		{
		}

		public override void UpdateMaterial(Material mat)
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
