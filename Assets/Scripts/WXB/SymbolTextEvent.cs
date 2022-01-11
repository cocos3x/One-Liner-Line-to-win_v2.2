using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace WXB
{
	public class SymbolTextEvent : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Serializable]
		public class OnClickEvent : UnityEvent<NodeBase>
		{
		}

		private SymbolText d_symbolText;

		public OnClickEvent OnClick;

		private RenderCache.BaseData d_down_basedata;

		private Vector2 localPosition;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnPointerDown(PointerEventData eventData)
		{
		}

		public void OnPointerUp(PointerEventData eventData)
		{
		}
	}
}
