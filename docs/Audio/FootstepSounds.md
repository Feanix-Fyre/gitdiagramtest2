# FootstepSounds

The `FootstepSounds` class manages the playback of footstep sounds based on the material type of the surface being walked on.

## FootstepSoundGroup (Inner Class)

Represents a group of footstep sounds for a specific set of material types.

| Property    | Type                  | Description                                                  |
| ----------- | --------------------- | ------------------------------------------------------------ |
| `name`      | `string`              | The name of the sound group.                                 |
| `clips`     | `List<AudioClip>`     | A list of audio clips for this sound group.                  |
| `appliesTo` | `List<MaterialType>`  | A list of material types that this sound group applies to.   |
| `PitchMin`  | `float`               | The minimum pitch for the footstep sounds.                   |
| `PitchMax`  | `float`               | The maximum pitch for the footstep sounds.                   |
| `Volume`    | `float`               | The volume of the footstep sounds.                           |

### MaterialType (Inner Class)

Represents a material type for a footstep sound group.

| Property | Type          | Description            |
| -------- | ------------- | ---------------------- |
| `type`   | `EMaterialType` | The material type.     |

## Public Constants

| Constant        | Type    | Description                               |
| --------------- | ------- | ----------------------------------------- |
| `COOLDOWN_TIME` | `float` | The cooldown time between footstep sounds. |

## Public Properties

| Property      | Type                          | Description                                                    |
| ------------- | ----------------------------- | -------------------------------------------------------------- |
| `sources`     | `List<AudioSourceController>` | A list of audio sources to play the footstep sounds from.      |
| `soundGroups` | `List<FootstepSoundGroup>`    | A list of footstep sound groups.                               |

## Public Methods

| Method                                      | Return Type             | Description                                                              |
| ------------------------------------------- | ----------------------- | ------------------------------------------------------------------------ |
| `Step(EMaterialType materialType, float hardness)` | `void`                  | Plays a footstep sound for the given material type and hardness.         |
| `GetFreeSource()`                           | `AudioSourceController` | Returns a free audio source from the pool.                               |
