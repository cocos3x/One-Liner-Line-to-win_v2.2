using System;
using System.Collections.Generic;

namespace GF
{
	[Serializable]
	public class AdsInfo
	{
		public string adsName;

		public int adsId;

		public string adsServerId;

		public List<AdsFilter> adsFiletr;
	}
}
