# Peephole

Inherits from `MonoBehaviour`.

## Description

This class controls the behavior of a door's peephole, handling the animations and sound effects for opening and closing it.

## Fields

-   **DoorAnim**: `Animation`
    -   A reference to the `Animation` component that contains the "Peephole open" and "Peephole close" clips.
-   **OpenSound**: `AudioSourceController`
    -   The audio source for the sound effect when the peephole is opened.
-   **CloseSound**: `AudioSourceController`
    -   The audio source for the sound effect when the peephole is closed.

## Methods

### Open
`public void Open()`

Plays the "Peephole open" animation and the corresponding open sound effect.

### Close
`public void Close()`

Plays the "Peephole close" animation and the corresponding close sound effect.
