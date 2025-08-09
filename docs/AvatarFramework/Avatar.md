# Avatar

The `Avatar` class is a comprehensive component that manages the player's avatar, including its appearance, animation, and equipment.

## Properties

-   `Anim`: The `AvatarAnimation` component for controlling avatar animations.
-   `LookController`: The `AvatarLookController` for managing where the avatar is looking.
-   `BodyMeshes`: An array of `SkinnedMeshRenderer` components for the avatar's body.
-   `FaceMesh`: The `SkinnedMeshRenderer` for the avatar's face.
-   `Eyes`: The `EyeController` for managing the avatar's eyes.
-   `EyeBrows`: The `EyebrowController` for managing the avatar's eyebrows.
-   `Ragdolled`: A boolean that indicates whether the avatar is currently in a ragdoll state.
-   `CurrentEquippable`: The `AvatarEquippable` item that the avatar is currently holding.
-   `CurrentSettings`: The `AvatarSettings` currently applied to the avatar.

## Methods

### `LoadAvatarSettings(AvatarSettings settings)`

Loads and applies a complete set of avatar settings, including body shape, hair, accessories, and clothing.

-   **Parameters:**
    -   `settings`: The `AvatarSettings` to apply.

### `LoadNakedSettings(AvatarSettings settings, int maxLayerOrder = 19)`

Loads a "naked" version of the avatar settings, applying only the base body and facial features.

-   **Parameters:**
    -   `settings`: The `AvatarSettings` to apply.
    -   `maxLayerOrder`: The maximum layer order to apply for clothing.

### `ApplyBodySettings(AvatarSettings settings)`

Applies the body-specific settings from the given `AvatarSettings`, such as gender, weight, and height.

### `SetSkinColor(Color color)`

Sets the skin color of the avatar.

### `ApplyHairSettings(AvatarSettings settings)`

Applies the hair style from the given `AvatarSettings`.

### `ApplyAccessorySettings(AvatarSettings settings)`

Applies all accessories from the given `AvatarSettings`.

### `SetRagdollPhysicsEnabled(bool ragdollEnabled, bool playStandUpAnim = true)`

Enables or disables the avatar's ragdoll physics.

-   **Parameters:**
    -   `ragdollEnabled`: Whether to enable or disable the ragdoll state.
    -   `playStandUpAnim`: Whether to play a stand-up animation when exiting the ragdoll state.

### `SetEquippable(string assetPath)`

Equips the avatar with the specified item.

-   **Parameters:**
    -   `assetPath`: The asset path of the equippable item.
-   **Returns:** The equipped `AvatarEquippable` instance.
