using System;

namespace UnityEngine.InputSystem.Utilities;

internal sealed class SavedStructState<T> : ISavedState where T : struct
{
	public delegate void TypedRestore(ref T state);

	private T m_State;

	private TypedRestore m_RestoreAction;

	private Action m_StaticDisposeCurrentState;

	internal SavedStructState(ref T state, TypedRestore restoreAction, Action staticDisposeCurrentState = null)
	{
	}

	public void StaticDisposeCurrentState()
	{
	}

	public void RestoreSavedState()
	{
	}
}
