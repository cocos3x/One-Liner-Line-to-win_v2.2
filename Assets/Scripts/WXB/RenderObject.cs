using System;
using UnityEngine;

namespace WXB
{
	public class RenderObject : MonoBehaviour
	{
		private RectTransform rect;

		[NonSerialized]
		private CanvasRenderer m_CanvasRender;

		public CanvasRenderer canvasRenderer => null;

		protected virtual void OnTransformParentChanged()
		{
		}

		protected void OnDisable()
		{
		}

		protected void Start()
		{
		}

		private void UpdateRect()
		{
		}

		public void FillMesh(Mesh workerMesh)
		{
		}

		public void UpdateMaterial(Material mat, Texture texture)
		{
		}
	}
}
