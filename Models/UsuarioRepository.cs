using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UsuarioRepository
    {
        private MySqlConnection conect()
        {
            String connString = "";
            MySqlConnection con = MySqlConnection(connString);
            return con;

        }
        internal Usuario Retrieve()
        {
            MySqlConnection con = conect();
            MySqlCommand command = con.CreateCommand();
            command.commandText = "select * from Usuario";

            con.Open();
            MysqlDataReader res= command.ExecuteReader();

            Usuario u =  null;

            if(res.read())
            {
                Debug.writeLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) +" " + res.GetString(2) +" " + res.GetString(3));
                u = new Usuario(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetString(3));
            
            }


          

            return u;
    }
}