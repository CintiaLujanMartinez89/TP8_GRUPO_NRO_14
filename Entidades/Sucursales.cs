using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursales
    {
      

        private int Id_Sucursal;
        private string NombreSucursal;
        private string DescripcionSucursal;
        private int Id_HorarioSucursal;
        private int id_ProvinciaSursal;
        private string DireccionSucursal;
        private string URL_Imagen_Sucursal;

        //GETS Y SETS
        public int Id_Sucursal1 { get => Id_Sucursal; set => Id_Sucursal = value; }
        public string NombreSucursal1 { get => NombreSucursal; set => NombreSucursal = value; }
        public string DescripcionSucursal1 { get => DescripcionSucursal; set => DescripcionSucursal = value; }

       
        public int Id_HorarioSucursal1 { get => Id_HorarioSucursal; set => Id_HorarioSucursal = value; }

 

        public int Id_ProvinciaSursal { get => id_ProvinciaSursal; set => id_ProvinciaSursal = value; }
        public string DireccionSucursal1 { get => DireccionSucursal; set => DireccionSucursal = value; }

       

        public string URL_Imagen_Sucursal1 { get => URL_Imagen_Sucursal; set => URL_Imagen_Sucursal = value; }

      

    }
}
