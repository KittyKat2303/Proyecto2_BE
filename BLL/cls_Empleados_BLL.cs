﻿using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class cls_Empleados_BLL
    {
        #region VARIABLE PRIVADA
        public cls_Empleados_DAL Obj_Empleados_DAL = new cls_Empleados_DAL();
        #endregion

        #region MÉTODOS
        public List<cls_Empleados> GetAllValues()
        {
            return Obj_Empleados_DAL.GetAll(); //Llama a los métodos
        }
        public cls_Empleados GetValueById(int id)
        {
            return Obj_Empleados_DAL.GetById(id); //Llama a los métodos
        }
        public List<cls_Empleados> ConsultaFiltrada(cls_Empleados P_Entidad)
        {
            return Obj_Empleados_DAL.ConsultaFiltrada(P_Entidad); //Llama a los métodos
        }
        public void AddValue(cls_Empleados P_Entidad)
        {
            Obj_Empleados_DAL.Add(P_Entidad); //Llama a los métodos
        }
        public void UpdateValue(cls_Empleados P_Entidad)
        {
            Obj_Empleados_DAL.Update(P_Entidad); //Llama a los métodos
        }
        public void DeleteValue(int id)
        {
            Obj_Empleados_DAL.Delete(id); //Llama a los métodos
        }
        #endregion
    }
}
