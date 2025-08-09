# VehicleLights

The `VehicleLights` class manages the lights on a vehicle, including the headlights, brake lights, and reverse lights. It controls the materials and light sources for each type of light, and it synchronizes the state of the headlights over the network.

## Public Properties

| Property              | Type                  | Description                                                                  |
| --------------------- | --------------------- | ---------------------------------------------------------------------------- |
| `vehicle`             | `LandVehicle`         | The `LandVehicle` that this component is attached to.                        |
| `hasHeadLights`       | `bool`                | A boolean that indicates whether the vehicle has headlights.                 |
| `headLightMeshes`     | `MeshRenderer[]`      | The meshes for the headlights.                                               |
| `headLightSources`    | `OptimizedLight[]`    | The light sources for the headlights.                                        |
| `headlightMat_On`     | `Material`            | The material to use when the headlights are on.                              |
| `headLightMat_Off`    | `Material`            | The material to use when the headlights are off.                             |
| `headLightsOn`        | `bool`                | A boolean that indicates whether the headlights are on.                      |
| `hasBrakeLights`      | `bool`                | A boolean that indicates whether the vehicle has brake lights.               |
| `brakeLightMeshes`    | `MeshRenderer[]`      | The meshes for the brake lights.                                             |
| `brakeLightSources`   | `Light[]`             | The light sources for the brake lights.                                      |
| `brakeLightMat_On`    | `Material`            | The material to use when the brake lights are on.                            |
| `brakeLightMat_Off`   | `Material`            | The material to use when the brake lights are off.                           |
| `brakeLightMat_Ambient` | `Material`            | The material to use for the ambient brake lights.                            |
| `hasReverseLights`    | `bool`                | A boolean that indicates whether the vehicle has reverse lights.             |
| `reverseLightMeshes`  | `MeshRenderer[]`      | The meshes for the reverse lights.                                           |
| `reverseLightSources` | `Light[]`             | The light sources for the reverse lights.                                    |
| `reverseLightMat_On`  | `Material`            | The material to use when the reverse lights are on.                          |
| `reverseLightMat_Off` | `Material`            | The material to use when the reverse lights are off.                         |
| `onHeadlightsOn`      | `UnityEvent`          | An event that is invoked when the headlights are turned on.                  |
| `onHeadlightsOff`     | `UnityEvent`          | An event that is invoked when the headlights are turned off.                 |
