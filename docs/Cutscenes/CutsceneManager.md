# CutsceneManager

Inherits from `Singleton<CutsceneManager>`.

## Description

A manager class for handling all the `Cutscene`s in the game. It holds a list of all available cutscenes and provides a simple way to play them by name.

## Fields

-   **Cutscenes**: `List<Cutscene>`
    -   A list of all `Cutscene` components in the scene. This is likely populated in the Inspector.
-   **cutsceneName**: `[SerializeField] private string`
    -   A private field exposed to the Inspector for testing. The name entered here can be played using the `RunCutscene` button.
-   **playingCutscene**: `private Cutscene`
    -   A reference to the cutscene that is currently playing.

## Methods

### RunCutscene
`private void RunCutscene()`

A private method exposed as a button in the Inspector via the `[Button]` attribute. It calls `Play` with the `cutsceneName` string, allowing for easy testing of cutscenes from the editor.

### Play
`public void Play(string name)`

Finds a cutscene in the `Cutscenes` list by its `name` and plays it. It also subscribes the `Ended` method to the cutscene's `onEnd` event to know when it has finished.

-   **Parameters:**
    -   `name`: The name of the cutscene to play.

### Ended
`private void Ended()`

An event handler that is called when the `playingCutscene`'s `onEnd` event is invoked. It unsubscribes from the event and clears the `playingCutscene` reference.
