# VehicleSound

The `VehicleSound` class is responsible for playing all the sounds related to a vehicle, including the engine, handbrake, honk, and collision sounds. It uses `AudioSourceController`s to play the sounds and has several properties to configure the sound behavior.

## Properties

-   `VolumeMultiplier`: A multiplier for the volume of all sounds played by this component.
-   `EngineStartSource`: The `AudioSourceController` for the engine start sound.
-   `EngineIdleSource`: The `AudioSourceController` for the engine idle sound.
-   `EngineLoopSource`: The `AudioSourceController` for the engine loop sound.
-   `HandbrakeSource`: The `AudioSourceController` for the handbrake sound.
-   `HonkSource`: The `AudioSourceController` for the honk sound.
-   `ImpactSound`: The `AudioSourceController` for the collision sound.
-   `MinCollisionMomentum`: The minimum momentum required to play a collision sound.
-   `MaxCollisionMomentum`: The momentum at which the collision sound will be played at its maximum volume and pitch.
-   `MinCollisionVolume`: The volume of the collision sound at the minimum momentum.
-   `MaxCollisionVolume`: The volume of the collision sound at the maximum momentum.
-   `MinCollisionPitch`: The pitch of the collision sound at the minimum momentum.
-   `MaxCollisionPitch`: The pitch of the collision sound at the maximum momentum.
-   `EngineLoopPitchCurve`: An animation curve that defines the pitch of the engine loop sound based on the vehicle's speed.
-   `EngineLoopPitchMultiplier`: A multiplier for the pitch of the engine loop sound.
-   `EngineLoopVolumeCurve`: An animation curve that defines the volume of the engine loop sound based on the vehicle's speed.
-   `Vehicle`: The `LandVehicle` that this component is attached to.

## Methods

-   `Honk()`: Plays the honk sound.
