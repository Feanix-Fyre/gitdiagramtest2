# VehicleAudio

The `VehicleAudio` class is responsible for playing the audio for a vehicle.

## Public Properties

| Property            | Type          | Description                                      |
| ------------------- | ------------- | ------------------------------------------------ |
| `Vehicle`           | `LandVehicle` | The `LandVehicle` that this component is attached to. |
| `Lights`            | `VehicleLights` | The `VehicleLights` component for this vehicle. |
| `EngineStartSound`  | `AudioSource` | The audio source for the engine start sound.     |
| `EngineStopSound`   | `AudioSource` | The audio source for the engine stop sound.      |
| `HeadlightsOnSound` | `AudioSource` | The audio source for the headlights on sound.    |
| `HeadlightsOffSound`| `AudioSource` | The audio source for the headlights off sound.   |
| `HornSound`         | `AudioSource` | The audio source for the horn sound.             |

## Protected Methods

| Method                | Return Type | Description                               |
| --------------------- | ----------- | ----------------------------------------- |
| `Awake()`               | `void`      | Initializes the component.                |
| `EngineStart()`         | `void`      | Called when the engine starts.            |
| `EngineStop()`          | `void`      | Called when the engine stops.             |
| `HeadlightsToggledOn()` | `void`      | Called when the headlights are turned on. |
| `HeadlightsToggledOff()`| `void`      | Called when the headlights are turned off.|
