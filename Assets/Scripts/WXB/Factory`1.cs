using System;

namespace WXB
{
	public class Factory<T> : IFactory where T : new()
	{
		public Action<T> free;

		public Factory(Action<T> f)
		{
		}

		public object create()
		{
			return null;
		}
	}
}
