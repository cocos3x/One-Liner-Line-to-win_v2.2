using System.Collections.Generic;
using UnityEngine;

public class AwardGameTypes : MonoBehaviour
{
	public static AwardGameTypes Instance;

	public List<int> gameIndexs;

	public string skinTitlePath;

	public string skinDebrisPath;

	public string skinCardsPath;

	public string skinTopPath;

	public string cashCurrencyPath;

	public string cashCurrencysPath;

	public string cashLogoPath;

	public List<Sprite> skinModelSprites;

	public List<Vector2> skinModelSpritesScales;

	public List<Vector2> gameCurrencySzie;

	public List<int> gameCurrencyScale;

	public List<int> gameCurrencyScaleLevel;

	public List<int> gameIntro;

	private int gameIndex;

	private int gameIndex1;

	private int gameIndex2;

	public int GameIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int GameIndex1
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int GameIndex2
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}
}
