using System;
using System.Collections.Generic;

public class LocalizationEvent
{
	private static Dictionary<LocalizationEventType, Delegate> dicEvents;

	public static void AddListener(LocalizationEventType eventType, CallBack callback)
	{
	}

	public static void RemoveListener(LocalizationEventType eventType, CallBack callback)
	{
	}

	public static void BroadCast(LocalizationEventType eventType)
	{
	}

	private static void OnListenerAdding(LocalizationEventType eventType, Delegate callback)
	{
	}

	private static void OnListenerRemoving(LocalizationEventType eventType, Delegate callback)
	{
	}

	private static void OnListenerRemoved(LocalizationEventType eventType)
	{
	}
}
