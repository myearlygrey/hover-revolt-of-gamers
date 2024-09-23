# hover-revolt-of-gamers
Assignment 2

Group 6 Program 2 Submission
Group Members: Atticus Birkett, Langston Campbell, Andrew Cota, Carlo Scarpa
College of Information Sciences, University of Arizona
September 22, 2024

Implementation:

Driving a Hovercraft
Players can control the movement of the hovercraft using keyboard keys:
W: Accelerate forward
S: Decelerate or reverse
A: Turn left
D: Turn right
The hovercraft travels naturally over the terrain by sampling the height of the ground and tilting accordingly to match the terrain's surface. Collision is avoided by ensuring the vehicle never moves through the ground.
A third-person follow camera is implemented, which dynamically adjusts its position and tilt relative to the hovercraft.

Three Car Types
The game features three distinct types of hovercraft with unique speed and cornering abilities:
Type 1 - Average: Balanced speed and cornering.
Type 2 - Fast: Higher speed but slower cornering.
Type 3 - Agile: Better cornering but reduced speed.
The speed and cornering rate for each hovercraft type are configurable in the Unity Inspector.

Hovercraft Levitation
Hovercraft hover slightly above the ground, simulating the effect of futuristic levitation technology.

Toggling Between Hovercraft
The player can cycle between the three hovercraft using the C key.
When switching between vehicles, the camera adjusts to focus on the currently active hovercraft.

Additional Choice Feature (Extra Credit)
More Realistic Effects (Partially Implemented)
Engine Sounds: The hovercraft engines have audio feedback that adjusts in pitch and volume based on the vehicle’s speed and acceleration.

Assets Used:

- FREE LOWPOLY - Spaceship by IV Art
- FREE Low-Poly Spaceships Set by Zckr
- FREE Simple Retro Car by Polyeler
- oscillating space waves by Pixabay

Freeware media assets were used from the following sources:
- https://assetstore.unity.com/
- https://pixabay.com/sound-effects/oscillating-space-waves-31400/

Made using Unity's Built-In Render Pipeline.

Credits: 

- Atticus Birkett: Customized Type 3 the best cornering car, helped aesthetics for turning car, car switching script, Pitch modulation script.

- Langston Campbell: Setup main scene, helped with movement script, help implement car switching script.

- Andrew Cota: Customized Type 2 the fast car, helped implement pitch modulation script.

- Carlo Scarpa: Customized Type 1 is the amazingly average car, helped with movement script.
