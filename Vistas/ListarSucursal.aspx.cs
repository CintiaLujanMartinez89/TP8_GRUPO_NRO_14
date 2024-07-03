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
    public partial class ListarSucursal : System.Web.UI.Page
    {
        NegocioSucursales obj = new NegocioSucursales();
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            if (!Page.IsPostBack)
            {

                Cargar_gvSucursales();

            }

        }


        private void Cargar_gvSucursales()
        {
            gvSucursales.DataSource = obj.ObtenerSuc();
            gvSucursales.DataBind();

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            gvSucursales.DataSource = obj.ObtenerSuc();
            gvSucursales.DataBind();

            txtIdSucu.Text = "";
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            string ID = txtIdSucu.Text;

            gvSucursales.DataSource = obj.BuscarSuc(ID);
            gvSucursales.DataBind();

            txtIdSucu.Text = "";
        }
    }
}