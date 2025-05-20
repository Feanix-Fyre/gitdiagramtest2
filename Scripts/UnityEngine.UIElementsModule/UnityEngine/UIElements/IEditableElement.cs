using System;

namespace UnityEngine.UIElements;

internal interface IEditableElement
{
	internal Action editingStarted { get; }

	internal Action editingEnded { get; }
}
