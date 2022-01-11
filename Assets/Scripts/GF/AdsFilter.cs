using System;

namespace GF
{
	[Serializable]
	public class AdsFilter
	{
		public int type;

		public string abKey;

		public int defaultValue;

		public AdsFilter(string abKey, int defaultValue)
		{
		}
	}
}
