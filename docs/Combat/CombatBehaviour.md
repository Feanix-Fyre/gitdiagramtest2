# CombatBehaviour

Inherits from `ScheduleOne.NPCs.Behaviour.Behaviour`.

## Description

This is a comprehensive NPC behaviour class that manages all aspects of combat against a player target. It handles target acquisition, movement, weapon usage, line-of-sight checks, and searching for the target if they are lost.

## Key Fields & Properties

-   **TargetPlayer**: `Player` (read-only) - The player the NPC is currently engaged in combat with.
-   **DefaultWeapon**: `AvatarWeapon` - The default weapon the NPC will equip when entering combat.
-   **VirtualPunchWeapon**: `AvatarMeleeWeapon` - A "virtual" weapon used for unarmed attacks.
-   **GiveUpRange**: `float` - The maximum distance the target can be before the NPC gives up and ends combat.
-   **GiveUpTime**: `float` - The maximum time the NPC will search for a lost target before giving up.
-   **IsSearching**: `bool` (read-only) - Is the NPC currently in a "search" state for a lost target?
-   **timeSinceLastSighting**: `protected float` - A timer tracking how long it has been since the target was visible.
-   **lastKnownTargetPosition**: `protected Vector3` - The last position where the target was seen.

## Core Logic & State Machine

The `CombatBehaviour` operates as a state machine driven by the visibility of the `TargetPlayer`.

1.  **StartCombat**: When the behaviour begins, the NPC equips its `DefaultWeapon`, sets its emotional state to "Angry", and adjusts its movement parameters for combat.

2.  **Target Visible (`isTargetRecentlyVisible` is true)**:
    -   The NPC will try to maintain an optimal distance from the target based on its current weapon's `MinUseRange` and `MaxUseRange`.
    -   It calls `RepositionToTargetRange` to move if it's too close or too far.
    -   If it's within range and ready to attack, it calls `Attack()`.
    -   The `lastKnownTargetPosition` is continuously updated.

3.  **Target Lost (`isTargetRecentlyVisible` is false)**:
    -   The NPC will move towards the `lastKnownTargetPosition`.
    -   Once it reaches that position, if the target is still not visible, it calls `StartSearching()`.

4.  **Searching**:
    -   The NPC moves to random reachable points within an expanding radius around the `lastKnownTargetPosition`.
    -   The search continues until the target is reacquired or the `GiveUpTime` is exceeded.

5.  **EndCombat**: Combat ends if the target is invalid (dead, arrested), gets too far away (`GiveUpRange`), or is not found within the `GiveUpTime`. The NPC unequips its weapon and returns to a normal state.

## Key Methods

### SetTarget
`public virtual void SetTarget(NetworkConnection conn, NetworkObject target)`

An RPC to assign a `Player` as the combat target. This is the entry point for initiating combat.

### BehaviourUpdate
`public override void BehaviourUpdate()`

The main update loop for the behaviour. It directs the NPC's actions based on the current state (target visible, target lost, searching).

### Attack
`protected virtual void Attack()`

An RPC that triggers an attack with the `currentWeapon` or the `VirtualPunchWeapon` if unarmed.

### CheckPlayerVisibility
`protected void CheckPlayerVisibility()`

Called every frame to update the visibility status of the target using the NPC's `VisionCone`. It manages the `isTargetRecentlyVisible` and `isTargetImmediatelyVisible` flags and the `timeSinceLastSighting` timer.

### StartSearching / StopSearching
`private void StartSearching()` and `private void StopSearching()`

Methods to start and stop the search routine coroutine, which handles the logic for looking for a lost target.
