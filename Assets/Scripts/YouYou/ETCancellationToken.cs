using System;
using System.Collections.Generic;

namespace YouYou
{
	public class ETCancellationToken
	{
		private HashSet<Action> actions;

		public void Add(Action callback)
		{
		}

		public void Remove(Action callback)
		{
		}

		public bool IsCancel()
		{
			return false;
		}

		public void Cancel()
		{
		}

		private void Invoke()
		{
		}
	}
}
