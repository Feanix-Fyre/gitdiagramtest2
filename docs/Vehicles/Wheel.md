# Wheel

The `Wheel` class represents a wheel on a vehicle. It handles the wheel's physics, including friction and drifting, and it also manages the wheel's visual model and particle effects.

## Public Properties

| Property                            | Type                  | Description                                                              |
| ----------------------------------- | --------------------- | ------------------------------------------------------------------------ |
| `DEBUG_MODE`                        | `bool`                | If true, debug information will be logged to the console.                |
| `wheelModel`                        | `Transform`           | The transform of the wheel's visual model.                               |
| `modelContainer`                    | `Transform`           | The transform of the container for the wheel's visual model.             |
| `wheelCollider`                     | `WheelCollider`       | The wheel collider component.                                            |
| `axleConnectionPoint`               | `Transform`           | The point where the wheel is connected to the axle.                      |
| `staticCollider`                    | `Collider`            | The collider to use when the wheel is static.                            |
| `DriftParticles`                    | `ParticleSystem`      | The particle system to use for drift effects.                            |
| `DriftParticlesEnabled`             | `bool`                | If true, drift particles will be enabled.                                |
| `ForwardStiffnessMultiplier_Handbrake` | `float`               | A multiplier for the forward stiffness of the wheel when the handbrake is applied. |
| `SidewayStiffnessMultiplier_Handbrake` | `float`               | A multiplier for the sideways stiffness of the wheel when the handbrake is applied. |
| `DriftAudioEnabled`                 | `bool`                | If true, drift audio will be enabled.                                    |
| `DriftAudioSource`                  | `AudioSourceController` | The audio source to use for drift audio.                                 |
| `isStatic`                          | `bool`                | A boolean that indicates whether the wheel is static.                    |
| `IsDrifting`                        | `bool`                | A boolean that indicates whether the wheel is currently drifting.        |
| `IsDrifting_Smoothed`               | `bool`                | A smoothed version of `IsDrifting`.                                      |
| `DriftTime`                         | `float`               | The time the wheel has been drifting.                                    |
| `DriftIntensity`                    | `float`               | The intensity of the drift.                                              |

## Public Methods

| Method                   | Return Type | Description                               |
| ------------------------ | ----------- | ----------------------------------------- |
| `SetIsStatic(bool s)`    | `void`      | Sets whether the wheel is static.         |
| `IsWheelGrounded()`      | `bool`      | Checks if the wheel is on the ground.     |
