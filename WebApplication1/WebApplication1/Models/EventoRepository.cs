using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EventoRepository
    {
        private MySqlConnection conect()
        {
            String connString = "";
            MySqlConnection con = MySqlConnection(connString);
            return con;

        }
        internal Eventos Retrieve()
        {
            MySqlConnection con = conect();
            MySqlCommand command = con.CreateCommand();
            command.commandText = "select * from Evento";

            con.Open();
            MysqlDataReader res = command.ExecuteReader();

            Eventos e = null;

            if (res.read())
            {
                Debug.writeLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetInt(3) + " " + res.GetInt(4));
                e = new Eventos(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetInt(3), res.GetInt(4));

            }




            return e;
        }
    }
}