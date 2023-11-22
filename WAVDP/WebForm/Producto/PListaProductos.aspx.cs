using System;
using System.Collections.Generic;
using System.IdentityModel.Metadata;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNVDP;

public partial class WebForm_Productos_ListaProductos : System.Web.UI.Page
{
    public static List<EVProducto> lstProductos = new List<EVProducto>();
    public CProducto cProducto = new CProducto();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CargarLista();
        }

    }
    private void CargarLista()
    {
        lstProductos = cProducto.Obtener_VProducto_O_Todo().ToList();
        gvListaProductos.DataSource = lstProductos;
        gvListaProductos.DataBind();
    }
    protected void gvListaProductos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        string CodigoProducto = gvListaProductos.DataKeys[index].Value.ToString();
        if (e.CommandName == "btnEditar")
        {
            Response.Redirect("PEditarProducto.aspx?codigo=" + CodigoProducto);
        }
        if (e.CommandName == "btnEliminar")
        {
            cProducto.Eliminar_VProducto_E(CodigoProducto);
            CargarLista();
        }
    }

    protected void btnCrear_Click(object sender, EventArgs e)
    {
        Response.Redirect("PCrearProducto.aspx");
    }
    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        CargarFiltrados(txbFiltro.Text);
    }
    protected void btnRestaurar_Click(object sender, EventArgs e)
    {
        CargarLista();
    }
    private void CargarFiltrados(string NombreProducto)
    {
        lstProductos = cProducto.Obtener_VProducto_O_NombreProducto(NombreProducto).ToList();
        gvListaProductos.DataSource = lstProductos;
        gvListaProductos.DataBind();
    }
}