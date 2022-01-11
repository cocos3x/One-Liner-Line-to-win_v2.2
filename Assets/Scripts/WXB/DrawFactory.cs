using System.Collections.Generic;
using UnityEngine;

namespace WXB
{
	public static class DrawFactory
	{
		public interface IFactory
		{
			Draw Create(GameObject go);

			void Free(Draw d);
		}

		public static class Pool<T> where T : MonoBehaviour, Draw, new()
		{
			public static List<T> EmptyList;

			public static List<T> UsedList;

			public static T GetOrCreate(GameObject parent)
			{
				return null;
			}

			public static void Free(T d)
			{
			}
		}

		public class Factory<T> : IFactory where T : MonoBehaviour, Draw, new()
		{
			public Draw Create(GameObject go)
			{
				return null;
			}

			public void Free(Draw d)
			{
			}
		}

		private static int s_total;

		private static IFactory DefaultFactory;

		private static Dictionary<DrawType, IFactory> factorys;

		static DrawFactory()
		{
		}

		private static IFactory Get(DrawType type)
		{
			return null;
		}

		public static Draw Create(GameObject go, DrawType type)
		{
			return null;
		}

		public static void Free(Draw go)
		{
		}
	}
}
