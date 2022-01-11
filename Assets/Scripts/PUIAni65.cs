using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class PUIAni65 : MonoBehaviour
{

	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public Button _close;

		internal void _003CCloseAni1_003Eb__0()
		{
		}
	}


	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public CanvasGroup canvasGroup;

		internal float _003CCloseAni2_003Eb__0()
		{
			return 0f;
		}

		internal void _003CCloseAni2_003Eb__1(float x)
		{
		}
	}



	public static PUIAni65 Instance;

	private void Awake()
	{
	}

	public void OpenAni1(Image _mask, Button _close, Transform _content, [Optional] Action _action)
	{
	}

	public void CloseAni1(Image _mask, Button _close, Transform _content, Action _action, float _timer1 = 0.3f, float _timer2 = 0.4f)
	{
	}

	public void OpenAni2(Transform _content, Action _action)
	{
	}

	public void CloseAni2(CanvasGroup canvasGroup, Action _action)
	{
	}

	public void OpenAni3(Transform _content, Image _mask, GameObject roll, Button doubleBtn, Button nothanksBtn, Action _action)
	{
	}

	public void OpenAni3_2(Transform _content, Image _mask, GameObject roll, Button doubleBtn, Button nothanksBtn, Button claimBtn, Action _action)
	{
	}

	public void CloseAni3(Transform _content, Image _mask, GameObject roll, Button doubleBtn, Button nothanksBtn, Action _action)
	{
	}

	public void OpenAni4(Transform _content, Image _mask, Button getBtn, [Optional] Action _action)
	{
	}

	public void CloseAni4(Transform _content, Image _mask, Button doubleBtn, Action _action)
	{
	}

	public void OpenAni5(Image _mask, Transform _content, Action _action)
	{
	}

	public void OpenAni6(Image _mask, Action _action)
	{
	}
}
