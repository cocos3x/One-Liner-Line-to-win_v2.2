using System.Collections.Generic;

public class CommonEvent
{
	public delegate void OnActionHandler(object userData);

	private static CommonEvent events;

	private Dictionary<string, LinkedList<OnActionHandler>> dic;

	public static CommonEvent Events => null;

	public void AddEventListener(string key, OnActionHandler handler)
	{
	}

	public void RemoveEventListener(string key, OnActionHandler handler)
	{
	}

	public void RemoveEventListenerAll(string key)
	{
	}

	public void Dispatch(string key, object userData)
	{
	}

	public void Dispatch(string key)
	{
	}
}
