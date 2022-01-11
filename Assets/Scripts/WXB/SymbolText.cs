using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace WXB
{
	public class SymbolText : Text, Owner
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Action<Draw> _003C_003E9__80_0;

			internal void _003CFreeDraws_003Eb__80_0(Draw d)
			{
			}
		}

		private static List<SymbolText> Temps;

		public static HashSet<SymbolText> ActiveList;

		private static TextParser sTextParser;

		[NonSerialized]
		protected LinkedList<NodeBase> mNodeList;

		[SerializeField]
		private float wordSpacing;

		public static Func<Font, float> WorldSpacingByFont;

		[SerializeField]
		private string m_SegmentElement;

		protected bool m_textDirty;

		protected bool m_renderNodeDirty;

		protected bool m_layoutDirty;

		[SerializeField]
		private int m_MinLineHeight;

		[SerializeField]
		private LineAlignment m_LineAlignment;

		private RenderCache mRenderCache;

		public List<Line> mLines;

		[SerializeField]
		private bool m_isCheckFontY;

		private Around d_Around;

		protected static List<NodeBase> s_nodebases;

		private Func<TagAttributes, IExternalNode> _003CgetExternalNode_003Ek__BackingField;

		private Vector2 last_size;

		private List<Draw> m_UsedDraws;

		public static Mesh WorkerMesh => null;

		protected TextParser Parser => null;

		public override string text
		{
			set
			{
			}
		}

		

		public int minLineHeight
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		

		public RenderCache renderCache => null;

		public bool isCheckFontY
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override float preferredWidth => 0f;

		public override float preferredHeight => 0f;

		public Around around => null;

		public ElementSegment elementSegment => null;

		public Func<TagAttributes, IExternalNode> getExternalNode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		static SymbolText()
		{
		}

		private static void RebuildForFont(Font f)
		{
		}

		public static void OnFontWordSpaceing(Font f)
		{
		}

		private float WXB_002EOwner_002EGetWordSpacing(Font font)
		{
			return 0f;
		}

		public bool isUsedFont(Font f)
		{
			return false;
		}

		public void SetRenderDirty()
		{
		}

		protected static void FreeNode(NodeBase node)
		{
		}

		public void Clear()
		{
		}

	
		protected override void Awake()
		{
		}

		public void DestroyDrawChild()
		{
		}

		protected override void UpdateGeometry()
		{
		}

		public float getNodeHeight()
		{
			return 0f;
		}

		public float getNodeWidth()
		{
			return 0f;
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected void LateUpdate()
		{
		}

		public override void SetAllDirty()
		{
		}

		private void UpdateByDirty()
		{
		}

		public override void Rebuild(CanvasUpdate update)
		{
		}

		protected virtual void SetTextDirty()
		{
		}

		protected override void UpdateMaterial()
		{
		}

		public void UpdateByTextDirty()
		{
		}

		public override void SetVerticesDirty()
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		public override void SetLayoutDirty()
		{
		}

		public void UpdateTextHeight()
		{
		}

		private void UpdateRenderElement()
		{
		}

		public void FontTextureChangedOther()
		{
		}

		protected void FreeDraws()
		{
		}

		public Draw GetDraw(DrawType type, long key, Action<Draw, object> oncreate, [Optional] object p)
		{
			return null;
		}

		private void _003CUpdateByTextDirty_003Eb__71_0(NodeBase nb)
		{
		}
	}
}
