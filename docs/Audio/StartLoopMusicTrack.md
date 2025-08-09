# StartLoopMusicTrack

The `StartLoopMusicTrack` class is a type of `MusicTrack` that plays a start sound and then transitions to a looping sound.

## Public Properties

| Property    | Type                  | Description                               |
| ----------- | --------------------- | ----------------------------------------- |
| `LoopSound` | `AudioSourceController` | The audio source for the looping sound. |

## Public Methods

| Method | Return Type | Description                                                              |
| ------ | ----------- | ------------------------------------------------------------------------ |
| `Play()` | `void`      | Overrides the base `Play` method to play the start sound and then the looping sound. |
