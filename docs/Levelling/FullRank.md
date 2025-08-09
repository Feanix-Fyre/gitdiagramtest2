# FullRank

The `FullRank` struct represents a player's full rank, which consists of a rank and a tier.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `Rank` | `ERank` | The player's rank. |
| `Tier` | `int` | The player's tier. |

## Constructors

### `FullRank(ERank rank, int tier)`

Initializes a new instance of the `FullRank` struct.

**Parameters:**

* `rank`: The player's rank.
* `tier`: The player's tier.

## Methods

### `ToString()`

Returns a string representation of the full rank.

**Returns:** `string`

### `NextRank()`

Gets the next full rank.

**Returns:** `FullRank`

### `GetString(FullRank rank)`

Gets a string representation of a full rank.

**Parameters:**

* `rank`: The full rank to get a string representation of.

**Returns:** `string`

### `CompareTo(FullRank other)`

Compares the full rank to another full rank.

**Parameters:**

* `other`: The other full rank to compare to.

**Returns:** `int`
