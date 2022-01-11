using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace WXB
{
	public class RenderCache
	{
		public abstract class BaseData
		{
			private Rect m_Rect;

			public NodeBase node;

			private Line _003Cline_003Ek__BackingField;

			private int _003CsubMaterial_003Ek__BackingField;

			public Rect rect
			{
				get
				{
					return (Rect)null;
				}
				set
				{
				}
			}

			public Line line
			{
				get
				{
					return null;
				}
				protected set
				{
				}
			}

			public virtual bool isAlignByGeometry => false;

			public int subMaterial
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			protected LineAlignment lineAlignment => (LineAlignment)null;

			public bool isContain(Vector2 pos)
			{
				return false;
			}

			public abstract void Render(VertexHelper vh, Rect area, Vector2 offset, float pixelsPerUnit);

			public virtual void OnMouseEnter()
			{
			}

			public virtual void OnMouseLevel()
			{
			}

			public virtual void OnMouseUp(PointerEventData eventData)
			{
			}

			public override string ToString()
			{
				return "";
			}

			public virtual void Release()
			{
			}

			protected abstract void OnRelease();

			public virtual void OnAlignByGeometry(ref Vector2 offset, float pixelsPerUnit)
			{
			}

			public virtual void OnLineYCheck(float pixelsPerUnit)
			{
			}

			public virtual Vector2 GetStartLeftBottom(float unitsPerPixel)
			{
				return (Vector2)null;
			}
		}

		private struct Key
		{
			private sealed class _003C_003Ec__DisplayClass8_0
			{
				public Texture texture;

				internal void _003CGet_003Eb__0(Draw d, object p)
				{
				}
			}

			public int subMaterial;

			public bool isBlink;

			public bool isOffset;

			public Rect offsetRect;

			public List<BaseData> nodes;

			public DrawType drawType => (DrawType)null;

			public bool IsEquals(BaseData bd)
			{
				return false;
			}

			public Draw Get(Owner owner, Texture texture)
			{
				return null;
			}
		}

		private class CartoonData : BaseData
		{
			public Cartoon cartoon;

			public void Reset(NodeBase n, Cartoon c, Rect r, Line l)
			{
			}

			protected override void OnRelease()
			{
			}

			public override void Render(VertexHelper vh, Rect area, Vector2 offset, float pixelsPerUnit)
			{
			}

			private void _003CRender_003Eb__3_0(Draw d, object p)
			{
			}
		}

		private class SpriteData : BaseData
		{
			public ISprite sprite;

			public void Reset(NodeBase n, ISprite s, Rect r, Line l)
			{
			}

			protected override void OnRelease()
			{
			}

			public override void Render(VertexHelper vh, Rect area, Vector2 offset, float pixelsPerUnit)
			{
			}
		}

		private class ISpriteData : SpriteData
		{
			public override void Render(VertexHelper vh, Rect area, Vector2 offset, float pixelsPerUnit)
			{
			}

			private void _003CRender_003Eb__0_0(Draw d, object p)
			{
			}
		}

		public class TextData : BaseData
		{
			private sealed class _003C_003Ec__DisplayClass19_0
			{
				public TextNode node;
			}

			private sealed class _003C_003Ec__DisplayClass19_1
			{
				public Texture mainTexture;

				public _003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals1;

				internal void _003CRender_003Eb__0(Draw d, object p)
				{
				}
			}

			private sealed class _003C_003Ec__DisplayClass19_2
			{
				public Texture mainTexture;

				public _003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals2;

				internal void _003CRender_003Eb__1(Draw d, object p)
				{
				}
			}

			public string text;

			private const float line_height = 2f;

			private static CharacterInfo s_Info;

			private static float s_xMin;

			private static float s_yMin;

			private static float s_xMax;

			private static float s_yMax;

			private static Vector3 s_point;

			public override bool isAlignByGeometry => false;

			public TextNode Node
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public void Reset(TextNode n, string t, Rect r, Line l)
			{
			}

			protected override void OnRelease()
			{
			}

			private static TextAnchor SwitchTextAnchor(TextAnchor anchor)
			{
				//IL_0003: Expected I4, but got O
				return (TextAnchor)null;
			}

			public override void OnLineYCheck(float pixelsPerUnit)
			{
			}

			public override void OnAlignByGeometry(ref Vector2 offset, float pixelsPerUnit)
			{
			}

			public override Vector2 GetStartLeftBottom(float unitsPerPixel)
			{
				return (Vector2)null;
			}

			public override void Render(VertexHelper vh, Rect area, Vector2 offset, float pixelsPerUnit)
			{
			}

			public override void OnMouseEnter()
			{
			}

			public override void OnMouseLevel()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass20_0
		{
			public BaseData bd;

			internal bool _003CRender_003Eb__0(Key k)
			{
				return false;
			}
		}

		private Owner mOwner;

		private List<BaseData> DataList;

		private List<Texture> _003Cmaterials_003Ek__BackingField;

		private static List<Key> s_keys;

		private Vector2 DrawOffset;

		public List<Texture> materials
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public bool isEmpty => false;

		public RenderCache(Owner st)
		{
		}

		public void Release()
		{
		}

		public void cacheText(Line l, TextNode n, string text, Rect rect)
		{
		}

		public void cacheISprite(Line l, NodeBase n, ISprite sprite, Rect rect)
		{
		}

		public void cacheSprite(Line l, NodeBase n, ISprite sprite, Rect rect)
		{
		}

		public void cacheCartoon(Line l, NodeBase n, Cartoon cartoon, Rect rect)
		{
		}

		public void OnAlignByGeometry(ref Vector2 offset, float pixelsPerUnit, float firstHeight)
		{
		}

		public void OnCheckLineY(float pixelsPerUnit)
		{
		}

		public void Render(VertexHelper vh, Rect rect, Vector2 offset, float pixelsPerUnit, Mesh workerMesh, Material defaultMaterial)
		{
		}

		public BaseData Get(Vector2 pos)
		{
			return null;
		}

		public void Get(List<BaseData> bds, NodeBase nb)
		{
		}
	}
}
