using UnityEngine;

namespace VolumetricFogAndMist2;

public enum VolumetricFogNoiseSize
{
	[InspectorName("8")]
	_8 = 8,
	[InspectorName("16")]
	_16 = 0x10,
	[InspectorName("32")]
	_32 = 0x20,
	[InspectorName("64")]
	_64 = 0x40,
	[InspectorName("128")]
	_128 = 0x80,
	[InspectorName("256")]
	_256 = 0x100
}
