# SFXManager

The `SFXManager` class is a singleton that manages the playback of sound effects, particularly impact sounds. It uses a pool of audio sources to play the sounds.

## ImpactType (Inner Class)

Represents a type of impact sound.

| Property   | Type                        | Description                                                  |
| ---------- | --------------------------- | ------------------------------------------------------------ |
| `Material` | `ImpactSoundEntity.EMaterial` | The material type that this impact sound applies to.         |
| `MinVolume`| `float`                     | The minimum volume of the impact sound.                      |
| `MaxVolume`| `float`                     | The maximum volume of the impact sound.                      |
| `MinPitch` | `float`                     | The minimum pitch of the impact sound.                       |
| `MaxPitch` | `float`                     | The maximum pitch of the impact sound.                       |
| `Clips`    | `AudioClip[]`               | An array of audio clips for the impact sound.                |

## Public Constants

| Constant                  | Type    | Description                                                              |
| ------------------------- | ------- | ------------------------------------------------------------------------ |
| `MAX_PLAYER_DISTANCE`     | `float` | The maximum distance from the player that an impact sound can be heard.    |
| `SQR_MAX_PLAYER_DISTANCE` | `float` | The squared maximum distance from the player that an impact sound can be heard. |

## Public Properties

| Property      | Type             | Description                         |
| ------------- | ---------------- | ----------------------------------- |
| `ImpactTypes` | `List<ImpactType>` | A list of all impact sound types. |

## Public Methods

| Method                                      | Return Type | Description                                                              |
| ------------------------------------------- | ----------- | ------------------------------------------------------------------------ |
| `PlayImpactSound(ImpactSoundEntity.EMaterial material, Vector3 position, float momentum)` | `void`      | Plays an impact sound at the given position with the given momentum.   |
