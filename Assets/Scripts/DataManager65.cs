using System.Collections.Generic;
using UnityEngine;

public class DataManager65 : MonoBehaviour
{
	public static DataManager65 Instance;

	public PiecesSkin65 piecesSkin;

	private List<PiecesSkin65.PiecesInfo> piecesInfos;

	private bool m_firstRun;

	private int m_level;

	private bool m_sound;

	private bool m_music;

	public bool FirstRun
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int Level
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool Sound
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool Music
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public float GetSkin(SkinGameType65 _skinGameType, int _index)
	{
		return 0f;
	}

	private void OnApplicationPause(bool pause)
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void SetVerify()
	{
	}

	private void ResetVerify()
	{
	}

	private void SaveSkin()
	{
	}

	public bool IsOutPut()
	{
		return false;
	}
}
