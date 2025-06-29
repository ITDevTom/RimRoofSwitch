# Roof Switch Mod for RimWorld

A simple mod to toggle roofs using a powered switch.

## Requirements

* [Harmony](https://github.com/pardeike/Harmony)
* RimWorld 1.5 or 1.6

## Building

1. Copy the RimWorld assemblies (`Assembly-CSharp.dll`, `UnityEngine.dll`, `Verse.dll` and `0Harmony.dll`) into a folder called `RimWorld` inside the `Source` directory.
2. Run `dotnet build -c Release` from the `Source` folder.
3. Copy the resulting `RimRoofSwitch.dll` from `bin/Release/net472/` to an `Assemblies` folder in the mod root.

## Installing the Mod

Place the entire `RimRoofSwitch` folder into your RimWorld `Mods` directory. Enable **Roof Switch** in the mod menu.

## Using the Roof Switch

After enabling the mod, a *roof switch* building appears in the *Misc* tab of the architect menu. Build it in a room and connect power. Toggling the switch will remove or restore the roof above the attached room.
