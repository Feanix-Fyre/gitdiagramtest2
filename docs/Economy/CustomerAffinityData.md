# CustomerAffinityData

The `CustomerAffinityData` class represents a customer's affinity for different types of drugs.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `ProductAffinities` | `List<ProductTypeAffinity>` | A list of the customer's product affinities. |

## Methods

### `CopyTo(CustomerAffinityData data)`

Copies the customer's affinity data to another `CustomerAffinityData` object.

**Parameters:**

* `data`: The `CustomerAffinityData` object to copy to.

### `GetAffinity(EDrugType type)`

Gets the customer's affinity for a certain type of drug.

**Parameters:**

* `type`: The type of drug to get the affinity for.

**Returns:** `float`
