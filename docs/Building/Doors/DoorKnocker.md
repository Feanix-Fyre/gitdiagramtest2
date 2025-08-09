# DoorKnocker

Inherits from `MonoBehaviour`.

## Description

This class controls the behavior of a door knocker, handling its animation and sound effects.

## Fields

-   **Anim**: `Animation`
    -   A reference to the `Animation` component for the door knocker model.
-   **KnockingSoundClipName**: `string`
    -   The name of the animation clip to play when the knocker is used.
-   **KnockingSound**: `AudioSource`
    -   The audio source for the knocking sound effect.

## Methods

### Knock
`public void Knock()`

Initiates the knocking action. It stops any currently playing animation and then plays the knocking animation clip specified by `KnockingSoundClipName`.

### PlayKnockingSound
`public void PlayKnockingSound()`

Plays the knocking sound effect. This method is likely intended to be called by an animation event within the knocking animation clip to synchronize the sound with the visual movement.
