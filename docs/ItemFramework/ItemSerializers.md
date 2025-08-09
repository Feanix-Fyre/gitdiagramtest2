# ItemSerializers

A static class containing extension methods for serializing and deserializing `ItemInstance` objects and their derived types for FishNet networking.

## Description

This class is crucial for network communication involving items. Because `ItemInstance` is an abstract base class, a simple serializer would not know which specific derived type (e.g., `CashInstance`, `ClothingInstance`) to create upon reading the data.

This class solves that problem by implementing a custom serialization pattern:
1.  **Writing**: When an `ItemInstance` is written to the network stream, the appropriate `Write...` method (e.g., `WriteCashInstance`) is called. This method first writes a `string` containing the name of the specific class (`"CashInstance"`) and then writes the actual data for that class.
2.  **Reading**: The generic `ReadItemInstance` method is called. It first reads the class name string. Based on that string, it calls the correct `DirectRead...` method (e.g., `DirectReadCashInstance`) to read the rest of the data and construct the correct derived class.

This pattern allows the system to handle a variety of item types over the network in a unified way.

## Core Methods

### WriteItemInstance (and derived versions)
`public static void WriteItemInstance(this Writer writer, ItemInstance value)`

The main entry point for writing an item. It checks the actual type of the `value` and dispatches it to the more specific writer (e.g., `WriteStorableItemInstance`, `WriteQualityItemInstance`). Each specific writer follows the pattern of writing the type name first, followed by the object's data.

### ReadItemInstance
`public static ItemInstance ReadItemInstance(this Reader reader)`

The main entry point for reading an item. It calls the private `Read` method.

### Read (private)
`private static ItemInstance Read(this Reader reader)`

The core of the deserialization logic. It reads the type name string from the stream and uses a series of `if` statements to call the correct `DirectRead...` method to deserialize the rest of the data and instantiate the correct object type.
