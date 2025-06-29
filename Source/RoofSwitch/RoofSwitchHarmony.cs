using HarmonyLib;
using RimWorld;
using Verse;

namespace RimRoofSwitch
{
    [HarmonyPatch(typeof(CompFlickable), "DoFlick")]
    public static class RoofSwitch_FlickPatch
    {
        public static void Postfix(CompFlickable __instance)
        {
            CompRoofSwitch comp = __instance.parent.GetComp<CompRoofSwitch>();
            comp?.UpdateRoof();
        }
    }

    [HarmonyPatch(typeof(CompPowerTrader), "set_PowerOn")]
    public static class RoofSwitch_PowerPatch
    {
        public static void Postfix(CompPowerTrader __instance)
        {
            CompRoofSwitch comp = __instance.parent.GetComp<CompRoofSwitch>();
            comp?.UpdateRoof();
        }
    }
}
