# BattleShips

Write a method that takes a Battleship field (10*10 two-dimensional array, elements can be either 0 for water or 1 if there is a ship) and validates that it is a valid field.


Rules:
1. There has to be: 1 battleship (4 cells), 2 cruisers (3 cells), 3 destroyers (2 cells), 4 submarines (1 cell)
2. There may not be missing ships
3. There may not be extra ships
4. Ships may not be placed diagonally
5. Ships may not overlap

Lastly an optional rule that decides what tests to fix:
6. Ships may not be adjecent (corners nor edges) 

When taking rule 6 into account fix FieldValidatorTests
Otherwise fix FieldValidator2Tests

