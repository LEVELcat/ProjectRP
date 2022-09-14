using System;
using System.Collections.Generic;
using System.Text;
using GTANetworkAPI;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Security;

namespace freemode
{
    class mysql
    {
        private static MySqlConnection Connection;
        private String _host { get; set; }
        private String _user { get; set; }
        private String _pass { get; set; }
        private String _base { get; set; }

        private mysql()
        {
            this._host = "localhost";
            this._user = "root";
            this._pass = "";
            this._base = "ragempbd";
        }

        public static void InitConnection()
        {
            mysql sql = new mysql();
            String SQLconnection = $"SERVER={sql._host}; DATABASE={sql._base}; UID={sql._user}; PASSWORD={sql._pass}";
            Connection = new MySqlConnection(SQLconnection);

            try
            {
                Connection.Open();
                NAPI.Util.ConsoleOutput("~g~MYSQL подключен!");
            }
            catch (Exception ex)
            {
                NAPI.Util.ConsoleOutput("~r~!MYSQL НЕподключен!");
                NAPI.Util.ConsoleOutput("~r~Исключение: " + ex);
            }
        }
    }
}
