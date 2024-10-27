using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class cls_product_BLL
    {
        #region VARIABLE PRIVADA
        private cls_product_DAL Obj_Product_DAL = new cls_product_DAL();
        #endregion

        public List<cls_product> GetAllValues()
        {
            return Obj_Product_DAL.GetAll();
        }

        #region MÉTODOS
        public cls_product GetValueById(int id)
        {
            return Obj_Product_DAL.GetById(id);
        }
        public void AddValue(cls_product Obj_Product)
        {
            Obj_Product_DAL.Add(Obj_Product);
        }
        public void UpdateValue(cls_product Obj_Product)
        {
            Obj_Product_DAL.Update(Obj_Product);
        }
        public void DeleteValue(int id)
        {
            Obj_Product_DAL.Delete(id);
        }

        #endregion
    }
}
