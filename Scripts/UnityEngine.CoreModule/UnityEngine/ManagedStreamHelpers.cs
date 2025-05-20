using System;
using System.IO;
using UnityEngine.Scripting;

namespace UnityEngine;

internal static class ManagedStreamHelpers
{
	internal static void ValidateLoadFromStream(Stream stream)
	{
	}

	[RequiredByNativeCode]
	internal static void ManagedStreamRead(byte[] buffer, int offset, int count, Stream stream, IntPtr returnValueAddress)
	{
	}

	[RequiredByNativeCode]
	internal static void ManagedStreamSeek(long offset, uint origin, Stream stream, IntPtr returnValueAddress)
	{
	}

	[RequiredByNativeCode]
	internal static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress)
	{
	}
}
