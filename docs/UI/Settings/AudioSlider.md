# AudioSlider

The `AudioSlider` class inherits from `SettingsSlider` and is used to control the audio settings. It can control the master volume or the volume of a specific audio type.

## Public Constants

| Constant   | Type  | Description                                      |
| ---------- | ----- | ------------------------------------------------ |
| `MULTIPLIER` | `float` | A multiplier for the audio volume.               |

## Public Properties

| Property    | Type         | Description                                      |
| ----------- | ------------ | ------------------------------------------------ |
| `Master`    | `bool`       | If true, this slider controls the master volume. |
| `AudioType` | `EAudioType` | The audio type that this slider controls.        |

## Protected Methods

| Method               | Return Type | Description                                      |
| -------------------- | ----------- | ------------------------------------------------ |
| `Start()`            | `void`      | Called when the component is started.            |
| `OnValueChanged(float value)` | `void` | Called when the value of the slider changes.     |
