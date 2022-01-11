using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace WXB
{
	public class DrawLineStruct : DrawStruct
	{
		public struct Line
		{
			public Vector2 leftPos;

			public float width;

			public float height;

			public Vector2 uv;

			public Color color;

			public int dynSpeed;

			public TextNode node;

			public void Render(VertexHelper vh, ref float curwidth)
			{
			}
		}

		public List<Line> lines;

		public void Render(float width, VertexHelper vh)
		{
		}
	}
}
