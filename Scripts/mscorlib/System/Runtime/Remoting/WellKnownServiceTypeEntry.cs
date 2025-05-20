using System.Runtime.InteropServices;

namespace System.Runtime.Remoting;

/// <summary>Holds values for an object type registered on the service end as a server-activated type object (single call or singleton).</summary>
[ComVisible(true)]
public class WellKnownServiceTypeEntry : TypeEntry
{
	private Type obj_type;

	private string obj_uri;

	private WellKnownObjectMode obj_mode;

	/// <summary>Gets the <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> of the server-activated service type.</summary>
	/// <returns>The <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> of the server-activated service type.</returns>
	public WellKnownObjectMode Mode => default(WellKnownObjectMode);

	/// <summary>Gets the <see cref="T:System.Type" /> of the server-activated service type.</summary>
	/// <returns>The <see cref="T:System.Type" /> of the server-activated service type.</returns>
	public Type ObjectType => null;

	/// <summary>Gets the URI of the well-known service type.</summary>
	/// <returns>The URI of the server-activated service type.</returns>
	public string ObjectUri => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Remoting.WellKnownServiceTypeEntry" /> class with the given type name, assembly name, object URI, and <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" />.</summary>
	/// <param name="typeName">The full type name of the server-activated service type.</param>
	/// <param name="assemblyName">The assembly name of the server-activated service type.</param>
	/// <param name="objectUri">The URI of the server-activated object.</param>
	/// <param name="mode">The <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> of the type, which defines how the object is activated.</param>
	public WellKnownServiceTypeEntry(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode)
	{
	}

	/// <summary>Returns the type name, assembly name, object URI and the <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> of the server-activated type as a <see cref="T:System.String" />.</summary>
	/// <returns>The type name, assembly name, object URI, and the <see cref="T:System.Runtime.Remoting.WellKnownObjectMode" /> of the server-activated type as a <see cref="T:System.String" />.</returns>
	public override string ToString()
	{
		return null;
	}
}
