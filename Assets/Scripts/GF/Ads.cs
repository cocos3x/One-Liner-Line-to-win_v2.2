using System;
using System.Collections.Generic;

namespace GF
{
	[Serializable]
	public class Ads
	{
		public string serverIdKey;

		public string adsIntervalKey;

		public AdsInfo bannerAds;

		public AdsInfo openAds;

		public List<AdsInfo> fullAds;

		public List<AdsInfo> rewardAds;
	}
}
