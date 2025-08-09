# MessageChain

The `MessageChain` class is a simple data container that holds a list of messages.

## Public Properties

| Property | Type           | Description                                      |
| -------- | -------------- | ------------------------------------------------ |
| `Messages` | `List<string>` | A list of the messages in the chain.             |
| `id`     | `int`          | The ID of the message chain.                     |

## Public Methods

| Method                        | Return Type    | Description                                      |
| ----------------------------- | -------------- | ------------------------------------------------ |
| `Combine(MessageChain a, MessageChain b)` | `MessageChain` | Combines two message chains into a new one.      |
