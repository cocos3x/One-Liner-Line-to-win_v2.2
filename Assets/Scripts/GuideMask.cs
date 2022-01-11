using UnityEngine;
using UnityEngine.UI;

public class GuideMask : Graphic
{
	public RectTransform inner_trans;

	private RectTransform outer_trans;

	private Vector2 inner_rt;

	private Vector2 inner_lb;

	private Vector2 outer_rt;

	private Vector2 outer_lb;

	public bool realtimeRefresh;

	protected override void Awake()
	{
	}

	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	private bool UnityEngine_002EICanvasRaycastFilter_002EIsRaycastLocationValid(Vector2 screenPos, Camera eventCamera)
	{
		return false;
	}

	private void CalcBounds()
	{
	}

	private void Update()
	{
	}
}
