using System;

namespace UnityEngine.InputSystem.Utilities;

internal struct CallbackArray<TDelegate> where TDelegate : Delegate
{
	private bool m_CannotMutateCallbacksArray;

	private InlinedArray<TDelegate> m_Callbacks;

	private InlinedArray<TDelegate> m_CallbacksToAdd;

	private InlinedArray<TDelegate> m_CallbacksToRemove;

	public int length => 0;

	public TDelegate this[int index] => null;

	public void Clear()
	{
	}

	public void AddCallback(TDelegate dlg)
	{
	}

	public void RemoveCallback(TDelegate dlg)
	{
	}

	public void LockForChanges()
	{
	}

	public void UnlockForChanges()
	{
	}
}
