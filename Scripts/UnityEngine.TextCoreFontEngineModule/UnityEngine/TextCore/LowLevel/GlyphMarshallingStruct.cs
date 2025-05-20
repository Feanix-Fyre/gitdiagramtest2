using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel;

[UsedByNativeCode]
internal struct GlyphMarshallingStruct
{
	public uint index;

	public GlyphMetrics metrics;

	public GlyphRect glyphRect;

	public float scale;

	public int atlasIndex;

	public GlyphClassDefinitionType classDefinitionType;
}
