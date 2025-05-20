using System.Collections.Generic;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;

namespace UnityEngine.InputSystem.XR;

internal class XRLayoutBuilder
{
	private string parentLayout;

	private string interfaceName;

	private XRDeviceDescriptor descriptor;

	private static readonly string[] poseSubControlNames;

	private static readonly FeatureType[] poseSubControlTypes;

	private static uint GetSizeOfFeature(XRFeatureDescriptor featureDescriptor)
	{
		return 0u;
	}

	private static string SanitizeString(string original, bool allowPaths = false)
	{
		return null;
	}

	internal static string OnFindLayoutForDevice(ref InputDeviceDescription description, string matchedLayout, InputDeviceExecuteCommandDelegate executeCommandDelegate)
	{
		return null;
	}

	private static string ConvertPotentialAliasToName(InputControlLayout layout, string nameOrAlias)
	{
		return null;
	}

	private bool IsSubControl(string name)
	{
		return false;
	}

	private string GetParentControlName(string name)
	{
		return null;
	}

	private bool IsPoseControl(List<XRFeatureDescriptor> features, int startIndex)
	{
		return false;
	}

	private InputControlLayout Build()
	{
		return null;
	}
}
