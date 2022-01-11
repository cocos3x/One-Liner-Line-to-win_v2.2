using System.Collections.Generic;
using UnityEngine;
using WXB;

public class Test : MonoBehaviour
{
	[SerializeField]
	private SymbolLabel label;

	[SerializeField]
	private GameObject prefab;

	private int total;

	private Dictionary<string, IExternalNode> Nodes;

	private int id_flag;

	private void Awake()
	{
	}

	private IExternalNode GetExternalNode(TagAttributes tag)
	{
		return null;
	}

	private void OnGUI()
	{
	}
}
