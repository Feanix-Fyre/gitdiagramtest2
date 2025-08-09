# AmbientLoopJukebox

The `AmbientLoopJukebox` class plays a list of audio clips in a shuffled order, adjusting the volume based on the time of day and whether music is playing. This component requires an `AudioSourceController`.

## Public Properties

| Property      | Type                | Description                                                                 |
| ------------- | ------------------- | --------------------------------------------------------------------------- |
| `VolumeCurve` | `AnimationCurve`    | A curve that defines the volume of the ambient loop over the course of a day. |
| `Clips`       | `List<AudioClip>`   | A list of audio clips to be played by the jukebox.                          |
