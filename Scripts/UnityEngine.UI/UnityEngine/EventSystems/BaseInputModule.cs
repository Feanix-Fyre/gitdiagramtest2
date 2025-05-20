using System;
using System.Collections.Generic;

namespace UnityEngine.EventSystems;

[RequireComponent(typeof(EventSystem))]
public abstract class BaseInputModule : UIBehaviour
{
	[NonSerialized]
	protected List<RaycastResult> m_RaycastResultCache;

	[SerializeField]
	private bool m_SendPointerHoverToParent;

	private AxisEventData m_AxisEventData;

	private EventSystem m_EventSystem;

	private BaseEventData m_BaseEventData;

	protected BaseInput m_InputOverride;

	private BaseInput m_DefaultInput;

	internal bool sendPointerHoverToParent
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public BaseInput input => null;

	public BaseInput inputOverride
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected EventSystem eventSystem => null;

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	public abstract void Process();

	protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates)
	{
		return default(RaycastResult);
	}

	protected static MoveDirection DetermineMoveDirection(float x, float y)
	{
		return default(MoveDirection);
	}

	protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone)
	{
		return default(MoveDirection);
	}

	protected static GameObject FindCommonRoot(GameObject g1, GameObject g2)
	{
		return null;
	}

	protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget)
	{
	}

	protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone)
	{
		return null;
	}

	protected virtual BaseEventData GetBaseEventData()
	{
		return null;
	}

	public virtual bool IsPointerOverGameObject(int pointerId)
	{
		return false;
	}

	public virtual bool ShouldActivateModule()
	{
		return false;
	}

	public virtual void DeactivateModule()
	{
	}

	public virtual void ActivateModule()
	{
	}

	public virtual void UpdateModule()
	{
	}

	public virtual bool IsModuleSupported()
	{
		return false;
	}

	public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData)
	{
		return 0;
	}
}
