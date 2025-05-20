using System;
using System.Reflection;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities;

internal abstract class ReflectionDelegateFactory
{
	public Func<T, object> CreateGet<T>(MemberInfo memberInfo) where T : notnull
	{
		return null;
	}

	public Action<T, object> CreateSet<T>(MemberInfo memberInfo) where T : notnull
	{
		return null;
	}

	public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method) where T : notnull;

	public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);

	public abstract Func<T> CreateDefaultConstructor<T>(Type type) where T : notnull;

	public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo) where T : notnull;

	public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo) where T : notnull;

	public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo) where T : notnull;

	public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo) where T : notnull;
}
