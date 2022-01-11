using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Serialization<T>
{
	[SerializeField]
	private List<T> Data;

	public List<T> ToList()
	{
		return null;
	}

	public Serialization(List<T> data)
	{
	}
}
