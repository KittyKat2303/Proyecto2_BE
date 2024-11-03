﻿using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class cls_Inventario_BLL
    {
        #region VARIABLE PRIVADA
        public cls_Inventario_DAL Obj_Inventario_DAL = new cls_Inventario_DAL();
        #endregion

        #region MÉTODOS
        public List<cls_Inventario> GetAllValues()
        {
            return Obj_Inventario_DAL.GetAll(); //Llama a los métodos
        }
        public cls_Inventario GetValueById(int id)
        {
            return Obj_Inventario_DAL.GetById(id); //Llama a los métodos
        }
        public List<cls_Inventario> ConsultaFiltrada(cls_Inventario P_Entidad)
        {
            return Obj_Inventario_DAL.ConsultaFiltrada(P_Entidad); //Llama a los métodos
        }
        public void AddValue(cls_Inventario P_Entidad)
        {
            Obj_Inventario_DAL.Add(P_Entidad); //Llama a los métodos
        }
        public void UpdateValue(cls_Inventario P_Entidad)
        {
            Obj_Inventario_DAL.Update(P_Entidad); //Llama a los métodos
        }
        public void DeleteValue(int id)
        {
            Obj_Inventario_DAL.Delete(id); //Llama a los métodos
        }
        #endregion
    }
}
