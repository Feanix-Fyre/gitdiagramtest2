using System;

namespace UnityEngine.InputSystem;

[Serializable]
public struct InputActionProperty : IEquatable<InputActionProperty>, IEquatable<InputAction>, IEquatable<InputActionReference>
{
	[SerializeField]
	private bool m_UseReference;

	[SerializeField]
	private InputAction m_Action;

	[SerializeField]
	private InputActionReference m_Reference;

	public InputAction action => null;

	public InputActionReference reference => null;

	internal InputAction serializedAction => null;

	internal InputActionReference serializedReference => null;

	public InputActionProperty(InputAction action)
	{
		m_UseReference = false;
		m_Action = null;
		m_Reference = null;
	}

	public InputActionProperty(InputActionReference reference)
	{
		m_UseReference = false;
		m_Action = null;
		m_Reference = null;
	}

	public bool Equals(InputActionProperty other)
	{
		return false;
	}

	public bool Equals(InputAction other)
	{
		return false;
	}

	public bool Equals(InputActionReference other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(InputActionProperty left, InputActionProperty right)
	{
		return false;
	}

	public static bool operator !=(InputActionProperty left, InputActionProperty right)
	{
		return false;
	}
}
