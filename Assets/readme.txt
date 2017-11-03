Version 1.3
Removed the third-person controller prefabs and scripts. The were unused and causing script compiler warnings.

Version 1.2
Added #pragma strict to Maze.js and Options.js
Removed old Unity standard assets skyboxes to avoid import warnings about the pathnames.
Modified the SetMaterial function in Maze.js to iterate through each tile and set its material instead of just setting the prefab tile material (that technique apparently only works the first time it's called, now)

Version 1.1
Updated to Unity 3.5.1. 
Converted first person controller to new Unity Character Controller asset.
Removed pause menu movie code to avoid confusion for Unity Indie users.
Updated the QualitySettings code in the pause menu.
Updated the skybox materials from the Unity Skybox assets.
Added a light flare visible from the maze exit.

Version 1.0
First version

Fugu Maze started out as an exercise in implementing a maze-generation algorithm I found on the Maze Generation article in Wikipedia but turned out to be moderately popular as a Mac widget and iOS/Android  app (note this project does not include the code specific to the mobile verions). It's also available on several Unity game portals.

All scripts are in Javascript. The maze generation takes place in Maze.js, which is attached to the Maze game object. (The script is also on the Unify Community wiki) The script constructs a grid of cells, each one a "Room" with four walls, floor and ceiling, and uses a prefab textured plane for each of those, then selectively removes walls until there is a path from any one room to another. The "size" property is set to 5 for a 5x5 (five rooms by five rooms) maze and can be adjusted, but of course larger mazes have greater performance (mostly rendering) requirements.

Once the maze walls are instantiated, a first-person controller (the one provided by Unity in is activated. This is the standard first person controller provided in the Unity Character Controller assets. In this project, the controller has a DetectFall.js script added which, when it detects the player has fallen, scrambles the maze by first making all the cell walls active and then selectively deactivating walls (in a recursive fashion - see the wikipedia article) until there is a single path to the exit (and the exit is randomly chosen, at which location that wall is removed, too). Then the player is placed in a random starting point within the maze. When the player reaches the exit, steps out and falls, the cycle repeats.

The first person controller generates footstep sounds using the attached Foosteps.js script and set of sounds from the Unity Technologies island demo. The controller also has a spotlight (attached to the camera so it always points where you're looking) which acts as a flashlight. The Flashlight.js script on the flashlight checks for mouse clicks to toggle the light on/off.

An object with a light flare component provides a lens flare effect when you find the exit. Some fog is also set in the Render Settings.

When the maze is regenerated, a random material (loaded from the Resources folder) is applied. Since the same prefab tile is used for each wall, it suffices to set the shared material of that prefab. The textures used in the materials are taken from various Unity Technologies demos. You can add new materials by placing them in the Resources/Materials directory. For example, in my own version of Fugu Maze I've added the materials from the Artskillz Free Texture Pack on the Asset Store.

The camera also has a pause menu script (a version of the script is on the Unity Community wiki). A custom UnityGUI skin can be assigned. Try it out with the free Necromancer GUI from the Asset Store, it looks great!

Direct any questions to the Fugu Games Facebook page - http://facebook.com/fugugames -  or the Unity forum, http://forum.unity3d.com/threads/80912-Fugu-Games-on-the-Asset-Store


