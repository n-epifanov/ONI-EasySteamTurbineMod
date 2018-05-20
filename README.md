# ONI-ExampleMod
Sample Visual Studio solution to help you started with a new mod for Oxygen not Included.

Requirements
------------
* .NET Framework 3.5
* Visual Studio 2017

Getting started
---------------
* Do the "Installation" part of https://github.com/javisar/ONI-Modloader
* Copy the following files from ONI's `OxygenNotIncluded_Data\Managed` folder to this mod's `\lib\`:
   * `Assembly-CSharp.dll`
   * `Assembly-CSharp-firstpass.dll`
   * `Assembly-UnityScript-firstpass.dll`
   * `UnityEngine.dll`
   * `UnityEngine.UI.dll`
* Open solution in Visual Studio
* Open project's `Properties` and rename `Assembly name` and `Default Namespace`
* Build (.dll will get copied to ONI `Mods` dir);
* Run the game.
