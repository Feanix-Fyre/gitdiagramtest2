using System.Runtime.InteropServices;

namespace System;

/// <summary>Defines the base class for all context-bound classes.</summary>
[Serializable]
[ComVisible(true)]
public abstract class ContextBoundObject : MarshalByRefObject
{
	/// <summary>Instantiates an instance of the <see cref="T:System.ContextBoundObject" /> class.</summary>
	protected ContextBoundObject()
	{
	}
}
