namespace System.Reflection;

/// <summary>Attaches a modifier to parameters so that binding can work with parameter signatures in which the types have been modified.</summary>
[DefaultMember("Item")]
public readonly struct ParameterModifier
{
	private readonly bool[] _byRef;
}
