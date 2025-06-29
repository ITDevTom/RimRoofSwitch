using RimWorld;
using Verse;

namespace RimRoofSwitch
{
    public static class RoofSwitcher
    {
        public static void ToggleRoof(Room room, bool open)
        {
            foreach (IntVec3 cell in room.Cells)
            {
                if (open)
                {
                    cell.GetRoofHolder().roofDef = null;
                }
                else
                {
                    // Add code to restore roof if desired
                }
            }
        }
    }
}
