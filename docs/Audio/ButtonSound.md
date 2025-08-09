# ButtonSound

The `ButtonSound` class adds hover and click sounds to a UI button. This component requires a `Button`, `EventTrigger`, and `AudioSourceController`.

## Public Properties

| Property           | Type                  | Description                                                  |
| ------------------ | --------------------- | ------------------------------------------------------------ |
| `AudioSource`      | `AudioSourceController` | The audio source to play the sounds from.                    |
| `EventTrigger`     | `EventTrigger`        | The event trigger that detects the hover and click events.   |
| `HoverClip`        | `AudioClip`           | The audio clip to play on hover.                             |
| `HoverSoundVolume` | `float`               | The volume of the hover sound.                               |
| `ClickClip`        | `AudioClip`           | The audio clip to play on click.                             |
| `ClickSoundVolume` | `float`               | The volume of the click sound.                               |

## Public Methods

| Method                                      | Return Type | Description                               |
| ------------------------------------------- | ----------- | ----------------------------------------- |
| `AddEventTrigger(EventTrigger eventTrigger, EventTriggerType eventTriggerType, Action action)` | `void`      | Adds a new event trigger to the button.   |

## Protected Methods

| Method    | Return Type | Description               |
| --------- | ----------- | ------------------------- |
| `Hovered()` | `void`      | Plays the hover sound.    |
| `Clicked()` | `void`      | Plays the click sound.    |
