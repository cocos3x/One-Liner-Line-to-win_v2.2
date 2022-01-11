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

		private static CharType GetCharType(char c)
		{
			//IL_0003: Expected I4, but got O
			return (CharType)null;
		}

		private static NodeBase.Element Create(StringBuilder sb, Func<char, float> fontwidth)
		{
			return (NodeBase.Element)null;
		}

		public void Segment(string text, List<NodeBase.Element> widths, Func<char, float> fontwidth)
		{
		}
	}
}
