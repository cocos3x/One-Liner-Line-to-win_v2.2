using System;

namespace WXB
{
	public struct PD<T> : IDisposable where T : new()
	{
		public T value;

		private Action<T> free;

	
		public void Dispose()
		{
		}
	}
}
