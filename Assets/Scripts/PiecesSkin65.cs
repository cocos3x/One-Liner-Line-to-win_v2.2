using System;
using System.Collections.Generic;

[Serializable]
public class PiecesSkin65
{
	public struct PiecesInfo
	{
		public int index;

		public float num;
	}

	public float ceilingSSkin;

	public float ceilingASkin;

	public float ceilingBSkin;

	public int[] cellAllSkin;

	public float[] mlPiecesSkin;

	public float[] ffPiecesSkin;

	public float[] rlPiecesSkin;

	public List<float> spacing;

	public List<int[]> mlSkin;

	public List<int[]> ffSkin;

	public List<int[]> rlSkin;

	private float[] pieceCountArry;

	public List<ADIntArray> ADCount;

	public List<CurTimeLongArray> CurDownTime;

	public List<TargetLongArray> targetTimeArry;

	public PiecesInfo SelectMlPieces(bool isSave = true)
	{
		return (PiecesInfo)null;
	}

	public PiecesInfo SelectFFPieces(bool isSave = true)
	{
		return (PiecesInfo)null;
	}

	public PiecesInfo SelectRlPieces(bool isSave = true)
	{
		return (PiecesInfo)null;
	}

	public void SetSkinCount(int gameType, int pieceType, float count)
	{
	}

	public int Inder(int[] totals, SkinGameType65 skinGameType65, bool boo = true)
	{
		return 0;
	}

	public int ChooseSpacing(float[] target)
	{
		return 0;
	}

	private bool CalculateSpacing(float low, float hight, float target)
	{
		return false;
	}

	public void CheckSkinS(float[] target, int spacingIndex, List<int[]> list)
	{
	}

	public float GetCount(int gameType, int pieceIndex)
	{
		return 0f;
	}

	public bool CheckISFull()
	{
		return false;
	}

	public bool CheckCurSkin(SkinGameType65 skinGameType65, int index)
	{
		return false;
	}

	public void SetDownTime(int gameType, int pieceType)
	{
	}
}
