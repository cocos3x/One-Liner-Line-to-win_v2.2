using System;
using System.Collections.Generic;
using System.Text;

namespace WXB
{
	internal class DefaultES : ElementSegment
	{
		private enum CharType
		{
			Null,
			English,
			Chinese,
			Punctuation
		}

		

		public void Segment(string text, List<NodeBase.Element> widths, Func<char, float> fontwidth)
		{
		}
	}
}
