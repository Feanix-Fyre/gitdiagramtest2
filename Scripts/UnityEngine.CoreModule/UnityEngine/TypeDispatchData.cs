using System;
using Unity.Collections;

namespace UnityEngine;

internal struct TypeDispatchData : IDisposable
{
	public Object[] changed;

	public NativeArray<int> changedID;

	public NativeArray<int> destroyedID;

	public void Dispose()
	{
	}
}
