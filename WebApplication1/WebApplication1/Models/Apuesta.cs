using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Apuesta
    {
            public Apuesta(int id, int fecha, int cuota, int tipoApuesta)
            {
                Id = id;
                Fecha = fecha;
                Cuota = cuota;
                TipoApuesta = tipoApuesta;
            }

            public int Id { get; set; }
            public int Fecha { get; set; }
            public int Cuota { get; set; }
            public int TipoApuesta { get; set; }

        
    }
}