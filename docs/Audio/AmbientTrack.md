# AmbientTrack

The `AmbientTrack` class manages the playback of ambient music tracks, with conditions based on the time of day, chance, and other factors.

## Public Constants

| Constant                          | Type    | Description                                                 |
| --------------------------------- | ------- | ----------------------------------------------------------- |
| `MIN_TIME_BETWEEN_AMBIENT_TRACKS` | `float` | The minimum time in seconds between playing ambient tracks. |

## Public Static Properties

| Property          | Type           | Description                                                        |
| ----------------- | -------------- | ------------------------------------------------------------------ |
| `LastPlayedTrack` | `AmbientTrack` | The last `AmbientTrack` that was played.                           |
| `TrackQueued`     | `bool`         | A flag indicating whether a track is currently queued to be played. |

## Public Properties

| Property  | Type                | Description                                                                    |
| --------- | ------------------- | ------------------------------------------------------------------------------ |
| `Tracks`  | `List<MusicTrack>`  | A list of `MusicTrack`s to be played.                                          |
| `MinTime` | `int`               | The minimum time of day (in 24-hour format) when the track can play.         |
| `MaxTime` | `int`               | The maximum time of day (in 24-hour format) when the track can play.         |
| `Chance`  | `float`             | The chance (from 0 to 1) that the track will play.                             |

## Public Methods

| Method      | Return Type | Description                                       |
| ----------- | ----------- | ------------------------------------------------- |
| `ForcePlay()` | `void`      | Forces the next track in the list to play immediately. |
| `Stop()`      | `void`      | Stops the currently playing track.                |

## Protected Methods

| Method                  | Return Type | Description                                               |
| ----------------------- | ----------- | --------------------------------------------------------- |
| `CanStartAmbientTrack()`| `bool`      | Returns a boolean indicating whether an ambient track can be started. |
