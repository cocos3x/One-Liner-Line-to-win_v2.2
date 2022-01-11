using System.Collections.Generic;

public class LevelDataMsg
{
	public int level;

	public int col;

	public int row;

	public int destIndex;

	public List<int> blockIndex;

	public float xOffset;

	public float yOffset;

	public LevelDataMsg()
	{
	}

	public LevelDataMsg(int level, int row, int col, int destindex, List<int> index)
	{
	}
}
