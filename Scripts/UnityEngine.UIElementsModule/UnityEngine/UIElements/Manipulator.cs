namespace UnityEngine.UIElements;

public abstract class Manipulator : IManipulator
{
	private VisualElement m_Target;

	public VisualElement target
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected abstract void RegisterCallbacksOnTarget();

	protected abstract void UnregisterCallbacksFromTarget();
}
