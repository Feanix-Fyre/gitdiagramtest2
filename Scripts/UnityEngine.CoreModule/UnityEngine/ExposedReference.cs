using System;
using UnityEngine.Scripting;

namespace UnityEngine;

[Serializable]
[UsedByNativeCode(Name = "ExposedReference")]
public struct ExposedReference<T> where T : Object
{
	[SerializeField]
	public PropertyName exposedName;

	[SerializeField]
	public Object defaultValue;

	public T Resolve(IExposedPropertyTable resolver)
	{
		return null;
	}
}
