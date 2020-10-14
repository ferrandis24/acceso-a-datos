using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Mercado
    {
        public Mercado(int id, int underOver, int cuotaUnder, int cuotaOver, int dineroOver, int dineroUnder)
        {
            Id = id;
            UnderOver = underOver;
            CuotaUnder = cuotaUnder;
            CuotaOver = cuotaOver;
            DineroOver = dineroOver;
            DineroUnder = dineroUnder;
        }

        public int Id { get; set; }
        public int UnderOver { get; set; }
        public int CuotaUnder { get; set; }
        public int CuotaOver { get; set; }
        public int DineroOver { get; set; }
        public int DineroUnder { get; set; }

    }
}