using System;
using GTANetworkAPI;

namespace freemode
{
    class Commands : Script
    {
        [Command("veh", "veh спавн т.с.", Alias = "vihicle")]
        private void cmd_veh(Player player, string vehname, int color1, int color2)
        {
            uint vhash = NAPI.Util.GetHashKey(vehname);
            Vehicle veh = NAPI.Vehicle.CreateVehicle(vhash, player.Position, player.Heading, color1, color2);
            veh.NumberPlate = "DarkSin";
            veh.Locked = false;
            veh.EngineStatus = true;
        }
    }
}
// [eq oled display