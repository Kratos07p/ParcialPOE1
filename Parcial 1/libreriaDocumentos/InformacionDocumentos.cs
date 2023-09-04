using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libreriaDocumentos
{
    public class InformacionDocumentos : Usuario
    {
        public int Id { get; set; }
        public string NombreDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
