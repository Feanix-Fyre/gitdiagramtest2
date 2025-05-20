using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;

namespace UnityEngine.InputSystem.XR;

public class BoneControl : InputControl<Bone>
{
	[InputControl(offset = 0u, displayName = "parentBoneIndex")]
	public IntegerControl parentBoneIndex { get; set; }

	[InputControl(offset = 4u, displayName = "Position")]
	public Vector3Control position { get; set; }

	[InputControl(offset = 16u, displayName = "Rotation")]
	public QuaternionControl rotation { get; set; }

	protected override void FinishSetup()
	{
	}

	public unsafe override Bone ReadUnprocessedValueFromState(void* statePtr)
	{
		return default(Bone);
	}

	public unsafe override void WriteValueIntoState(Bone value, void* statePtr)
	{
	}
}
