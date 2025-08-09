# AvatarEquippable

Inherits from `MonoBehaviour`.

## Description

A base class for items that can be equipped by an `Avatar`. It handles parenting the item to the avatar's hand, aligning it correctly, and setting the appropriate animation triggers.

## Enums

### ETriggerType
-   **Trigger**: Use an animation trigger.
-   **Bool**: Use an animation boolean parameter.

### EHand
-   **Left**: Equip to the left hand.
-   **Right**: Equip to the right hand.

## Fields

-   **AlignmentPoint**: `Transform`
    -   A child transform used to align the equippable with the hand's alignment point.
-   **Suspiciousness**: `float`
    -   A value from 0 to 1 indicating how suspicious this item is when held.
-   **Hand**: `EHand`
    -   The hand to which this item should be equipped.
-   **TriggerType**: `ETriggerType`
    -   The type of animation parameter to use for the holding animation.
-   **AnimationTrigger**: `string`
    -   The name of the animation trigger or boolean parameter to set when equipped.
-   **AssetPath**: `string`
    -   The path to this asset in the Resources folder.
-   **avatar**: `protected Avatar`
    -   A reference to the avatar that has equipped this item.

## Methods

### RecalculateAssetPath
`public void RecalculateAssetPath()`

A button-callable method to automatically determine and set the `AssetPath`.

### Equip
`public virtual void Equip(Avatar _avatar)`

Called when the item is equipped. It parents the item to the correct hand, aligns it, initializes the animation, and sets the object's layer.

-   **Parameters:**
    -   `_avatar`: The avatar that is equipping this item.

### InitializeAnimation
`public virtual void InitializeAnimation()`

Sets the initial animation state (trigger or bool) for holding the item.

### Unequip
`public virtual void Unequip()`

Called when the item is unequipped. It resets the animation state and destroys the item's game object.

### SetTrigger
`protected void SetTrigger(string anim)`

Sets an animation trigger on the character (Player or NPC) that is holding the item.

### SetBool
`protected void SetBool(string anim, bool val)`

Sets an animation boolean on the character (Player or NPC) that is holding the item.

### ResetTrigger
`protected void ResetTrigger(string anim)`

Resets an animation trigger on the character (Player or NPC) that is holding the item.

### ReceiveMessage
`public virtual void ReceiveMessage(string message, object parameter)`

A virtual method to allow external scripts to send messages to the equippable item.
