using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/Physics/PhysicMaterial.h")]
public class PhysicMaterial : Object
{
	public float bounciness
	{
		set
		{
		}
	}

	public float dynamicFriction
	{
		set
		{
		}
	}

	public float staticFriction
	{
		set
		{
		}
	}

	public PhysicMaterialCombine frictionCombine
	{
		set
		{
		}
	}

	public PhysicMaterialCombine bounceCombine
	{
		set
		{
		}
	}

	private static void Internal_CreateDynamicsMaterial([Writable] PhysicMaterial mat, string name)
	{
	}
}
