# HeartbeatSoundController

The `HeartbeatSoundController` class controls a heartbeat sound, adjusting its volume and pitch using `FloatSmoother`s.

## Public Properties

| Property         | Type                  | Description                                                  |
| ---------------- | --------------------- | ------------------------------------------------------------ |
| `sound`          | `AudioSourceController` | The audio source for the heartbeat sound.                    |
| `VolumeController` | `FloatSmoother`       | A `FloatSmoother` to control the volume of the heartbeat sound. |
| `PitchController`  | `FloatSmoother`       | A `FloatSmoother` to control the pitch of the heartbeat sound.  |
