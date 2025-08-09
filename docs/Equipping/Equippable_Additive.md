# Equippable_Additive

Inherits from `Equippable_Pourable`.

## Description

This class represents an equippable "additive" item (like fertilizer or a chemical) that can be poured into a `Pot`. It extends the `Equippable_Pourable` logic with conditions and actions specific to applying additives.

## Fields

-   **additiveDef**: `private AdditiveDefinition`
    -   A reference to the `AdditiveDefinition` of the item instance, cached on equip.

## Methods

### Equip
`public override void Equip(ItemInstance item)`

Overrides the base `Equip` method. It caches the `AdditiveDefinition` and sets the `InteractionLabel` to "Apply [Additive Name]".

### StartPourTask
`protected override void StartPourTask(Pot pot)`

Overrides the base method to start an `ApplyAdditiveToPot` player task, which handles the logic and animation of applying the additive.

-   **Parameters:**
    -   `pot`: The target `Pot` to apply the additive to.

### CanPour
`protected override bool CanPour(Pot pot, out string reason)`

Overrides the base method to add specific validation checks for applying additives. An additive can only be poured if:
1.  The target `pot` has soil.
2.  The `pot` has a plant in it.
3.  The `pot` does not already contain this specific additive.

-   **Parameters:**
    -   `pot`: The target `Pot`.
    -   `reason`: An `out` parameter for the message explaining why it cannot be poured.
-   **Returns:** `true` if the additive can be applied, otherwise `false`.
