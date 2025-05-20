using System.ComponentModel;

namespace System;

[AttributeUsage(AttributeTargets.All)]
internal class SRDescriptionAttribute : DescriptionAttribute
{
	private bool isReplaced;

	public override string Description => null;

	public SRDescriptionAttribute(string description)
	{
	}
}
