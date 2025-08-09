# DialogueEvent

The `DialogueEvent` class is a serializable class that represents an event that can be triggered by a dialogue.

## Properties

| Name | Type | Description |
| --- | --- | --- |
| `Dialogue` | `DialogueContainer` | The dialogue that triggers the event. |
| `onDialogueEnded` | `UnityEvent` | The event that is triggered when the dialogue ends. |
| `NodeEvents` | `DialogueNodeEvent[]` | An array of events that are triggered when a dialogue node is displayed. |
