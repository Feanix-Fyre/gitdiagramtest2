using System;

namespace JetBrains.Annotations;

[MeansImplicitUse(ImplicitUseTargetFlags.WithMembers)]
[AttributeUsage(AttributeTargets.All, Inherited = false)]
public sealed class PublicAPIAttribute : Attribute
{
}
