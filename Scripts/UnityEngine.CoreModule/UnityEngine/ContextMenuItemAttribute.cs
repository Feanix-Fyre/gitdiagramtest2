using System;

namespace UnityEngine;

[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class ContextMenuItemAttribute : PropertyAttribute
{
	public readonly string name;

	public readonly string function;

	public ContextMenuItemAttribute(string name, string function)
	{
	}
}
