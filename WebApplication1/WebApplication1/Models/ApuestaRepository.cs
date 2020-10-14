using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ApuestaRepository
    {
        private MySqlConnection conect()
        {
            String connString = "";
            MySqlConnection con = MySqlConnection(connString);
            return con;

        }
        internal Apuesta Retrieve()
        {
            MySqlConnection con = conect();
            MySqlCommand command = con.CreateCommand();
            command.commandText = "select * from Apuesta";

            con.Open();
            MysqlDataReader res = command.ExecuteReader();

            Apuesta a = null;

            if (res.read())
            {
                Debug.writeLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetString(3));
               a = new Apuesta(res.GetInt32(0), res.GetInt(1), res.GetInt(2), res.GetInt(3));

            }




            return a;
        }
    }
}