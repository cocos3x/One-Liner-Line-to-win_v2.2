using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class AdaptiveScreen65 : MonoBehaviour
{
	public static AdaptiveScreen65 Instance;

	private float m_bangScreen;

	private Vector3 m_deviationValue;

	public List<Transform> adaptiveTras;



	private void Awake()
	{
	}

	public void AdaptiveBangScreen([Optional] List<Transform> adaptive)
	{
	}
}
