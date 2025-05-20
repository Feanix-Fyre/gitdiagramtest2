using System;
using System.Collections.Generic;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

namespace UnityEngine.EventSystems;

[DisallowMultipleComponent]
[AddComponentMenu("Event/Event System")]
public class EventSystem : UIBehaviour
{
	private struct UIToolkitOverrideConfig
	{
		public EventSystem activeEventSystem;

		public bool sendEvents;

		public bool createPanelGameObjectsOnStart;
	}

	private List<BaseInputModule> m_SystemInputModules;

	private BaseInputModule m_CurrentInputModule;

	private static List<EventSystem> m_EventSystems;

	[FormerlySerializedAs("m_Selected")]
	[SerializeField]
	private GameObject m_FirstSelected;

	[SerializeField]
	private bool m_sendNavigationEvents;

	[SerializeField]
	private int m_DragThreshold;

	private GameObject m_CurrentSelected;

	private bool m_HasFocus;

	private bool m_SelectionGuard;

	private BaseEventData m_DummyData;

	private static readonly Comparison<RaycastResult> s_RaycastComparer;

	private static UIToolkitOverrideConfig s_UIToolkitOverride;

	private bool m_Started;

	private bool m_IsTrackingUIToolkitPanels;

	public static EventSystem current
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool sendNavigationEvents
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int pixelDragThreshold
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public BaseInputModule currentInputModule => null;

	public GameObject firstSelectedGameObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GameObject currentSelectedGameObject => null;

	[Obsolete("lastSelectedGameObject is no longer supported")]
	public GameObject lastSelectedGameObject => null;

	public bool isFocused => false;

	public bool alreadySelecting => false;

	private BaseEventData baseEventDataCache => null;

	private bool isUIToolkitActiveEventSystem => false;

	private bool sendUIToolkitEvents => false;

	private bool createUIToolkitPanelGameObjectsOnStart => false;

	protected EventSystem()
	{
	}

	public void UpdateModules()
	{
	}

	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer)
	{
	}

	public void SetSelectedGameObject(GameObject selected)
	{
	}

	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs)
	{
		return 0;
	}

	public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults)
	{
	}

	public bool IsPointerOverGameObject()
	{
		return false;
	}

	public bool IsPointerOverGameObject(int pointerId)
	{
		return false;
	}

	public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = true, bool createPanelGameObjectsOnStart = true)
	{
	}

	private void StartTrackingUIToolkitPanels()
	{
	}

	private void StopTrackingUIToolkitPanels()
	{
	}

	private void CreateUIToolkitPanelGameObject(BaseRuntimePanel panel)
	{
	}

	protected override void Start()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	private void TickModules()
	{
	}

	protected virtual void OnApplicationFocus(bool hasFocus)
	{
	}

	protected virtual void Update()
	{
	}

	private void ChangeEventModule(BaseInputModule module)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
