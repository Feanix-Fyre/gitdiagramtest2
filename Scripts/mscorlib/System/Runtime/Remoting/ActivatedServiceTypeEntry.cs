using System.Runtime.InteropServices;

namespace System.Runtime.Remoting;

/// <summary>Holds values for an object type registered on the service end as one that can be activated on request from a client.</summary>
[ComVisible(true)]
public class ActivatedServiceTypeEntry : TypeEntry
{
	private Type obj_type;

	/// <summary>Gets the <see cref="T:System.Type" /> of the client-activated service type.</summary>
	/// <returns>The <see cref="T:System.Type" /> of the client-activated service type.</returns>
	public Type ObjectType => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.ActivatedServiceTypeEntry" /> class with the given type name and assembly name.</summary>
	/// <param name="typeName">The type name of the client-activated service type.</param>
	/// <param name="assemblyName">The assembly name of the client-activated service type.</param>
	public ActivatedServiceTypeEntry(string typeName, string assemblyName)
	{
	}

	/// <summary>Returns the type and assembly name of the client-activated service type as a <see cref="T:System.String" />.</summary>
	/// <returns>The type and assembly name of the client-activated service type as a <see cref="T:System.String" />.</returns>
	public override string ToString()
	{
		return null;
	}
}
