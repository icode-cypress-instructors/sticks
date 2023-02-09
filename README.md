# Sticks game

Sticks is a 2-player mathematical strategy game.
It is played with a pile/heap of sticks, where players take turns removing sticks from the pile.
The player to take the last stick from the pile loses.
Each player must take at least one and at most *t* sticks.
A game of Sticks is parametric over the number of initial sticks in the pile and the maximum number of sticks a player
may take on their turn (called `maxTake`).

For demonstration and testing purposes, use a pile of 21 sticks and a `maxTake` rule of 3.
That is, a player can take 1, 2, or 3 sticks on their turn.

## Motivation

The game serves as a good introduction to programming concepts such as interfaces[^IPlayer], inheritance[^Bot],
and polymorphism *(see use of concrete player types as `IPlayer` in [SticksGame](Sticks/SticksGame.cs))*.
Students will use their knowledge of class structure to implement their own custom types with fields, constants,
properties, constructors, and methods.
This also offers reinforcement material for loops, conditional statements, and user interaction via the `Console` class.

The following topics are likely to be new material for students:

- Top-down design
- Creating non-static classes
- Interfaces
- Abstract classes, methods, and the `override` keyword
- Property usage
- Domain boundaries, e.g. validating a player's move in the `SticksGame` class instead of each `IPlayer` implementation
- Polymorphism

[^IPlayer]: Sticks/Players/IPlayer.cs

[^Bot]: Sticks/Players/Bot.cs

## Teaching

1. Before coding the program, explain and demonstrate the game with sticks.
2. Explain top-down vs bottom-up design.
3. Have students create `SticksRunner` as the program entrypoint, and finish the body of `SticksRunner.Main` without
   implementing its dependencies.
4. Use the IDE code generation tools (found under "quick fix" or a context menu) to generate the classes and methods
   used inside `SticksRunner.Main`.
	- When implementing the static method `SticksGame.Prompt`, point out that we know it should be static because
	  in `Main` it's called on the class, not an instance.

[//]: # (TODO: complete teaching notes)

`Sticks/Architecture.puml` is a PlantUML diagram source describes the architecture of the project.

## Requirements

1. Create the program entrypoint `SticksRunner.Main()`.
	1. Interactively ask the player for the rules of their game using `SticksGame.Prompt(string prompt)`.
	2. Instantiate a `SticksGame` with those rules using the `SticksGame(int initialSticks, int maxTake)` constructor.
	3. Run the game using the `Run()` method on the `SticksGame` instance.
2. Create fields in `SticksGame`:
	1. The class must have a public constant `MinTake` that equals `1`.
	2. Use the constructor to initialize private fields `readonly int _maxTake` and `int _sticks`.

[//]: # (TODO: complete requirements)

[//]: # (TODO: extract player instantiation into SticksRunner)

[//]: # (TODO: implement runtime selecion of players)
