using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class cls_Empleados
    { 
        #region VARIABLES PUBLICAS
        public int iCedula { get; set; }
        public string sNombreCompleto{ get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Lateralidad { get; set; }
        public DateTime FechaIngreso { get; set; }
        public float SalarioHora { get; set; }
        #endregion
    }
}
