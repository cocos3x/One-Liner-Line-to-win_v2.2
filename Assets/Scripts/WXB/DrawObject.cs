using UnityEngine;

namespace WXB
{
	public class DrawObject : MonoBehaviour
	{
		private RectTransform _003CrectTransform_003Ek__BackingField;

		private long _003Ckey_003Ek__BackingField;

		private CanvasRenderer _003CcanvasRenderer_003Ek__BackingField;

		private Material m_Material;

		private Texture m_Texture;

		public RectTransform rectTransform
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

	
		public virtual long key
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public CanvasRenderer canvasRenderer
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Material srcMat
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture texture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual void OnTransformParentChanged()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected void OnEnable()
		{
		}

		public void OnInit()
		{
		}

		protected void Start()
		{
		}

		protected virtual void Init()
		{
		}

		protected void Awake()
		{
		}

		protected void UpdateRect(Vector2 offset)
		{
		}

		public virtual void UpdateSelf(float deltaTime)
		{
		}

		public void FillMesh(Mesh workerMesh)
		{
		}

		public virtual void UpdateMaterial(Material mat)
		{
		}

		public virtual void Release()
		{
		}

		public void DestroySelf()
		{
		}
	}
}
