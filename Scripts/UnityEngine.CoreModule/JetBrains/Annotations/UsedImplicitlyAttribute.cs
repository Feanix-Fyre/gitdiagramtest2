using System;

namespace JetBrains.Annotations;

[AttributeUsage(AttributeTargets.All, Inherited = false)]
public sealed class UsedImplicitlyAttribute : Attribute
{
	public UsedImplicitlyAttribute()
	{
	}

	public UsedImplicitlyAttribute(ImplicitUseKindFlags useKindFlags, ImplicitUseTargetFlags targetFlags)
	{
	}
}
