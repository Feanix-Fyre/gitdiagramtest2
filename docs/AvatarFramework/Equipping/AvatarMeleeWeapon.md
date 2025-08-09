# AvatarMeleeWeapon

Inherits from `AvatarWeapon`.

## Description

Represents a melee weapon that can be equipped by an avatar. It handles the logic for performing melee attacks, including playing animations, sounds, and dealing damage via raycasting.

## Inner Classes

### MeleeAttack
A serializable class that defines a single type of melee attack.
-   **RangeMultiplier**: `float` - Multiplier for the attack's range.
-   **DamageMultiplier**: `float` - Multiplier for the attack's damage.
-   **AnimationTrigger**: `string` - The animation trigger to play for this attack.
-   **DamageDelay**: `float` - The delay in seconds from the start of the attack until damage is applied.
-   **AttackSoundDelay**: `float` - The delay for playing the whoosh/swing sound.
-   **AttackClips**: `AudioClip[]` - Sounds for the weapon swinging.
-   **HitClips**: `AudioClip[]` - Sounds for when the weapon hits a target.

## Fields

-   **AttackSound**: `AudioSourceController` - The audio source for attack swing sounds.
-   **HitSound**: `AudioSourceController` - The audio source for impact sounds.
-   **AttackRange**: `float` - The base range of the melee attack.
-   **AttackRadius**: `float` - The radius of the attack (currently unused in the provided code, but likely intended for sphere-casting).
-   **Damage**: `float` - The base damage of the weapon.
-   **Attacks**: `MeleeAttack[]` - An array of possible melee attacks this weapon can perform.

## Methods

### Unequip
`public override void Unequip()`

Overrides the base `Unequip` method to stop any active attack coroutine before unequipping the weapon.

### Attack
`public override void Attack()`

Initiates a melee attack. It randomly selects an attack from the `Attacks` array, plays the corresponding animation and sounds, and starts a coroutine to handle the damage logic after a delay. Damage is applied to the first `Player` hit by a raycast forward from the avatar's center point.
