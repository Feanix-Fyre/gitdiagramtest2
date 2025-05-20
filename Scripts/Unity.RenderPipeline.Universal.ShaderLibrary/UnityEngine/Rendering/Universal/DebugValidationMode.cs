namespace UnityEngine.Rendering.Universal;

[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, "M:\\Unity Projects\\ScheduleOne\\com.unity.render-pipelines.universal@14.0.11\\ShaderLibrary\\Debug\\DebugViewEnums.cs")]
public enum DebugValidationMode
{
	None = 0,
	[InspectorName("Highlight NaN, Inf and Negative Values")]
	HighlightNanInfNegative = 1,
	[InspectorName("Highlight Values Outside Range")]
	HighlightOutsideOfRange = 2
}
