using System.Collections.Generic;
using UnityEngine;

namespace WXB
{
	public class TagAttributes
	{
		private Dictionary<string, string> d_attrs;

		public override string ToString()
		{
			return "";
		}

		public void Release()
		{
		}

		public void Add(string text)
		{
		}

		public void add(string attrName, string attrValue)
		{
		}

		public void remove(ref string attrName)
		{
		}

		public bool exists(string attrName)
		{
			return false;
		}

		public int getCount()
		{
			return 0;
		}

		public string getValue(string attrName)
		{
			return "";
		}

		public string getValueAsString(string attrName)
		{
			return "";
		}

		public Color getValueAsColor(string attrName, Color color)
		{
			return (Color)null;
		}

		public string getValueAsString(string attrName, string def)
		{
			return "";
		}

		public bool getValueAsBool(string attrName, bool def)
		{
			return false;
		}

		public int getValueAsInteger(string attrName, int def)
		{
			return 0;
		}

		public float getValueAsFloat(string attrName, float def)
		{
			return 0f;
		}
	}
}
