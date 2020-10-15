using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Apuesta
    {
            public Apuesta(int id, DateTime fecha, int cuota, string tipoApuesta)
            {
                Id = id;
                Fecha = fecha;
                Cuota = cuota;
                TipoApuesta = tipoApuesta;
            }

            public int Id { get; set; }
            public DateTime Fecha { get; set; }
            public int Cuota { get; set; }
            public string TipoApuesta { get; set; }

        
    }
}