using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Historial
    {
        public int Id { get; set; }
        public string Operacion { get; set; }
        public string Resultado { get; set; }
        public DateTime Fecha { get; set; }
    }
}