namespace System.Threading;

/// <summary>Specifies whether a lock can be entered multiple times by the same thread.</summary>
public enum LockRecursionPolicy
{
	/// <summary>If a thread tries to enter a lock recursively, an exception is thrown. Some classes may allow certain recursions when this setting is in effect. </summary>
	NoRecursion = 0,
	/// <summary>A thread can enter a lock recursively. Some classes may restrict this capability. </summary>
	SupportsRecursion = 1
}
