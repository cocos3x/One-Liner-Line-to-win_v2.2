using System;
using System.Collections.Generic;
using UnityEngine;

public class GameManager65 : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass88_0
	{
		public GameObject _obj;

		public GameManager65 _003C_003E4__this;

		internal void _003CDerminusRotate_003Eb__0()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__95_0;

		public static Action _003C_003E9__95_1;

		internal void _003C_002Ector_003Eb__95_0()
		{
		}

		internal void _003C_002Ector_003Eb__95_1()
		{
		}
	}

	public static GameManager65 Instance;

	public Mode mode;

	public GameObject editManager;

	public int levelIndex;

	public int tipCount;

	public LevelDataMsg dataMsg;

	public Color blockColor;

	public float billBasic;

	public int addTipNum;

	public int needBill;

	public bool isStart;

	public List<GameObject> selectBlock;

	public Transform tipLineParent;

	public Transform lineParent;

	public Transform moveParent;

	public List<GameObject> blocks;

	public GameObject blockOrigin;

	public Transform blockParent;

	public List<GameObject> cycleBlocks;

	public Transform cycleBlocksParent;

	public List<GameObject> selectLine;

	public List<GameObject> tipSelectLine;

	public List<GameObject> cycleLine;

	public Transform cycleLineParent;

	public int row;

	public int col;

	public PanelType panelType;

	public EmojiType emojiType;

	public Action StarAct;

	public Action SetTopAct;

	public Action TitleAct;

	public Transform targetMoney;

	public Transform targetAmazon;

	public Transform targetDebris;

	public bool isEmoji;

	public Action SadToHappy;

	public Transform titleBill;

	public TipType tipType;

	public Action<FlyObj, float, PiecesSkin65.PiecesInfo, float, float, bool> flyAct;

	public Action<BtnType, Action> titleReturnAct;

	public Action titlePlan;

	public Action titlePlanInit;

	public GameObject firstMask;

	public Transform firstFinger;

	public PUITYPE lastEUITYPE;

	public bool btnClick;

	public Color32 originColor;

	public Action nextAct;

	public bool firstSlider;

	public Action testAct;

	public Action<bool> gameCurrencyAct;

	public List<BoxInfo> m_boxs;

	public int _boxIndex;

	public GameObject[] testPanel;

	public Action inquiryAct;

	public int inquiryType;

	public int inquiryIndex;

	public Vector3 inquiryPos;

	public float diaphaneity;

	public float tipDiaphaneity;

	public Action<InsufficientType> insufficientAct;

	public Action<InsufficientType, Transform, int, int> productAct;

	public GameType gameType;

	public int gameMoney;

	public Action<FlyObj, float, float, float> exchangeRoll;

	public List<Transform> ordersPos;

	public ConditionType conditionType;

	public GameObject gift;

	public Transform titleTra;

	public int m_openTimer;

	private CashOutMode cashOutMode;

	private List<float> m_mults;

	private int totalLevel;

	private int circulationStart;

	private string path;

	public GameObject m_gift;

	private int _shake;

	public CashOutMode CashOutMode
	{
		get
		{
			//IL_0003: Expected I4, but got O
			return (CashOutMode)null;
		}
		set
		{
		}
	}

	public int V_Multi => 0;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void StarGame()
	{
	}

	private void ReadData(int _levelId)
	{
	}

	private void GetBlockColor()
	{
	}

	public void CreationLine(Vector3 origin, Vector3 destination, GameObject _originObj, GameObject _destinationObj, int _dir, bool isReal = true)
	{
	}

	public void RemoveLine(int removeBlockIndex, int m_dir)
	{
	}

	public void DerminusRotate(GameObject _obj, Vector3 origin, Vector3 destination)
	{
	}

	public void NextLevel()
	{
	}

	private void EndMovePanel()
	{
	}

	private void ClearLevelCycle()
	{
	}

	public void TriggerShake(bool boo = true)
	{
	}

	private void ScreenState()
	{
	}

	private void _003CEndMovePanel_003Eb__90_0()
	{
	}
}
