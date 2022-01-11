using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditManager65 : MonoBehaviour
{
	public static EditManager65 Instance;

	public LevelDataMsg levelMsg;

	public int level;

	public int col;

	public int row;

	public int destIndex;

	public List<int> blockIndex;

	public float xOffset;

	public float yOffset;

	public GameObject blocks;

	public Transform blockPar;

	public Button levelBtn;

	public Button saveBtn;

	public Button upBtn;

	public Button downBtn;

	public Button leftBtn;

	public Button rightBtn;

	public Button clearBtn;

	public Transform lineParent;

	private int m_row;

	private int m_col;

	private bool m_first;

	public int Row => 0;

	public int Col => 0;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void CreateLevel(LevelDataMsg msg)
	{
	}

	private void SetLevel()
	{
	}

	private void SaveLevel()
	{
	}

	private void UpMove()
	{
	}

	private void DownMove()
	{
	}

	private void LeftMove()
	{
	}

	private void RightMove()
	{
	}

	private void MoveBlockLine(Vector3 _vec)
	{
	}

	private void Clear()
	{
	}
}
