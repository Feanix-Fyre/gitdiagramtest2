# TutorialTimeController

Inherits from `MonoBehaviour`.

## Description

This class is a specialized controller for managing the flow of time during the game's tutorial sequence. It uses a series of "keyframes" to dynamically change the `TimeProgressionMultiplier` in the `TimeManager`, allowing for scripted moments where time speeds up or slows down.

## Inner Structs

### KeyFrame
A struct representing a single point in the tutorial's timeline.
-   **Time**: `int` - The in-game time (e.g., 1400 for 2:00 PM) at which this keyframe ends.
-   **SpeedMultiplier**: `float` - The base speed multiplier for this segment of time.
-   **Note**: `string` - A descriptive note for the keyframe, visible in the Inspector.

## Fields

-   **TimeProgressionCurve**: `AnimationCurve`
    -   An animation curve that modifies the `SpeedMultiplier` over the duration of a keyframe segment. This allows for smooth acceleration or deceleration of time within a segment.
-   **KeyFrames**: `KeyFrame[]`
    -   An array of keyframes that define the tutorial's timeline.

## Core Logic

-   **Keyframe Progression**: The controller starts at `currentKeyFrameIndex = 0`. It subscribes to the `TimeManager.onSleepStart` event, so each time the player sleeps, `IncrementKeyframe` is called, moving the tutorial to the next time segment.
-   **Time Scale Calculation (`Update`)**:
    1.  It gets the start time of the current segment (either the previous keyframe's time or the default start time).
    2.  It gets the end time from the current keyframe.
    3.  It calculates the current progress through the segment as a normalized value (0.0 to 1.0).
    4.  It evaluates the `TimeProgressionCurve` at this progress point.
    5.  It multiplies the result by the keyframe's `SpeedMultiplier` to get the final time scale.
    6.  It sets this calculated value as the `TimeManager.TimeProgressionMultiplier`.

## Public Methods

### IncrementKeyframe
`public void IncrementKeyframe()`

Moves to the next keyframe in the `KeyFrames` array. This is called automatically when the player sleeps.

### Disable
`public void Disable()`

Disables the controller, restores the `TimeProgressionMultiplier` to its default value of 1, and stops it from affecting the game time.
