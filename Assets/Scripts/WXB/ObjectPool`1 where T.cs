using System.Collections.Generic;
using UnityEngine.Events;

namespace WXB
{
	public class ObjectPool<T> where T : new()
	{
		private readonly Stack<T> m_Stack;

		private readonly UnityAction<T> m_ActionOnGet;

		private readonly UnityAction<T> m_ActionOnRelease;

		private int _003CcountAll_003Ek__BackingField;

		public int countAll
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public int countActive => 0;

		public int countInactive => 0;

		public ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease)
		{
		}

		public T Get()
		{
			return (T)null;
		}

		public void Release(T element)
		{
		}
	}
}
