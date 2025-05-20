using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

public class BindableElement : VisualElement, IBindable
{
	public new class UxmlFactory : UxmlFactory<BindableElement, UxmlTraits>
	{
	}

	public new class UxmlTraits : VisualElement.UxmlTraits
	{
		private UxmlStringAttributeDescription m_PropertyPath;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string _003CbindingPath_003Ek__BackingField;

	public IBinding binding { get; }

	public string bindingPath
	{
		[CompilerGenerated]
		set
		{
			_003CbindingPath_003Ek__BackingField = value;
		}
	}
}
