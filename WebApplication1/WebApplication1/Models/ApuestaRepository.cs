using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ApuestaRepository
    {
        private MySqlConnection conect()
        {
            String connString = "Server=127.0.0.1;Port=3306;Database=placemybet;Uid=root;password=;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;

        }
        internal Apuesta Retrieve()
        {
            MySqlConnection con = conect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from Apuesta";

            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            Apuesta a = null;

            if (res.Read())
            {
                Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetDateTime(1) + " " + res.GetInt32(2) + " " + res.GetString(3));
               a = new Apuesta(res.GetInt32(0), res.GetDateTime(1), res.GetInt32(2), res.GetString(3));

            }


            return a;
        }
    }
}