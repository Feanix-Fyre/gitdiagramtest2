# StartLoopStopAudio

The `StartLoopStopAudio` class plays a sequence of sounds: a start sound, a looping sound, and a stop sound. It can also fade the looping sound in and out.

## Public Properties

| Property      | Type                  | Description                                                  |
| ------------- | --------------------- | ------------------------------------------------------------ |
| `StartSound`  | `AudioSourceController` | The audio source for the start sound.                        |
| `LoopSound`   | `AudioSourceController` | The audio source for the looping sound.                      |
| `StopSound`   | `AudioSourceController` | The audio source for the stop sound.                         |
| `FadeLoopIn`  | `bool`                | A flag to enable or disable fading in the looping sound.     |
| `FadeLoopOut` | `bool`                | A flag to enable or disable fading out the looping sound.    |
| `Runnning`    | `bool`                | A boolean indicating whether the audio is currently running. |

## Public Methods

| Method       | Return Type | Description                |
| ------------ | ----------- | -------------------------- |
| `StartAudio()` | `void`      | Starts the audio sequence. |
| `StopAudio()`  | `void`      | Stops the audio sequence.  |
