namespace System;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
internal class MonoInternalNoteAttribute : System.MonoTODOAttribute
{
	public MonoInternalNoteAttribute(string comment)
	{
	}
}
