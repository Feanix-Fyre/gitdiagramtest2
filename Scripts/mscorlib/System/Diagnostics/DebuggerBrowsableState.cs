using System.Runtime.InteropServices;

namespace System.Diagnostics;

/// <summary>Provides display instructions for the debugger.</summary>
[ComVisible(true)]
public enum DebuggerBrowsableState
{
	/// <summary>Never show the element.</summary>
	Never = 0,
	/// <summary>Show the element as collapsed.</summary>
	Collapsed = 2,
	/// <summary>Do not display the root element; display the child elements if the element is a collection or array of items.</summary>
	RootHidden = 3
}
