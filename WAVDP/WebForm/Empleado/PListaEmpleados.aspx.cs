using SWLNVDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Empleado_PListaEmpleados : System.Web.UI.Page
{
    public static List<EVEmpleado> lstEmpleados = new List<EVEmpleado>();
    public CEmpleado cEmpleado = new CEmpleado();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CargarLista();
        }

    }
    private void CargarLista()
    {
        lstEmpleados = cEmpleado.Obtener_VEmpleado_O_Todo().ToList();
        gvListaEmpleados.DataSource = lstEmpleados;
        gvListaEmpleados.DataBind();
    }
    protected void gvListaEmpleados_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        string CodigoEmpleado = gvListaEmpleados.DataKeys[index].Value.ToString();
        if (e.CommandName == "btnEditar")
        {
            Response.Redirect("PEditarEmpleado.aspx?codigo=" + CodigoEmpleado);
        }
        if (e.CommandName == "btnEliminar")
        {
            cEmpleado.Eliminar_VEmpleado_E(CodigoEmpleado);
            CargarLista();
        }
    }

    protected void btnCrear_Click(object sender, EventArgs e)
    {
        Response.Redirect("PCrearEmpleado.aspx");
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
        lstEmpleados = cEmpleado.Obtener_VEmpleado_O_ApellidoPaternoEmpleado(ApellidoPaterno).ToList();
        gvListaEmpleados.DataSource = lstEmpleados;
        gvListaEmpleados.DataBind();
    }

}