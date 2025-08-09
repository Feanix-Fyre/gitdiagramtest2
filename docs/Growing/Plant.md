# Plant

Inherits from `MonoBehaviour`.

## Description

This is a base class for all growable plants. It manages the plant's entire lifecycle, from initialization to growth over time, and finally to being harvested or destroyed.

## Key Fields & Properties

-   **GrowthStages**: `PlantGrowthStage[]` - An array of `PlantGrowthStage` objects, each representing a visual stage of the plant's growth.
-   **SeedDefinition**: `SeedDefinition` - The ScriptableObject that defines this type of plant.
-   **GrowthTime**: `int` - The total time in in-game hours for the plant to fully grow.
-   **BaseYieldLevel / BaseQualityLevel**: `float` - The base values for yield and quality, which can be modified by additives.
-   **YieldLevel / QualityLevel**: `float` - The current yield and quality levels for this specific plant instance.
-   **Pot**: `Pot` (read-only) - A reference to the `Pot` this plant is growing in.
-   **NormalizedGrowthProgress**: `float` (read-only) - The current growth progress, from 0.0 (just planted) to 1.0 (fully grown).
-   **IsFullyGrown**: `bool` (read-only) - True if `NormalizedGrowthProgress` is 1.0 or greater.

## Core Logic

-   **Initialization**: The `Initialize` method is called when the plant is first created (sown in a pot). It sets the initial growth progress, yield, and quality levels.
-   **Growth (`MinPass`)**: The `MinPass` method is called by the parent `Pot` every in-game minute. It calculates a "growth tick" value based on several factors:
    -   The base `GrowthTime`.
    -   Multipliers from any `Additive`s in the pot.
    -   The average light exposure of the pot.
    -   The pot's own `GrowSpeedMultiplier`.
    -   Whether the pot has water.
    -   It adds this value to `NormalizedGrowthProgress`.
-   **Visuals (`UpdateVisuals`)**: When `NormalizedGrowthProgress` changes, this method is called. It activates the appropriate `PlantGrowthStage` GameObject based on the current progress to update the plant's visual appearance.
-   **Growth Completion (`GrowthDone`)**: When `NormalizedGrowthProgress` reaches 1.0, this method is called.
    -   On the server, it calculates how many "harvestable" sites on the plant should become active based on the `YieldLevel`.
    -   It then sends an RPC to synchronize which harvestable sites are active on all clients.
    -   It plays a particle effect and invokes the `onGrowthDone` event.

## Public Methods

### Initialize
`public virtual void Initialize(NetworkObject pot, float growthProgress = 0f, float yieldLevel = 0f, float qualityLevel = 0f)`

Sets up the plant in a given pot with initial values.

### Destroy
`public virtual void Destroy(bool dropScraps = false)`

Destroys the plant's GameObject and optionally spawns a `PlantScrapPrefab` as trash.

### SetNormalizedGrowthProgress
`public virtual void SetNormalizedGrowthProgress(float progress)`

Sets the growth progress to a specific value and updates the visuals.

### SetHarvestableActive
`public virtual void SetHarvestableActive(int index, bool active)`

Activates or deactivates a specific harvestable point on the fully grown plant model.

### GetHarvestedProduct
`public virtual ItemInstance GetHarvestedProduct(int quantity = 1)`

A virtual method intended to be overridden by derived classes (e.g., `WeedPlant`, `CocaPlant`) to define what `ItemInstance` is created when the plant is harvested.

### GetPlantData
`public PlantData GetPlantData()`

Creates and returns a `PlantData` object containing the current state of the plant for saving.
