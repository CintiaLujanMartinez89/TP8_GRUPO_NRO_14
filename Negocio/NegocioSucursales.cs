using Entidades;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Web.Configuration;

namespace Negocio
{
    public class NegocioSucursales
    {

       
        DAOSucursales obj = new DAOSucursales();
        Sucursales suc = new Sucursales();


        protected void Page_Load(object sender, EventArgs e)
        {
     
        }

        public int EliminarSuc(int id)
        {
            //Validar id existente 

            
           // suc.Id_Sucursal1 = id;
            int op = obj.EliminarSucursal(id);
            if (op == 1)
                return 1;
            else
                return 0;
        }

        public DataTable ObtenerSuc()
        {
            return obj.ObtenerSucursales();
             
        }


        public DataTable ObtenerProv()
        {
            return obj.ObtenerProvincias();

        }

        public int AgregarSuc(string nombre, string descripcion, int idProvincia, string direccion)
        {
           return obj.AgregarSucursal( nombre,  descripcion, idProvincia,  direccion);
        }

        public DataTable BuscarSuc(string idSucursal)
        {
           
            return obj.BuscarSucursal(idSucursal);
        }


    }

}

