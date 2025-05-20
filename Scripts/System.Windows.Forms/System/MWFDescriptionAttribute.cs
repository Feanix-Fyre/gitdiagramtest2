using System.ComponentModel;

namespace System;

[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
internal sealed class MWFDescriptionAttribute : DescriptionAttribute
{
	public override string Description => null;

	public MWFDescriptionAttribute(string category)
	{
	}
}
