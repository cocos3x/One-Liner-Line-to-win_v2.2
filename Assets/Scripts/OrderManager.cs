using System;
using UnityEngine;

[Serializable]
public class OrderManager : MonoBehaviour
{
	public GameObject orderPre;

	public static OrderManager Instance;

	public JsonManager jsonManager;

	public OrderCount orderCount;

	private int a_test;

	public int[] queueDays;

	public int A_Test
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

	public void UpData()
	{
	}

	public void Save()
	{
	}

	private void Read()
	{
	}

	private void Delete()
	{
	}

	public void Add()
	{
	}

	public int GetAdTimes()
	{
		return 0;
	}

	public int SetAdTimes()
	{
		return 0;
	}
}
