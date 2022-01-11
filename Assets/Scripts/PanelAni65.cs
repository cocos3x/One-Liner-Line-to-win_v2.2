using DG.Tweening;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class PanelAni65
{
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public Button closeBtn;

		internal void _003COpenAni1_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public Transform bg;

		public Action aciton;

		internal void _003CCloseAni1_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public GameObject roll;

		public Button doubleBtn;

		public Button nothanksBtn;

		public TweenCallback _003C_003E9__3;

		public TweenCallback _003C_003E9__2;

		public TweenCallback _003C_003E9__1;

		internal void _003COpenAni2_003Eb__0()
		{
		}

		internal void _003COpenAni2_003Eb__1()
		{
		}

		internal void _003COpenAni2_003Eb__2()
		{
		}

		internal void _003COpenAni2_003Eb__3()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static TweenCallback _003C_003E9__2_4;

		public static TweenCallback _003C_003E9__4_1;

		internal void _003COpenAni2_003Eb__2_4()
		{
		}

		internal void _003COpenAni3_003Eb__4_1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public Transform bg;

		internal void _003CCloseAni2_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public Button getBtn;

		internal void _003COpenAni3_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public Transform bg;

		internal void _003CCloseAni3_003Eb__0()
		{
		}
	}

	public static void OpenAni1(Transform bg, Image mask, [Optional] Button closeBtn)
	{
	}

	public static void CloseAni1(Transform bg, Image mask, Action removeListener, [Optional] Action aciton, [Optional] Button closeBtn)
	{
	}

	public static void OpenAni2(Transform bg, Image mask, GameObject roll, Button doubleBtn, Button nothanksBtn)
	{
	}

	public static void CloseAni2(Transform bg, Image mask, GameObject roll, Button doubleBtn, Button nothanksBtn, Action removeListener)
	{
	}

	public static void OpenAni3(Transform bg, Image mask, Button getBtn)
	{
	}

	public static void CloseAni3(Transform bg, Image mask, Button doubleBtn, Action removeListener)
	{
	}
}
