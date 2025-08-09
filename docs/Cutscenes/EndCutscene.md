# EndCutscene

Inherits from `Cutscene`.

## Description

This class represents a specific, named cutscene, likely for the end of a demo or section of the game. It extends the base `Cutscene` with additional `UnityEvent`s that can be triggered at specific points in the animation, and it controls a separate `Avatar` within the cutscene.

## Fields

-   **onStandUp**: `UnityEvent`
    -   An event invoked when the avatar should stand up.
-   **onRunStart**: `UnityEvent`
    -   An event invoked when the avatar should start running.
-   **onEngineStart**: `UnityEvent`
    -   An event invoked when a vehicle engine should start.
-   **Avatar**: `Avatar`
    -   A reference to the avatar that is part of this cutscene (distinct from the player's avatar).

## Methods

### Play
`public override void Play()`

Overrides the base `Play` method. Before playing the cutscene, it loads the local player's current appearance (`AvatarSettings`) onto the cutscene's `Avatar`, ensuring the character in the cutscene matches the player.

### StandUp / RunStart / EngineStart
`public void StandUp()`
`public void RunStart()`
`public void EngineStart()`

These are public methods designed to be called by animation events at specific frames within the cutscene's animation clip. They simply invoke their corresponding `UnityEvent`s (`onStandUp`, `onRunStart`, `onEngineStart`).

### On3rdPerson
`public void On3rdPerson()`

A method, likely called by an animation event, to prepare the cutscene's `Avatar` for being viewed. It activates the avatar's GameObject and sets the "Sitting" boolean on its animator.
