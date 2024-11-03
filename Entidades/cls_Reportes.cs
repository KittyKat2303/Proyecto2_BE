using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class cls_Reportes
    {
        #region VARIABLES PUBLICAS
        public int IdReportes { get; set; }
        public int identificacion { get; set; }
        public int IdMantenimiento { get; set; }
        public DateTime fechaAgentado { get; set; }
        public DateTime siguienteChapia { get; set; }
        public cls_Reportes()
        {
            IdReportes = 0;
            identificacion = 0;
            fechaAgentado = DateTime.MinValue;
            siguienteChapia = DateTime.MinValue;
        }
        #endregion
    }
}
