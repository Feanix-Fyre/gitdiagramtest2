# CardController

The `CardController` class is a network behaviour that controls the cards in a casino game.

## Methods

### `SendCardValue(string cardId, PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)`

Sends the value of a card to all clients.

**Parameters:**

* `cardId`: The ID of the card.
* `suit`: The suit of the card.
* `value`: The value of the card.

### `SendCardFaceUp(string cardId, bool faceUp)`

Sends whether a card is face up to all clients.

**Parameters:**

* `cardId`: The ID of the card.
* `faceUp`: If `true`, the card is face up.

### `SendCardGlide(string cardId, Vector3 position, Quaternion rotation, float glideTime)`

Sends a card glide to all clients.

**Parameters:**

* `cardId`: The ID of the card.
* `position`: The position to glide to.
* `rotation`: The rotation to glide to.
* `glideTime`: The time it takes to glide.
