using System;
using GTANetworkAPI;

namespace freemode
{
    internal class Events : Script
    {
        [ServerEvent(Event.PlayerConnected)]
        private void OnPlayerConnected(Player player)
        {
            player.SendChatMessage("~g~Вас приветствует сервер ~r~Шизофрения!!!");
        }

        [ServerEvent(Event.PlayerSpawn)]
        private void OmPlayerSpawn(Player player)
        {
            player.Health = 100;
            player.Armor = 100;
            player.GiveWeapon(WeaponHash.Minismg, 300);
            player.GiveWeapon(WeaponHash.Rpg, 24);
        }
    }
}
