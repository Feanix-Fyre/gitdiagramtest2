# RelationCircle

The `RelationCircle` class is the UI for a single relation in the relations screen. It displays the NPC's portrait, and it has a notch that indicates the player's relationship with the NPC. It also has a locked state for when the player has not met the NPC yet.

## Public Constants

| Constant                      | Type  | Description                                      |
| ----------------------------- | ----- | ------------------------------------------------ |
| `NotchMinRot`                 | `float` | The minimum rotation of the notch.               |
| `NotchMaxRot`                 | `float` | The maximum rotation of the notch.               |
| `PortraitColor_ZeroDependence`| `Color` | The color of the portrait when the NPC has zero dependence. |
| `PortraitColor_MaxDependence` | `Color` | The color of the portrait when the NPC has maximum dependence. |

## Public Properties

| Property         | Type     | Description                                      |
| ---------------- | -------- | ------------------------------------------------ |
| `AssignedNPC_ID` | `string` | The ID of the NPC that this circle represents.   |
| `AssignedNPC`    | `NPC`      | The `NPC` that this circle represents.           |
| `onClicked`      | `Action` | An event that is invoked when the circle is clicked. |
| `onHoverStart`   | `Action` | An event that is invoked when the mouse hovers over the circle. |
| `onHoverEnd`     | `Action` | An event that is invoked when the mouse stops hovering over the circle. |
| `AutoSetName`    | `bool`   | If true, the name of the game object will be set to the NPC's ID. |
| `Rect`           | `RectTransform` | The `RectTransform` of the circle.                 |
| `PortraitBackground` | `Image` | The background image for the portrait.           |
| `HeadshotImg`    | `Image`  | The image for the NPC's headshot.                |
| `NotchPivot`     | `RectTransform` | The pivot for the notch.                         |
| `Locked`         | `RectTransform` | The transform of the locked icon.                |
| `Button`         | `Button` | The button component for the circle.             |
| `Trigger`        | `EventTrigger` | The event trigger for the circle.                |

## Public Methods

| Method                                      | Return Type | Description                                      |
| ------------------------------------------- | ----------- | ------------------------------------------------ |
| `AssignNPC(NPC npc)`                        | `void`      | Assigns an NPC to this circle.                   |
| `SetNotchPosition(float relationshipDelta)` | `void`      | Sets the position of the notch.                  |
| `SetLocked()`                               | `void`      | Sets the circle to the locked state.             |
| `SetUnlocked(NPCRelationData.EUnlockType unlockType, bool notify = true)` | `void` | Sets the circle to the unlocked state.           |
| `LoadNPCData()`                             | `void`      | Loads the NPC data for this circle.              |
| `SetBlackedOut(bool blackedOut)`            | `void`      | Sets whether the circle is blacked out.          |
