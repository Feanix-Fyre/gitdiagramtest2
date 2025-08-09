# PlayingCard

Inherits from `MonoBehaviour`.

## Description

This class represents a single playing card. It manages the card's visual appearance (suit and value), its physical state in the world (position, rotation, face-up/face-down), and communicates changes to a `CardController` for network synchronization.

## Inner Classes & Structs

### CardSprite (Serializable Class)
Links a suit and value to a specific `Sprite`.
-   **Suit**: `ECardSuit`
-   **Value**: `ECardValue`
-   **Sprite**: `Sprite`

### CardData (Struct)
A simple data structure to hold the suit and value of a card.
-   **Suit**: `ECardSuit`
-   **Value**: `ECardValue`

## Enums

### ECardSuit
`Spades`, `Hearts`, `Diamonds`, `Clubs`

### ECardValue
`Blank`, `Ace`, `Two`, `Three`, `Four`, `Five`, `Six`, `Seven`, `Eight`, `Nine`, `Ten`, `Jack`, `Queen`, `King`

## Fields

-   **CardID**: `string` - A unique identifier for this card instance (e.g., "card_1").
-   **CardSpriteRenderer**: `SpriteRenderer` - The renderer that displays the card's face.
-   **CardSprites**: `CardSprite[]` - An array mapping all possible suit/value combinations to their sprites.
-   **FlipAnimation**: `Animation` - The `Animation` component used for flipping the card.
-   **FlipSound**: `AudioSourceController` - The sound played when the card is flipped.
-   **LandSound**: `AudioSourceController` - The sound played when the card lands after moving.

## Properties

-   **IsFaceUp**: `bool` (read-only) - Is the card currently face-up?
-   **Suit**: `ECardSuit` (read-only) - The current suit of the card.
-   **Value**: `ECardValue` (read-only) - The current value of the card.
-   **CardController**: `CardController` (read-only) - A reference to the parent controller for networking.

## Methods

### SetCard
`public void SetCard(ECardSuit suit, ECardValue value, bool network = true)`

Sets the suit and value of the card, updating its sprite. If `network` is true, it sends this change to the `CardController` to be broadcast to other clients.

-   **Parameters:**
    -   `suit`: The new suit.
    -   `value`: The new value.
    -   `network`: Whether to synchronize this change over the network.

### SetFaceUp
`public void SetFaceUp(bool faceUp, bool network = true)`

Sets the card to be face-up or face-down, playing a flipping animation and sound. If `network` is true, it synchronizes the state.

-   **Parameters:**
    -   `faceUp`: True to make the card face-up, false for face-down.
    -   `network`: Whether to synchronize this change over the network.

### GlideTo
`public void GlideTo(Vector3 position, Quaternion rotation, float duration = 0.5f, bool network = true)`

Moves the card smoothly to a target position and rotation over a given duration. The movement includes a slight arc. If `network` is true, it synchronizes the movement.

-   **Parameters:**
    -   `position`: The target world position.
    -   `rotation`: The target world rotation.
    -   `duration`: The time the movement should take.
    -   `network`: Whether to synchronize this change over the network.
