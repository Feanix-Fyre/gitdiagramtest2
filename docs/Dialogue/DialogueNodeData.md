# DialogueNodeData

The `DialogueNodeData` class is a serializable class that contains data for a dialogue node.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `Guid` | `string` | The GUID of the dialogue node. |
| `DialogueText` | `string` | The text of the dialogue node. |
| `DialogueNodeLabel` | `string` | The label of the dialogue node. |
| `Position` | `Vector2` | The position of the dialogue node in the dialogue editor. |
| `choices` | `DialogueChoiceData[]` | An array of choices for the dialogue node. |
| `VoiceLine` | `EVOLineType` | The voice line to play for the dialogue node. |

## Methods

### `GetCopy()`

Gets a copy of the dialogue node data.

**Returns:** `DialogueNodeData`
