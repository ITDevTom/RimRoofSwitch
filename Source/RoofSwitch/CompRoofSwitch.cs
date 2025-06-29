using Verse;
using RimWorld;

namespace RimRoofSwitch
{
    public class CompRoofSwitch : ThingComp
    {
        private CompPowerTrader powerComp;
        private CompFlickable flickComp;
        private bool lastOn;

        public override void PostSpawnSetup(bool respawningAfterLoad)
        {
            base.PostSpawnSetup(respawningAfterLoad);
            powerComp = parent.GetComp<CompPowerTrader>();
            flickComp = parent.GetComp<CompFlickable>();
            lastOn = IsOn;
            UpdateRoof();
        }

        private bool IsOn => (flickComp == null || flickComp.SwitchIsOn) &&
                             (powerComp == null || powerComp.PowerOn);

        public void UpdateRoof()
        {
            Room room = parent.GetRoom();
            if (room != null)
            {
                RoofSwitcher.ToggleRoof(room, !IsOn);
            }
        }
    }

    public class CompProperties_RoofSwitch : CompProperties
    {
        public CompProperties_RoofSwitch()
        {
            compClass = typeof(CompRoofSwitch);
        }
    }
}
