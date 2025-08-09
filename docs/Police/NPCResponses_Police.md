# NPCResponses_Police

The `NPCResponses_Police` class defines the responses of a police officer to various events. It inherits from the `NPCResponses` class.

## Methods

### `HitByCar(LandVehicle vehicle)`

Called when the police officer is hit by a car.

**Parameters:**

* `vehicle`: The vehicle that hit the police officer.

### `NoticedDrugDeal(Player player)`

Called when the police officer notices a drug deal.

**Parameters:**

* `player`: The player who was involved in the drug deal.

### `NoticedPettyCrime(Player player)`

Called when the police officer notices a petty crime.

**Parameters:**

* `player`: The player who committed the petty crime.

### `NoticedVandalism(Player player)`

Called when the police officer notices vandalism.

**Parameters:**

* `player`: The player who committed the vandalism.

### `SawPickpocketing(Player player)`

Called when the police officer sees a player pickpocketing.

**Parameters:**

* `player`: The player who was pickpocketing.

### `NoticePlayerBrandishingWeapon(Player player)`

Called when the police officer notices a player brandishing a weapon.

**Parameters:**

* `player`: The player who is brandishing the weapon.

### `NoticePlayerDischargingWeapon(Player player)`

Called when the police officer notices a player discharging a weapon.

**Parameters:**

* `player`: The player who discharged the weapon.

### `NoticedWantedPlayer(Player player)`

Called when the police officer notices a wanted player.

**Parameters:**

* `player`: The wanted player.

### `NoticedSuspiciousPlayer(Player player)`

Called when the police officer notices a suspicious player.

**Parameters:**

* `player`: The suspicious player.

### `NoticedViolatingCurfew(Player player)`

Called when the police officer notices a player violating curfew.

**Parameters:**

* `player`: The player who is violating curfew.

### `RespondToAimedAt(Player player)`

Called when a player aims at the police officer.

**Parameters:**

* `player`: The player who is aiming at the police officer.

### `ImpactReceived(Impact impact)`

Called when the police officer receives an impact.

**Parameters:**

* `impact`: The impact that the police officer received.

### `GunshotHeard(NoiseEvent gunshotSound)`

Called when the police officer hears a gunshot.

**Parameters:**

* `gunshotSound`: The gunshot sound event.
