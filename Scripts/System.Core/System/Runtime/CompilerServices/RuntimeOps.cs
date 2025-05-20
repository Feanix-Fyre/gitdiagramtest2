using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;

namespace System.Runtime.CompilerServices;

/// <summary>Contains helper methods called from dynamically generated methods.</summary>
[EditorBrowsable(EditorBrowsableState.Never)]
[DebuggerStepThrough]
public static class RuntimeOps
{
	/// <summary>Gets the value of an item in an expando object.</summary>
	/// <param name="expando">The expando object.</param>
	/// <param name="indexClass">The class of the expando object.</param>
	/// <param name="index">The index of the member.</param>
	/// <param name="name">The name of the member.</param>
	/// <param name="ignoreCase">true if the name should be matched ignoring case; false otherwise.</param>
	/// <param name="value">The out parameter containing the value of the member.</param>
	/// <returns>True if the member exists in the expando object, otherwise false.</returns>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("do not use this method", true)]
	public static bool ExpandoTryGetValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase, out object value)
	{
		value = null;
		return false;
	}

	/// <summary>Sets the value of an item in an expando object.</summary>
	/// <param name="expando">The expando object.</param>
	/// <param name="indexClass">The class of the expando object.</param>
	/// <param name="index">The index of the member.</param>
	/// <param name="value">The value of the member.</param>
	/// <param name="name">The name of the member.</param>
	/// <param name="ignoreCase">true if the name should be matched ignoring case; false otherwise.</param>
	/// <returns>Returns the index for the set member.</returns>
	[Obsolete("do not use this method", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static object ExpandoTrySetValue(ExpandoObject expando, object indexClass, int index, object value, string name, bool ignoreCase)
	{
		return null;
	}

	/// <summary>Deletes the value of an item in an expando object.</summary>
	/// <param name="expando">The expando object.</param>
	/// <param name="indexClass">The class of the expando object.</param>
	/// <param name="index">The index of the member.</param>
	/// <param name="name">The name of the member.</param>
	/// <param name="ignoreCase">true if the name should be matched ignoring case; false otherwise.</param>
	/// <returns>true if the item was successfully removed; otherwise, false.</returns>
	[Obsolete("do not use this method", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static bool ExpandoTryDeleteValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase)
	{
		return false;
	}

	/// <summary>Checks the version of the Expando object.</summary>
	/// <param name="expando">The Expando object.</param>
	/// <param name="version">The version to check.</param>
	/// <returns>Returns true if the version is equal; otherwise, false.</returns>
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("do not use this method", true)]
	public static bool ExpandoCheckVersion(ExpandoObject expando, object version)
	{
		return false;
	}

	/// <summary>Promotes an Expando object from one class to a new class.</summary>
	/// <param name="expando">The Expando object.</param>
	/// <param name="oldClass">The old class of the Expando object.</param>
	/// <param name="newClass">The new class of the Expando object.</param>
	[Obsolete("do not use this method", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static void ExpandoPromoteClass(ExpandoObject expando, object oldClass, object newClass)
	{
	}
}
