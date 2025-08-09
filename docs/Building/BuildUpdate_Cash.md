# BuildUpdate_Cash

Inherits from `BuildUpdate_StoredItem`.

## Description

This class handles the per-frame update logic for placing cash stacks. It extends the functionality of `BuildUpdate_StoredItem` to include logic for cycling through different cash amounts, updating the visual appearance of the cash stack ghost model, and displaying the selected amount in a world-space label.

## Fields

-   **amountIndex**: `int` - The index into the `Cash.amounts` array, determining the current amount to place.
-   **bills**: `protected List<Transform>` - A list of transforms for the individual bill stacks in the ghost model.
-   **amountLabel**: `private WorldSpaceLabel` - The world-space label used to display the currently selected amount.

## Properties

-   **placeAmount**: `private float` - The current cash amount to be placed, determined by `amountIndex`.

## Methods

### Start
`private void Start()`

Initializes the component by gathering the bill transforms from the ghost model, refreshing its appearance, and creating the `amountLabel`.

### Update
`protected override void Update()`

Handles input. On a secondary click, it increments `amountIndex` to cycle through the available cash placement amounts and refreshes the ghost model's appearance.

### LateUpdate
`protected override void LateUpdate()`

Performs checks and updates the `amountLabel`. It ensures the player has enough cash to place the selected amount, automatically cycling down to a lower amount if they don't. It also updates the text and color of the `amountLabel` based on placement validity.

### RefreshGhostModelAppearance
`private void RefreshGhostModelAppearance()`

Updates the ghost model to reflect the currently selected `placeAmount`. It activates or deactivates the bill stack GameObjects in the `bills` list to visually represent the value.

### Place
`protected override void Place()`

Overrides the base `Place` method. It creates a new `CashInstance` with the selected `placeAmount` and then calls `CreateStoredItem` on the `BuildManager` to place it in the world.

### PostPlace
`protected override void PostPlace()`

Called after placing the cash. It deducts the `placeAmount` from the player's cash balance via the `MoneyManager`.

### Stop
`public override void Stop()`

Overrides the base `Stop` method to destroy the `amountLabel` when the build process is cancelled.
