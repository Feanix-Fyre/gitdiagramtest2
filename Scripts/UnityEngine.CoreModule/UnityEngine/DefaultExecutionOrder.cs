using System;
using UnityEngine.Scripting;

namespace UnityEngine;

[AttributeUsage(AttributeTargets.Class)]
[UsedByNativeCode]
public class DefaultExecutionOrder : Attribute
{
	private int m_Order;

	public int order => 0;

	public DefaultExecutionOrder(int order)
	{
	}
}
