using System;
using GTANetworkAPI;

namespace freemode
{
    internal class Events : Script
    {
        [ServerEvent(Event.PlayerConnected)]
        private void PlayerConnected(Player player)
        {
            player.SendChatMessage("~g~Вас приветствует сервер ~r~Шизофрения!!!");
        }

        [ServerEvent(Event.PlayerSpawn)]
        private void PlayerSpawn(Player player)
        {
            player.Health = 100;
            player.Armor = 100;
            player.GiveWeapon(WeaponHash.Pistol, 100);
        }
    }
}
