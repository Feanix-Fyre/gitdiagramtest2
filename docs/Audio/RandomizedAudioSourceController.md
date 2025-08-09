# RandomizedAudioSourceController

The `RandomizedAudioSourceController` class is a type of `AudioSourceController` that plays a random audio clip from a list of clips.

## Public Properties

| Property | Type          | Description                                     |
| -------- | ------------- | ----------------------------------------------- |
| `Clips`  | `AudioClip[]` | An array of audio clips to be played randomly. |

## Public Methods

| Method                                      | Return Type | Description                                                                    |
| ------------------------------------------- | ----------- | ------------------------------------------------------------------------------ |
| `Play()`                                    | `void`      | Overrides the base `Play` method to play a random clip from the `Clips` array. |
| `PlayOneShot(bool duplicateAudioSource = false)` | `void`      | Overrides the base `PlayOneShot` method to play a random clip from the `Clips` array as a one-shot. |
