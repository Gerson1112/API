using NetCore6.Core.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore6.Bl.DTOs
{
    public class TurismoDTO : BaseEntityDto
    {
        public string Destino { get; set; }
        public string Foto { get; set; }
        public string Descripcion { get; set; }
        public string Region { get; set; }
    }
}
