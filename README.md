# ONI-EasySteamTurbineMod
Mod for Oxygen not Included.
It looses Steam Turbine working requirements allowing it to be used without relying on quirks and bugs.

There are two must rules. Any tile below it (can be different tiles):
* has to have 3 kg of Steam;
* has temperature above 227 C.

I.e. Turbine will work by just being in a cloud of Steam, there's no need to move Steam around.

(If you have [MovableHeatMod](https://github.com/nicktime/ONI-MovableHeatMod) installed you can also dump excess heat into Turbine.)

![Steam Turbine](https://github.com/nicktime/ONI-EasySteamTurbineMod/raw/master/doc/SteamTurbine.png "Steam Turbine")

You can enable and disable the mod without any problem: all affected buildings (built/planned/etc) will change their properties as expected.

Installation
------------
* Install ModLoader https://github.com/javisar/ONI-Modloader/#installation
* Put [EasySteamTurbineMod.dll](https://github.com/nicktime/ONI-EasySteamTurbineMod/releases/latest) into `Mods` dir

Removing
--------
Just remove `EasySteamTurbineMod.dll` from `Mods` dir.

Building
--------
### Requirements
* .NET Framework 3.5
* Visual Studio 2017

### Guide
* Do the "Installation" part of https://github.com/javisar/ONI-Modloader
* Copy the following files from ONI's `OxygenNotIncluded_Data\Managed` folder to this mod's `\lib\`:
   * `Assembly-CSharp.dll`
   * `Assembly-CSharp-firstpass.dll`
   * `Assembly-UnityScript-firstpass.dll`
   * `UnityEngine.dll`
   * `UnityEngine.UI.dll`
* Build the solution (.dll will get copied to ONI `Mods` dir)
