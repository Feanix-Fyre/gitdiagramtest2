using System.Collections.Generic;

namespace System.Data;

internal sealed class TypeLimiter
{
	private sealed class Scope : IDisposable
	{
		private static readonly HashSet<Type> s_allowedTypes;

		private HashSet<Type> m_allowedTypes;

		private readonly Scope? m_previousScope;

		internal Scope(Scope? previousScope, IEnumerable<Type> allowedTypes)
		{
		}

		public void Dispose()
		{
		}

		public bool IsAllowedType(Type type)
		{
			return false;
		}

		private static bool IsTypeUnconditionallyAllowed(Type type)
		{
			return false;
		}
	}

	[ThreadStatic]
	private static Scope? s_activeScope;

	private Scope m_instanceScope;

	private static bool IsTypeLimitingDisabled => false;

	private TypeLimiter(Scope scope)
	{
	}

	public static TypeLimiter? Capture()
	{
		return null;
	}

	public static void EnsureTypeIsAllowed(Type? type, TypeLimiter? capturedLimiter = null)
	{
	}

	public static IDisposable EnterRestrictedScope(DataSet dataSet)
	{
		return null;
	}

	public static IDisposable EnterRestrictedScope(DataTable dataTable)
	{
		return null;
	}

	private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataTable dataTable)
	{
		return null;
	}

	private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataSet dataSet)
	{
		return null;
	}
}
