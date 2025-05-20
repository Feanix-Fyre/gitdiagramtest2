using System;
using System.Collections.Generic;
using System.Text;
using Unity.Collections;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Scripting/TextAsset.h")]
public class TextAsset : Object
{
	private static class EncodingUtility
	{
		internal static readonly KeyValuePair<byte[], Encoding>[] encodingLookup;

		internal static readonly Encoding targetEncoding;

		static EncodingUtility()
		{
		}
	}

	public byte[] bytes => null;

	public string text => null;

	private IntPtr GetDataPtr()
	{
		return (IntPtr)0;
	}

	private long GetDataSize()
	{
		return 0L;
	}

	public override string ToString()
	{
		return null;
	}

	public NativeArray<T> GetData<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	internal static string DecodeString(byte[] bytes)
	{
		return null;
	}
}
