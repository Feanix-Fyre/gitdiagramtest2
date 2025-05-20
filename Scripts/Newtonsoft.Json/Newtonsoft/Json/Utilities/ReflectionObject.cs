using System;
using System.Collections.Generic;
using System.Reflection;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities;

internal class ReflectionObject
{
	public ObjectConstructor<object>? Creator { get; }

	public IDictionary<string, ReflectionMember> Members { get; }

	private ReflectionObject(ObjectConstructor<object>? creator)
	{
	}

	public object GetValue(object target, string member)
	{
		return null;
	}

	public void SetValue(object target, string member, object? value)
	{
	}

	public Type GetType(string member)
	{
		return null;
	}

	public static ReflectionObject Create(Type t, params string[] memberNames)
	{
		return null;
	}

	public static ReflectionObject Create(Type t, MethodBase? creator, params string[] memberNames)
	{
		return null;
	}
}
