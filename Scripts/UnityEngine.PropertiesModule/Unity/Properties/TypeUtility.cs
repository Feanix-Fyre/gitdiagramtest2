using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine.Pool;
using UnityEngine.Scripting;

namespace Unity.Properties;

public static class TypeUtility
{
	private interface ITypeConstructor
	{
		bool CanBeInstantiated { get; }

		object Instantiate();
	}

	private interface ITypeConstructor<T> : ITypeConstructor
	{
		new T Instantiate();

		void SetExplicitConstructor(Func<T> constructor);
	}

	private class TypeConstructor<T> : ITypeConstructor<T>, ITypeConstructor
	{
		private Func<T> m_ExplicitConstructor;

		private Func<T> m_ImplicitConstructor;

		private IConstructor<T> m_OverrideConstructor;

		bool ITypeConstructor.CanBeInstantiated => false;

		private void SetImplicitConstructor()
		{
		}

		private static T CreateValueTypeInstance()
		{
			return default(T);
		}

		private static T CreateScriptableObjectInstance()
		{
			return default(T);
		}

		private static T CreateClassInstance()
		{
			return default(T);
		}

		public void SetExplicitConstructor(Func<T> constructor)
		{
		}

		T ITypeConstructor<T>.Instantiate()
		{
			return default(T);
		}

		object ITypeConstructor.Instantiate()
		{
			return null;
		}
	}

	private class NonConstructable : ITypeConstructor
	{
		bool ITypeConstructor.CanBeInstantiated => false;

		public object Instantiate()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	private struct Cache<T>
	{
		public static ITypeConstructor<T> TypeConstructor;
	}

	private class TypeConstructorVisitor : ITypeVisitor
	{
		public ITypeConstructor TypeConstructor;

		public void Visit<TContainer>()
		{
		}
	}

	private static readonly ConcurrentDictionary<Type, ITypeConstructor> s_TypeConstructors;

	private static readonly MethodInfo s_CreateTypeConstructor;

	private static readonly ConcurrentDictionary<Type, string> s_CachedResolvedName;

	private static readonly ObjectPool<StringBuilder> s_Builders;

	private static readonly object syncedPoolObject;

	static TypeUtility()
	{
	}

	public static string GetTypeDisplayName(Type type)
	{
		return null;
	}

	private static string GetTypeDisplayName(Type type, IReadOnlyList<Type> args, ref int argIndex)
	{
		return null;
	}

	public static Type GetRootType(this Type type)
	{
		return null;
	}

	[Preserve]
	private static ITypeConstructor CreateTypeConstructor(Type type)
	{
		return null;
	}

	private static ITypeConstructor<T> CreateTypeConstructor<T>()
	{
		return null;
	}

	private static ITypeConstructor GetTypeConstructor(Type type)
	{
		return null;
	}

	private static ITypeConstructor<T> GetTypeConstructor<T>()
	{
		return null;
	}

	public static bool CanBeInstantiated(Type type)
	{
		return false;
	}

	public static bool CanBeInstantiated<T>()
	{
		return false;
	}

	public static void SetExplicitInstantiationMethod<T>(Func<T> constructor)
	{
	}

	public static T Instantiate<T>()
	{
		return default(T);
	}

	public static bool TryInstantiate<T>(out T instance)
	{
		instance = default(T);
		return false;
	}

	public static T Instantiate<T>(Type derivedType)
	{
		return default(T);
	}

	public static bool TryInstantiate<T>(Type derivedType, out T value)
	{
		value = default(T);
		return false;
	}

	public static TArray InstantiateArray<TArray>(int count = 0)
	{
		return default(TArray);
	}

	public static bool TryInstantiateArray<TArray>(int count, out TArray instance)
	{
		instance = default(TArray);
		return false;
	}

	public static TArray InstantiateArray<TArray>(Type derivedType, int count = 0)
	{
		return default(TArray);
	}

	private static void CheckIsAssignableFrom(Type type, Type derivedType)
	{
	}

	private static void CheckCanBeInstantiated<T>(ITypeConstructor<T> constructor)
	{
	}

	private static void CheckCanBeInstantiated(ITypeConstructor constructor, Type type)
	{
	}
}
