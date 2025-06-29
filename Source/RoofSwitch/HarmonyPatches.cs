using HarmonyLib;
using Verse;

namespace RimRoofSwitch
{
    [StaticConstructorOnStartup]
    public static class HarmonyPatches
    {
        static HarmonyPatches()
        {
            var harmony = new Harmony("com.tom.roofswitch");
            harmony.PatchAll();
        }
    }
}
