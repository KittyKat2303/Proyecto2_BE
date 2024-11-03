﻿using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class cls_Clientes_BLL
    {
        #region VARIABLE PRIVADA
        public cls_Clientes_DAL Obj_Clientes_DAL = new cls_Clientes_DAL();
        #endregion

        #region MÉTODOS
        public List<cls_Clientes> GetAllValues()
        {
            return Obj_Clientes_DAL.GetAll(); //Llama a los métodos
        }
        public cls_Clientes GetValueById(int id)
        {
            return Obj_Clientes_DAL.GetById(id); //Llama a los métodos
        }
        public List<cls_Clientes> ConsultaFiltrada(cls_Clientes P_Entidad)
        {
            return Obj_Clientes_DAL.ConsultaFiltrada(P_Entidad);
        }
        public void AddValue(cls_Clientes P_Entidad)
        {
            Obj_Clientes_DAL.Add(P_Entidad); //Llama a los métodos
        }
        public void UpdateValue(cls_Clientes P_Entidad)
        {
            Obj_Clientes_DAL.Update(P_Entidad); //Llama a los métodos
        }
        public void DeleteValue(int id)
        {
            Obj_Clientes_DAL.Delete(id); //Llama a los métodos
        }
        #endregion
    }
}
