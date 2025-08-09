# MessagingManager

The `MessagingManager` class is a singleton that manages all messaging in the game. It is a `NetworkSingleton`.

## Methods

### `GetConversation(NPC npc)`

Gets the conversation for a given NPC.

**Parameters:**

* `npc`: The NPC to get the conversation for.

**Returns:** `MSGConversation`

### `Register(NPC npc, MSGConversation convs)`

Registers a conversation with the messaging manager.

**Parameters:**

* `npc`: The NPC to register the conversation for.
* `convs`: The conversation to register.

### `SendMessage(Message m, bool notify, string npcID)`

Sends a message.

**Parameters:**

* `m`: The message to send.
* `notify`: If `true`, a notification will be shown for the message.
* `npcID`: The ID of the NPC to send the message to.

### `SendMessageChain(MessageChain m, string npcID, float initialDelay, bool notify)`

Sends a message chain.

**Parameters:**

* `m`: The message chain to send.
* `npcID`: The ID of the NPC to send the message chain to.
* `initialDelay`: The initial delay before sending the message chain.
* `notify`: If `true`, a notification will be shown for the message chain.

### `SendResponse(int responseIndex, string npcID)`

Sends a response.

**Parameters:**

* `responseIndex`: The index of the response to send.
* `npcID`: The ID of the NPC to send the response to.

### `SendPlayerMessage(int sendableIndex, int sentIndex, string npcID)`

Sends a player message.

**Parameters:**

* `sendableIndex`: The index of the sendable message.
* `sentIndex`: The index of the sent message.
* `npcID`: The ID of the NPC to send the message to.

### `ClearResponses(string npcID)`

Clears the responses for a given NPC.

**Parameters:**

* `npcID`: The ID of the NPC to clear the responses for.

### `ShowResponses(string npcID, List<Response> responses, float delay)`

Shows a list of responses for a given NPC.

**Parameters:**

* `npcID`: The ID of the NPC to show the responses for.
* `responses`: The list of responses to show.
* `delay`: The delay before showing the responses.
