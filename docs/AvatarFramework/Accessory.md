# Accessory

The `Accessory` class defines a component for avatar accessories, managing their properties and appearance.

## Properties

-   `Name`: The name of the accessory.
-   `AssetPath`: The asset path of the accessory.
-   `ReduceFootSize`: A boolean indicating whether the accessory should reduce the avatar's foot size.
-   `FootSizeReduction`: A float value between 0 and 1 that determines the amount of foot size reduction.
-   `ShouldBlockHair`: A boolean indicating whether the accessory should block the avatar's hair.
-   `ColorAllMeshes`: A boolean that, if true, applies the color to all meshes of the accessory.
-   `meshesToColor`: An array of `MeshRenderer` components to which color should be applied.
-   `skinnedMeshesToColor`: An array of `SkinnedMeshRenderer` components to which color should be applied.
-   `skinnedMeshesToBind`: An array of `SkinnedMeshRenderer` components to which the avatar's bones should be bound.
-   `shapeKeyMeshRends`: An array of `SkinnedMeshRenderer` components that have shape keys to be controlled.

## Methods

### `Awake()`

Called when the script instance is being loaded, this method ensures that all `skinnedMeshesToBind` are updated even when off-screen.

### `ApplyColor(Color col)`

Applies the specified color to all the meshes defined in `meshesToColor` and `skinnedMeshesToColor`.

-   **Parameters:**
    -   `col`: The `Color` to apply.

### `ApplyShapeKeys(float gender, float weight)`

Applies gender and weight shape keys to the meshes in `shapeKeyMeshRends`.

-   **Parameters:**
    -   `gender`: The gender value for the shape key.
    -   `weight`: The weight value for the shape key.

### `BindBones(Transform[] bones)`

Binds the accessory's skinned meshes to the avatar's bones.

-   **Parameters:**
    -   `bones`: An array of `Transform` objects representing the avatar's bones.
