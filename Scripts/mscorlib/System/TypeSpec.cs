using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;

namespace System;

internal class TypeSpec
{
	[Flags]
	internal enum DisplayNameFormat
	{
		Default = 0,
		WANT_ASSEMBLY = 1,
		NO_MODIFIERS = 2
	}

	private TypeIdentifier name;

	private string assembly_name;

	private List<TypeIdentifier> nested;

	private List<TypeSpec> generic_params;

	private List<ModifierSpec> modifier_spec;

	private bool is_byref;

	private string display_fullname;

	internal bool HasModifiers => false;

	internal string DisplayFullName => null;

	private string GetDisplayFullName(DisplayNameFormat flags)
	{
		return null;
	}

	private StringBuilder GetModifierString(StringBuilder sb)
	{
		return null;
	}

	internal static TypeSpec Parse(string typeName)
	{
		return null;
	}

	internal static string UnescapeInternalName(string displayName)
	{
		return null;
	}

	internal Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark)
	{
		return null;
	}

	private void AddName(string type_name)
	{
	}

	private void AddModifier(ModifierSpec md)
	{
	}

	private static void SkipSpace(string name, ref int pos)
	{
	}

	private static void BoundCheck(int idx, string s)
	{
	}

	private static TypeIdentifier ParsedTypeIdentifier(string displayName)
	{
		return null;
	}

	private static TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn)
	{
		return null;
	}
}
