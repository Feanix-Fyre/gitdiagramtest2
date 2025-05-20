namespace System.Runtime.InteropServices;

/// <summary>Specifies the class identifier of a coclass imported from a type library.</summary>
[ComVisible(true)]
[AttributeUsage(AttributeTargets.Interface, Inherited = false)]
public sealed class CoClassAttribute : Attribute
{
	internal Type _CoClass;

	/// <summary>Initializes new instance of the <see cref="T:System.Runtime.InteropServices.CoClassAttribute" /> with the class identifier of the original coclass.</summary>
	/// <param name="coClass">A <see cref="T:System.Type" /> that contains the class identifier of the original coclass.</param>
	public CoClassAttribute(Type coClass)
	{
	}
}
