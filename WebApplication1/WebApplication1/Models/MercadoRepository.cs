using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class MercadoRepository
    {
        private MySqlConnection conect()
        {
            String connString = "Server = 127.0.0.1; Port = 3306; Database = placemybet; Uid = root; password =; SslMode = none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;

        }
        internal Mercado Retrieve()
        {
            MySqlConnection con = conect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from Mercado";

            con.Open();
            MySqlDataReader res = command.ExecuteReader();

          Mercado m = null;

            if (res.Read())
            {
                Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetInt32(1) + " " + res.GetInt32(2) + " " + res.GetInt32(3)+ " " +  res.GetInt32(4) + " " + res.GetInt32(5));
                m = new Mercado(res.GetInt32(0), res.GetInt32(1), res.GetInt32(2), res.GetInt32(3), res.GetInt32(4), res.GetInt32(5));

            }




            return m;
        }
    }
}