using UnityEngine;

namespace WXB
{
	public class HyperlinkNode : TextNode
	{
		private bool isEnter;

		public Color hoveColor;

		public string d_link;



		public override void onMouseEnter()
		{
		}

		public override void onMouseLeave()
		{
		}

		public override bool IsHyText()
		{
			return false;
		}

		protected override void ReleaseSelf()
		{
		}
	}
}
