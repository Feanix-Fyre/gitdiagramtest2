using System;
using System.Collections.Generic;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

internal struct InputBindingResolver : IDisposable
{
	public int totalProcessorCount;

	public int totalCompositeCount;

	public int totalInteractionCount;

	public InputActionMap[] maps;

	public InputControl[] controls;

	public InputActionState.UnmanagedMemory memory;

	public IInputInteraction[] interactions;

	public InputProcessor[] processors;

	public InputBindingComposite[] composites;

	public InputBinding? bindingMask;

	private bool m_IsControlOnlyResolve;

	private List<NameAndParameters> m_Parameters;

	public int totalMapCount => 0;

	public int totalActionCount => 0;

	public int totalBindingCount => 0;

	public int totalControlCount => 0;

	public void Dispose()
	{
	}

	public void StartWithPreviousResolve(InputActionState state, bool isFullResolve)
	{
	}

	public void AddActionMap(InputActionMap actionMap)
	{
	}

	private int InstantiateWithParameters<TType>(TypeTable registrations, string namesAndParameters, ref TType[] array, ref int count, InputActionMap actionMap, ref InputBinding binding)
	{
		return 0;
	}

	private static InputBindingComposite InstantiateBindingComposite(ref InputBinding binding, InputActionMap actionMap)
	{
		return null;
	}

	private static void ApplyParameters(ReadOnlyArray<NamedValue> parameters, object instance, InputActionMap actionMap, ref InputBinding binding, string objectRegistrationName, string namesAndParameters)
	{
	}

	private static int AssignCompositePartIndex(object composite, string name, ref int currentCompositePartCount)
	{
		return 0;
	}
}
