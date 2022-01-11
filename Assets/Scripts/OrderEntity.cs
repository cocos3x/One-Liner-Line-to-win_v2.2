using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrderEntity : MonoBehaviour
{
	public GameObject activationObj;

	public GameObject verifyObj;

	public GameObject progressingObj;

	public GameObject failureObj;

	public int orderIndex;

	public OrderState orderState;

	public GameType gameType;

	public Image logo;

	public Image money;

	public int moneyValue;

	public Text moneyText;

	public Image a_progressBar;

	public Text a_progressText;

	public Text a_countDown;

	public Button v_ADBtn;

	public Text v_countDown;

	public Text p_ranking;

	public Button a_testADBtn;

	public Button a_testTimeBtn;

	public Button v_testRestartBtn;

	public Button v_decreaseTimeBtn;

	public List<GameObject> a_chainKeys;

	public List<Text> a_chainText;

	public Button a_keyBtn;

	public List<Sprite> a_keyBtnSprites;

	public GameObject a_ADS;

	public GameObject a_KEY;

	public GameObject v_24h;

	public GameObject v_2h;

	private long a_timer;

	private long v_timer;

	private int T;

	private int day;

	private int k0;

	private int k1;

	private void Start()
	{
	}

	private void GetOrder()
	{
	}

	public void SetOrder(OrderState _orderState, GameType _gameType, int _orderIndex, int _moneyValue)
	{
	}

	public void SetActivation()
	{
	}

	private void SetActivationCountDown()
	{
	}

	private void A_TestTime()
	{
	}

	private void A_TestAD()
	{
	}

	private void SetVerify()
	{
	}

	private void SetVerifyCountDown()
	{
	}

	private void VerifyAD()
	{
	}

	private void V_TestRestart()
	{
	}

	private void SetProgressing()
	{
	}

	private void SetRanking()
	{
	}

	private void KeysInit()
	{
	}

	private void KeysActivationBtn()
	{
	}

	private void KeysTestDecreaseTime()
	{
	}

	private void _003CVerifyAD_003Eb__40_0()
	{
	}

	private void _003CVerifyAD_003Eb__40_1()
	{
	}
}
