using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformacionDocumentos
{
    public class InformacionDocumento : Usuario
    {
        public int id { get; set; }
        public string NombreDoc { get; set; }
        public string TipoDoc { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
