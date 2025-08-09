# GraphicsSettings

The `GraphicsSettings` class is a serializable class that contains settings for graphics.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `GraphicsQuality` | `EGraphicsQuality` | The graphics quality. |
| `AntiAliasingMode` | `EAntiAliasingMode` | The anti-aliasing mode. |
| `FOV` | `float` | The field of view. |
| `SSAO` | `bool` | If `true`, screen space ambient occlusion is enabled. |
| `GodRays` | `bool` | If `true`, god rays are enabled. |

---

# EAntiAliasingMode

The `EAntiAliasingMode` enum defines the different anti-aliasing modes.

## Values

| Name | Description |
| --- | --- |
| `Off` | No anti-aliasing. |
| `FXAA` | Fast approximate anti-aliasing. |
| `SMAA` | Subpixel morphological anti-aliasing. |

---

# EGraphicsQuality

The `EGraphicsQuality` enum defines the different graphics quality levels.

## Values

| Name | Description |
| --- | --- |
| `Low` | Low graphics quality. |
| `Medium` | Medium graphics quality. |
| `High` | High graphics quality. |
| `Ultra` | Ultra graphics quality. |
