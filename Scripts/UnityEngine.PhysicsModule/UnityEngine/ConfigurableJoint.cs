using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/Physics/ConfigurableJoint.h")]
[NativeClass("Unity::ConfigurableJoint")]
public class ConfigurableJoint : Joint
{
	public ConfigurableJointMotion zMotion
	{
		set
		{
		}
	}

	public ConfigurableJointMotion angularXMotion
	{
		set
		{
		}
	}

	public ConfigurableJointMotion angularYMotion
	{
		set
		{
		}
	}

	public ConfigurableJointMotion angularZMotion
	{
		set
		{
		}
	}

	public SoftJointLimit angularZLimit
	{
		get
		{
			return default(SoftJointLimit);
		}
		set
		{
		}
	}

	public Vector3 targetPosition
	{
		set
		{
		}
	}

	[SpecialName]
	private void get_angularZLimit_Injected(out SoftJointLimit ret)
	{
		ret = default(SoftJointLimit);
	}

	[SpecialName]
	private void set_angularZLimit_Injected(ref SoftJointLimit value)
	{
	}

	[SpecialName]
	private void set_targetPosition_Injected(ref Vector3 value)
	{
	}
}
