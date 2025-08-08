# AmbientLoop

The `AmbientLoop` class controls an ambient audio loop, adjusting its volume based on the time of day and whether music is playing. This component requires an `AudioSourceController`.

## Public Constants

| Constant                | Type    | Description                                                     |
| ----------------------- | ------- | --------------------------------------------------------------- |
| `MUSIC_FADE_MULTIPLIER` | `float` | A multiplier for fading the ambient loop when music is playing. |

## Public Properties

| Property          | Type             | Description                                                                 |
| ----------------- | ---------------- | --------------------------------------------------------------------------- |
| `VolumeCurve`     | `AnimationCurve` | A curve that defines the volume of the ambient loop over the course of a day. |
| `FadeDuringMusic` | `bool`           | A flag to enable or disable fading the ambient loop when music is playing.  |
