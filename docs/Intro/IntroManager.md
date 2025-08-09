# IntroManager

Inherits from `Singleton<IntroManager>`.

## Description

This singleton class manages the game's introductory cutscene sequence. It controls a main animation, handles player controls, camera overrides, and transitions into the character creator. It also includes logic for skipping parts of the intro.

## Key Fields

-   **TimeOfDayOverride**: `int` - The in-game time that will be set when the intro starts.
-   **Anim**: `Animation` - The main `Animation` component that drives the intro cutscene.
-   **CameraContainer**: `Transform` - The transform that the player's camera will be parented to and follow during the intro.
-   **SkipContainer**: `GameObject` - The UI container for the "hold to skip" dial.
-   **rv**: `RV` - A reference to the RV object, which is part of the intro sequence.
-   **onIntroDone**: `UnityEvent` - An event invoked when the entire intro sequence (including character creation) is complete.

## Properties

-   **IsPlaying**: `bool` (read-only) - True if the intro cutscene is currently playing.

## Core Logic

1.  **Play**:
    -   The `Play()` method is the main entry point to start the intro.
    -   It disables player controls, hides the HUD, and takes control of the player's camera, attaching it to the `CameraContainer`.
    -   It waits until the main game scene is loaded (`LoadManager.IsGameLoaded`).
    -   It plays the main `Anim` and starts the intro music.
    -   A coroutine then waits for the animation to finish.

2.  **Transition to Character Creation**:
    -   Once the animation is finished, it fades the screen to black.
    -   It opens the `CharacterCreator` UI.
    -   It adds `CharacterCreationDone` as a listener to the creator's `onCompleteWithClothing` event.
    -   It teleports the player to the default spawn point and cleans up the intro-specific GameObjects.
    -   It fades the screen back in.

3.  **Character Creation Done**:
    -   The `CharacterCreationDone` method is called when the player finalizes their character.
    -   It fades to black again.
    -   It teleports the player to their initial starting position inside the RV.
    -   It restores all player controls and the HUD.
    -   It gives the player their starting clothes.
    -   It invokes the `onIntroDone` event.
    -   It triggers the first game save.

4.  **Skipping**:
    -   The `Update` loop checks if the player is holding down an interact/jump/submit key.
    -   If a key is held for `SKIP_TIME` (0.5 seconds), it finds the next animation event in the `Anim` clip and fast-forwards the animation's time to that point, effectively skipping a segment of the cutscene.

## Public Methods

### Play
`public void Play()`

Starts the entire intro sequence.

### CharacterCreationDone
`public void CharacterCreationDone(BasicAvatarSettings avatar, List<ClothingInstance> clothes)`

The callback method for when character creation is finished. Handles the final transition into gameplay.

### PassedStep
`public void PassedStep(int stepIndex)`

An animation event callback that updates the `CurrentStep` of the intro, used by the skipping logic to know where to skip to.
