# Offense

The `Offense` class represents a criminal offense. It contains a list of charges and penalties.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `charges` | `List<Charge>` | A list of charges for the offense. |
| `penalties` | `List<string>` | A list of penalties for the offense. |

## Constructors

### `Offense(List<Charge> _charges)`

Initializes a new instance of the `Offense` class.

**Parameters:**

* `_charges`: A list of charges for the offense.

---

# Charge

The `Charge` class represents a single charge in an offense.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `chargeName` | `string` | The name of the charge. |
| `crimeIndex` | `int` | The index of the crime. |
| `quantity` | `int` | The quantity of the crime. |

## Constructors

### `Charge(string _chargeName, int _crimeIndex, int _quantity)`

Initializes a new instance of the `Charge` class.

**Parameters:**

* `_chargeName`: The name of the charge.
* `_crimeIndex`: The index of the crime.
* `_quantity`: The quantity of the crime.
