# PenaltyHandler

A static class for processing a list of crimes and calculating the resulting penalties.

## Description

This class contains the logic for determining the fines and other consequences for crimes a player has committed. It holds constant values for various fines and has a central method to process a dictionary of crimes.

## Constants

The class defines `public const float` values for various fines, such as:
-   `CONTROLLED_SUBSTANCE_FINE`
-   `LOW_SEVERITY_DRUG_FINE`
-   `FAILURE_TO_COMPLY_FINE`
-   `ASSAULT_FINE`
-   ...and many others.

## Methods

### ProcessCrimeList
`public static List<string> ProcessCrimeList(Dictionary<Crime, int> crimes)`

This is the main method of the class. It takes a dictionary where the key is a `Crime` object and the value is the number of times that crime was committed. It calculates the total fine and generates a list of strings describing the penalties.

**Logic:**
1.  It iterates through the list of crimes.
2.  Using a series of `if/else if` checks based on the crime type, it adds the appropriate fine amount to a running total (`num`).
3.  For possession crimes, the fine is multiplied by the quantity of the item. It also adds a specific message to the output list (e.g., "5 controlled substances confiscated").
4.  After calculating the total fine, it checks the player's cash balance.
5.  It deducts the fine from the player's balance, up to the amount they can afford.
6.  It adds a final string to the output list summarizing the total fine and how much of it was paid.

-   **Parameters:**
    -   `crimes`: A dictionary mapping each `Crime` committed to the number of offenses.
-   **Returns:** A `List<string>` containing a human-readable summary of all penalties applied.
