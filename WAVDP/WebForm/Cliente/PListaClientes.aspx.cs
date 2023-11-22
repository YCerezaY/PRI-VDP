using SWLNVDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Cliente_PListaClientes : System.Web.UI.Page
{
    public static List<EVCliente> lstClientes = new List<EVCliente>();
    public CCliente cCliente = new CCliente();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CargarLista();
        }

    }

    private void CargarLista()
    {
        lstClientes = cCliente.Obtener_VCliente_O_Todo().ToList();
        gvListaClientes.DataSource = lstClientes;
        gvListaClientes.DataBind();
    }
    protected void gvListaClientes_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        string CodigoCliente = gvListaClientes.DataKeys[index].Value.ToString();
        if (e.CommandName == "btnEditar")
        {
            Response.Redirect("PEditarCliente.aspx?codigo=" + CodigoCliente);
        }
    }

    protected void btnCrear_Click(object sender, EventArgs e)
    {
        Response.Redirect("PCrearCliente.aspx");
    }
    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        CargarFiltrados(txbFiltro.Text);
    }
    protected void btnRestaurar_Click(object sender, EventArgs e)
    {
        CargarLista();
    }
    private void CargarFiltrados(string ApellidoPaterno)
    {
        lstClientes = cCliente.Obtener_VCliente_O_ApellidoPaternoCliente(ApellidoPaterno).ToList();
        gvListaClientes.DataSource = lstClientes;
        gvListaClientes.DataBind();
    }
}