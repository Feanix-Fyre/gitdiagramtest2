using System;
using UnityEngine.Scripting;

namespace UnityEngine;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
[RequiredByNativeCode]
public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute
{
	private RuntimeInitializeLoadType m_LoadType;

	private RuntimeInitializeLoadType loadType
	{
		set
		{
		}
	}

	public RuntimeInitializeOnLoadMethodAttribute()
	{
	}

	public RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType)
	{
	}
}
