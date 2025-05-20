using System;

namespace Mono;

internal struct RuntimeClassHandle
{
	private unsafe RuntimeStructs.MonoClass* value;

	internal unsafe RuntimeStructs.MonoClass* Value => null;

	internal unsafe RuntimeClassHandle(RuntimeStructs.MonoClass* value)
	{
		this.value = null;
	}

	internal unsafe RuntimeClassHandle(IntPtr ptr)
	{
		value = null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	internal unsafe static IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass)
	{
		return (IntPtr)0;
	}

	internal RuntimeTypeHandle GetTypeHandle()
	{
		return default(RuntimeTypeHandle);
	}
}
