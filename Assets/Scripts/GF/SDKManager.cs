using DG.Tweening;
using sdk.ad;
using sdk.bridge.interf;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace GF
{
	public class SDKManager
	{
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public Text progressText;

			public Vector3 _origen;

			public RectTransform progress;

			public Action callback;

			internal void _003COnGameEnter_003Eb__0()
			{
			}

			internal void _003COnGameEnter_003Eb__1()
			{
			}
		}

		public static string BulyId;

		private static Tweener _loadTween;

		public static void OnGameInit()
		{
		}

		public static void OnGameEnter(RectTransform progress, Action callback, [Optional] Text progressText)
		{
		}

		public static bool IsSdkReady()
		{
			return false;
		}

	

		public static bool IsRateOpen()
		{
			return false;
		}

		public static bool IsFunOpen()
		{
			return false;
		}

		public static void AddAbListener(AbAction action)
		{
		}

		public static void RemoveAbListener(AbAction action)
		{
		}

		public static void Track512Commit(string name, [Optional] string value1, [Optional] string value2, [Optional] Dictionary<string, string> param)
		{
		}

		public static void Track513Commit(string name, [Optional] string value1, [Optional] string value2, [Optional] Dictionary<string, string> param)
		{
		}

		public static bool IsUpdateUser()
		{
			return false;
		}

		public static void Jump2Email(string email = "")
		{
		}

		public static void Jump2PrivacyCenter(string url = "")
		{
		}

		public static void Jump2TermsUse(string url = "")
		{
		}

		public static void Jump2GpMark()
		{
		}

		public static void Jump2FbPage()
		{
		}

	
		public static void CheckShare()
		{
		}

		public static void EnterShare(int from)
		{
		}

		public static void SetShareAppSwitch(bool open)
		{
		}

		public static void AddShareListener(ShareAction action)
		{
		}

		public static void RemoveShareListener(ShareAction action)
		{
		}
	}
}
