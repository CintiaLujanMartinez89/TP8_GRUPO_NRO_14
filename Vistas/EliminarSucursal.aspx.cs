using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;

namespace Vistas
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        NegocioSucursales obj = new NegocioSucursales();
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

            int fila = obj.EliminarSuc(Convert.ToInt32(txtbIdSuc.Text));

            if (fila == 1)
            {
                lblExito.Text = "Sucursal eliminada con exito!";
            }
            else { lblExito.Text = "La Sucursal ingresada no existe"; }

            txtbIdSuc.Text = "";
        }

    }
}