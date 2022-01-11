using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class AdaptiveScreen65 : MonoBehaviour
{
	public static AdaptiveScreen65 Instance;

	private float m_bangScreen;

	private Vector3 m_deviationValue;

	public List<Transform> adaptiveTras;

	public Vector3 BangScreen => (Vector3)null;

	private void Awake()
	{
	}

	public void AdaptiveBangScreen([Optional] List<Transform> adaptive)
	{
	}
}
