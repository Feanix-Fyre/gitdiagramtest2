using System.ComponentModel;

namespace System;

[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
internal sealed class MWFCategoryAttribute : CategoryAttribute
{
	public MWFCategoryAttribute(string category)
	{
	}

	protected override string GetLocalizedString(string value)
	{
		return null;
	}
}
