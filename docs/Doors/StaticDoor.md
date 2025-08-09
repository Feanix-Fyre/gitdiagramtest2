# StaticDoor

Inherits from `MonoBehaviour`.

## Description

This class represents a door that cannot be opened by the player directly. Instead, the player can knock on it to summon an NPC from inside the associated `NPCEnterableBuilding`.

## Fields

-   **AccessPoint**: `Transform`
    -   A transform defining the point where an NPC will stand when they come to the door.
-   **IntObj**: `InteractableObject`
    -   The `InteractableObject` component for the door, which handles hover and click events.
-   **KnockSound**: `AudioSourceController`
    -   The sound effect played when the player knocks.
-   **Building**: `NPCEnterableBuilding`
    -   A reference to the building this door belongs to.
-   **CanKnock**: `bool`
    -   A flag to enable or disable the knocking functionality.

## Core Logic

-   **Knocking**:
    1.  When the player interacts with the door (`Interacted`), it calls `Knock()`.
    2.  `Knock()` puts the interaction on a cooldown, plays the `KnockSound`, and starts a coroutine.
    3.  The coroutine waits briefly, then checks if there are any NPCs inside the `Building`.
    4.  If there is one NPC, `NPCSelected` is called immediately for that NPC.
    5.  If there are multiple NPCs, the `NPCSummonMenu` is opened, allowing the player to choose which NPC to summon. The chosen NPC is then passed to `NPCSelected`.
-   **Summoning**:
    -   `NPCSelected` calls the `Summon` method on the chosen NPC's behaviour component. This instructs the NPC to walk to this door's `AccessPoint` and wait for a set duration.
-   **Interaction State**:
    -   The `Hovered` method updates the `IntObj`'s message and state. It will show "Knock" if knocking is allowed, display an error message if `IsKnockValid` fails, or be disabled if on cooldown.

## Methods

### CanKnockNow
`protected virtual bool CanKnockNow()`

Checks if the player is currently allowed to knock (i.e., `CanKnock` is true and the cooldown has passed).

### IsKnockValid
`protected virtual bool IsKnockValid(out string message)`

A virtual method that can be overridden by derived classes to add extra conditions for a knock to be valid. By default, it always returns `true`.

### Knock
`protected virtual void Knock()`

Initiates the knocking sequence as described in the Core Logic section.

### NPCSelected
`protected virtual void NPCSelected(NPC npc)`

Called after an NPC has been chosen to answer the door. It commands the NPC to come to the door.
