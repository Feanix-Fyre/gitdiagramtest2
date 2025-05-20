namespace System;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
internal class MonoTODOAttribute : Attribute
{
	private string comment;

	public MonoTODOAttribute(string comment)
	{
	}
}
