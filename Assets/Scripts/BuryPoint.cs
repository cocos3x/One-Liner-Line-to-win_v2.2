using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class BuryPoint : MonoBehaviour
{
	public static BuryPoint _instance;

	private List<float> progressPos;

	private int funnel;

	public List<string> funnelString;

	private int paralle;

	private List<string> paralleFunnel;

	private int giftLimit;

	public static BuryPoint Instance => null;

	public int Funnel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Paralle
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int gift
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Track512Commit(string name, [Optional] string value1, [Optional] string value2, [Optional] Dictionary<string, string> param)
	{
	}

	public void s_load()
	{
	}

	public void get_NewbieGift()
	{
	}

	public void diamond_GuideEnter(int _id, string _describe)
	{
	}

	public void diamond_GuideComplete(int _id, string _describe)
	{
	}

	public void s_Introduction(int _id, string _describe)
	{
	}

	public void Introduction_End(int _id, string _describe)
	{
	}

	public void game_start(int _totalReels, int _todayReels)
	{
	}

	public void c_gamepage(int _index)
	{
	}

	public void connection_cube()
	{
	}

	public void use_props(int _timer, int _totalReels)
	{
	}

	public void show_success(int _totalReels, float _diamondNum)
	{
	}

	public void Diamonds_up(int _behavior, float _diamondNum)
	{
	}

	public void bonus_click()
	{
	}

	public void extra_bonus_click(int _extraBoxIndex, float _diamondNum)
	{
	}

	public void get_Diamonds(float _diamondNum, int _totalReels)
	{
	}

	public void get_coins(float _coinNum, int _totalReels)
	{
	}

	public void get_skin()
	{
	}

	public void setting_show()
	{
	}

	public void c_setting(int _behavior)
	{
	}

	public void s_redeem()
	{
	}

	public void c_Selectgame(int _gameType)
	{
	}

	public void c_redeem(int _behavior, int _result)
	{
	}

	public void video_get_skin()
	{
	}

	public void skin_show(int _gameType)
	{
	}

	public void get_progress(float _diamond, float _diamondLimit)
	{
	}

	public void FunnelFlow(int _index)
	{
	}

	public void ParallelFlow(int _triggerDot, int _index)
	{
	}

	public void user_change()
	{
	}

	public void gift_show()
	{
	}

	public void gift_yes()
	{
	}

	public void gift_no()
	{
	}
}
