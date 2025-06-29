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
                    room.Map.roofGrid.SetRoof(cell, null);
                }
                else
                {
                    // Add code to restore roof if desired
                }
            }
        }
    }
}
