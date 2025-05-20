using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System;

[StackTraceHidden]
internal static class ThrowHelper
{
	internal static void ThrowArgumentNullException(ExceptionArgument argument)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Exception CreateArgumentNullException(ExceptionArgument argument)
	{
		return null;
	}

	internal static void ThrowArrayTypeMismatchException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Exception CreateArrayTypeMismatchException()
	{
		return null;
	}

	internal static void ThrowArgumentException_DestinationTooShort()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Exception CreateArgumentException_DestinationTooShort()
	{
		return null;
	}

	internal static void ThrowIndexOutOfRangeException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Exception CreateIndexOutOfRangeException()
	{
		return null;
	}

	internal static void ThrowArgumentOutOfRangeException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Exception CreateArgumentOutOfRangeException()
	{
		return null;
	}

	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument)
	{
		return null;
	}

	internal static void ThrowNotSupportedException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Exception CreateThrowNotSupportedException()
	{
		return null;
	}

	internal static void ThrowWrongKeyTypeArgumentException(object key, Type targetType)
	{
	}

	internal static void ThrowWrongValueTypeArgumentException(object value, Type targetType)
	{
	}

	internal static void ThrowArgumentException(ExceptionResource resource)
	{
	}

	internal static void ThrowArgumentException(ExceptionResource resource, ExceptionArgument argument)
	{
	}

	internal static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource)
	{
	}

	internal static void ThrowInvalidOperationException(ExceptionResource resource)
	{
	}

	internal static void ThrowSerializationException(ExceptionResource resource)
	{
	}

	internal static void ThrowNotSupportedException(ExceptionResource resource)
	{
	}

	internal static void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
	{
	}

	internal static void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen()
	{
	}

	internal static void ThrowInvalidOperationException_InvalidOperation_EnumNotStarted()
	{
	}

	internal static void ThrowInvalidOperationException_InvalidOperation_EnumEnded()
	{
	}

	internal static void ThrowInvalidOperationException_InvalidOperation_NoValue()
	{
	}

	private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument, string resource)
	{
		return null;
	}

	internal static void ThrowArgumentOutOfRange_IndexException()
	{
	}

	internal static void ThrowIndexArgumentOutOfRange_NeedNonNegNumException()
	{
	}

	internal static void ThrowArgumentException_Argument_InvalidArrayType()
	{
	}

	private static ArgumentException GetAddingDuplicateWithKeyArgumentException(object key)
	{
		return null;
	}

	internal static void ThrowAddingDuplicateWithKeyArgumentException(object key)
	{
	}

	private static KeyNotFoundException GetKeyNotFoundException(object key)
	{
		return null;
	}

	internal static void ThrowKeyNotFoundException(object key)
	{
	}

	internal static void ThrowInvalidTypeWithPointersNotSupported(Type targetType)
	{
	}

	internal static void ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
	{
	}

	internal static InvalidOperationException GetInvalidOperationException(string str)
	{
		return null;
	}

	internal static void ThrowArraySegmentCtorValidationFailedExceptions(Array array, int offset, int count)
	{
	}

	private static Exception GetArraySegmentCtorValidationFailedException(Array array, int offset, int count)
	{
		return null;
	}

	private static ArgumentException GetArgumentException(ExceptionResource resource)
	{
		return null;
	}

	private static ArgumentNullException GetArgumentNullException(ExceptionArgument argument)
	{
		return null;
	}

	internal static void IfNullAndNullsAreIllegalThenThrow<T>(object value, ExceptionArgument argName)
	{
	}

	internal static string GetArgumentName(ExceptionArgument argument)
	{
		return null;
	}

	private static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource)
	{
		return null;
	}

	internal static void ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index()
	{
	}

	internal static void ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count()
	{
	}

	internal static string GetResourceName(ExceptionResource resource)
	{
		return null;
	}
}
