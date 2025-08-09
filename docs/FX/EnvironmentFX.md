# EnvironmentFX

The `EnvironmentFX` class is a singleton that manages the visual effects of the environment.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `HeightFog` | `HeightFogGlobal` | The global height fog. |
| `VolumetricFog` | `VolumetricFog` | The volumetric fog. |
| `SunLight` | `Light` | The sun light. |
| `MoonLight` | `Light` | The moon light. |
| `fogEndDistanceMultiplier` | `float` | The multiplier for the fog end distance. |
| `HeightFogIntensityMultiplier` | `float` | The multiplier for the height fog intensity. |
| `VolumetricFogIntensityMultiplier` | `float` | The multiplier for the volumetric fog intensity. |
| `contractMultiplier` | `float` | The multiplier for the contrast. |
| `saturationMultiplier` | `float` | The multiplier for the saturation. |
| `distanceTreeMat` | `Material` | The material for the distance trees. |
| `distanceTreeColorCurve` | `AnimationCurve` | The color curve for the distance trees. |
| `environmentalBrightnessCurve` | `AnimationCurve` | The curve for the environmental brightness. |
| `bloomThreshholdCurve` | `AnimationCurve` | The curve for the bloom threshold. |
| `FogEndDistanceController` | `FloatSmoother` | The controller for the fog end distance. |
| `normalizedEnvironmentalBrightness` | `float` | The normalized environmental brightness. |
