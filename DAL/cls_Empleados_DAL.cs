using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Empleados_DAL
    {
        #region VARIABLE PRIVADA   
        private static List<cls_Empleados> _lstEmpleado = new List<cls_Empleados>
    {
        new cls_Empleados { iCedula = 123456789, sNombreCompleto = "Pedro Pascal", 
                            dtmFechaNacimiento = DateTime.Parse("10/10/2000"), dtmFechaIngreso = DateTime.Now, 
                            sLateralidad = "Diestro", fSalarioHora = 1800}
    };
        #endregion

        #region MÉTODOS EMPLEADOS

        public List<cls_Empleados> GetAll()
        {
            return _lstEmpleado;
        }
        public cls_Empleados GetById(int id)
        {
            return _lstEmpleado.FirstOrDefault(v => v.iCedula == id);
        }
        public List<cls_Empleados> ConsultaFiltrada(cls_Empleados P_Entidad)
        {
            List<cls_Empleados> lstResultado = new List<cls_Empleados>();
            try
            {
                if (!string.IsNullOrEmpty(P_Entidad.iCedula.ToString()))
                {
                    lstResultado = _lstEmpleado.Where(doc => doc.iCedula == P_Entidad.iCedula).OrderBy(orden => orden.sNombreCompleto).ToList();
                }
                else if (!string.IsNullOrEmpty(P_Entidad.sNombreCompleto))
                {
                    lstResultado = _lstEmpleado.Where(doc => doc.sNombreCompleto.Equals(P_Entidad.sNombreCompleto)).OrderBy(orden => orden.sNombreCompleto).ToList();
                }
                else
                {
                    lstResultado = _lstEmpleado.OrderBy(orden => orden.sNombreCompleto).ToList(); // Devuelve todo ordenado por nombre
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstResultado;
        }
        public void Add(cls_Empleados P_Entidad)
        {
            //P_Entidad.iCedula = _lstEmpleado.Max(v => v.iCedula) + 1;
            _lstEmpleado.Add(P_Entidad);
        }
        public void Update(cls_Empleados P_Entidad)
        {
            var existingEmpleado = GetById(P_Entidad.iCedula);
            if (existingEmpleado != null)
            {
                existingEmpleado.sNombreCompleto = P_Entidad.sNombreCompleto;
                existingEmpleado.dtmFechaNacimiento = P_Entidad.dtmFechaNacimiento;
                existingEmpleado.sLateralidad = P_Entidad.sLateralidad;
                existingEmpleado.dtmFechaIngreso = P_Entidad.dtmFechaIngreso;
                existingEmpleado.fSalarioHora = P_Entidad.fSalarioHora;
            }
        }
        public void Delete(int id)
        {
            var empleado = GetById(id);
            if (empleado != null)
            {
                _lstEmpleado.Remove(empleado);
            }
        }
        #endregion
    }
}
