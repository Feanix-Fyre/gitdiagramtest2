using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Unity.Properties.Internal;

internal static class PropertyBagStore
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct TypedStore<TContainer>
	{
		public static IPropertyBag<TContainer> PropertyBag;
	}

	private static readonly ConcurrentDictionary<Type, IPropertyBag> s_PropertyBags;

	private static readonly List<Type> s_RegisteredTypes;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static Action<Type, IPropertyBag> NewTypeRegistered;

	private static ReflectedPropertyBagProvider s_PropertyBagProvider;

	static PropertyBagStore()
	{
	}

	internal static void AddPropertyBag<TContainer>(IPropertyBag<TContainer> propertyBag)
	{
	}

	internal static IPropertyBag<TContainer> GetPropertyBag<TContainer>()
	{
		return null;
	}

	internal static IPropertyBag GetPropertyBag(Type type)
	{
		return null;
	}
}
