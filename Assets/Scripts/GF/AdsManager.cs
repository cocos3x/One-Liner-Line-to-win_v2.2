using sdk.ad;
using sdk.ad.position;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GF
{
	public class AdsManager
	{
		public static string ServerIdName;

		private static BannerAd bannerAd;

		private static OpenAd openAd;

		private static List<FullAd> FullAds;

		private static List<RewardAd> RewardAds;

		private static Ads ads;

		public static void InitOpenAds()
		{
		}

		public static void Init()
		{
		}

		public static void ShowBanner(bool isShow, [Optional] AdEvent adEvent)
		{
		}

		public static void ShowOpenAd([Optional] AdEvent adEvent)
		{
		}

		public static void OnUIShow(FullAdsType adsType, [Optional] AdEvent adEvent)
		{
		}

		public static void OnUIShow(RewardAdsType adsType, [Optional] AdEvent adEvent)
		{
		}

		public static void OnAdClick(FullAdsType adsType, Action rewardAction, [Optional] Action failAction, [Optional] AdEvent adEvent)
		{
		}

		public static void OnAdClick(RewardAdsType adsType, Action rewardAction, [Optional] Action failAction, [Optional] AdEvent adEvent)
		{
		}
	}
}
