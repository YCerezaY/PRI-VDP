using SWLNVDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Venta_PListaVentas : System.Web.UI.Page
{
    public static List<EVVentaCompleja> lstVentas = new List<EVVentaCompleja>();
    public CVentaCompleja cVentaC = new CVentaCompleja();
    public CVenta cVenta = new CVenta();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CargarLista();
            Cargarddl();
        }

    }
    private void CargarLista()
    {
        lstVentas = cVentaC.Obtener_VVenta_O_Compleja().ToList();
        gvListaVentas.DataSource = lstVentas;
        gvListaVentas.DataBind();
    }
    protected void gvListaVentas_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int index = Convert.ToInt32(e.CommandArgument);
        string CodigoVenta = gvListaVentas.DataKeys[index].Value.ToString();
        if (e.CommandName == "btnEliminar")
        {
            cVenta.Eliminar_VVenta_E(CodigoVenta);
            CargarLista();
        }
    }

    protected void btnCrear_Click(object sender, EventArgs e)
    {
        Response.Redirect("PCrearVenta.aspx");
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        lstVentas = new List<EVVentaCompleja>();
        int opcion = ddlFiltros.SelectedIndex;
        switch (opcion)
        {
            case 1:
                List<EVCliente> lstCliente = new List<EVCliente>();
                CCliente cCliente = new CCliente();
                lstCliente = cCliente.Obtener_VCliente_O_ApellidoPaternoCliente(txbFiltro.Text);

                foreach (var codigo in lstCliente)
                {
                    EVCliente eVCliente = new EVCliente();
                    eVCliente.CodigoCliente = codigo.CodigoCliente;
                    if (lstCliente.Count == 1)
                        CargarListaPorCliente(eVCliente.CodigoCliente);
                    else
                        CargarListaPorClienteMuchos(eVCliente.CodigoCliente);
                }
                break;
            case 2:
                List<EVEmpleado> lstEmpleado = new List<EVEmpleado>();
                CEmpleado cEmpleado = new CEmpleado();
                
                lstEmpleado = cEmpleado.Obtener_VEmpleado_O_ApellidoPaternoEmpleado(txbFiltro.Text);

                foreach (var codigo in lstEmpleado)
                {
                    EVEmpleado eVEmpleado = new EVEmpleado();
                    eVEmpleado.CodigoEmpleado = codigo.CodigoEmpleado;
                    if (lstEmpleado.Count == 1)
                        CargarListaPorEmpleado(eVEmpleado.CodigoEmpleado);
                    else
                        CargarListaPorEmpleadoMuchos(eVEmpleado.CodigoEmpleado);
                }
                break;
            case 3:
                List<EVProducto> lstProducto = new List<EVProducto>();
                CProducto cProducto = new CProducto();
                EVProducto eVProducto;
                lstProducto = cProducto.Obtener_VProducto_O_NombreProducto(txbFiltro.Text);

                foreach (var codigo in lstProducto)
                {
                    eVProducto = new EVProducto();
                    eVProducto.CodigoProducto = codigo.CodigoProducto;

                    CargarListaPorProducto(eVProducto.CodigoProducto);
                }
                break;
        }
    }
    protected void btnRestaurar_Click(object sender, EventArgs e)
    {
        CargarLista();
    }

    private void CargarListaPorClienteMuchos(string CodigoCliente)
    {
        var ventas = cVentaC.Obtener_VVenta_O_Compleja_CodigoCliente(CodigoCliente).ToList();
        lstVentas.AddRange(ventas);
        gvListaVentas.DataSource = lstVentas;
        gvListaVentas.DataBind();

    }
    private void CargarListaPorCliente(string CodigoCliente)
    {
        lstVentas = cVentaC.Obtener_VVenta_O_Compleja_CodigoCliente(CodigoCliente).ToList();
        gvListaVentas.DataSource = lstVentas;
        gvListaVentas.DataBind();

    }
    private void CargarListaPorEmpleadoMuchos(string CodigoEmpleado)
    {
        var ventas = lstVentas = cVentaC.Obtener_VVenta_O_Compleja_CodigoEmpleado(CodigoEmpleado).ToList();
        lstVentas.AddRange(ventas);
        gvListaVentas.DataSource = lstVentas;
        gvListaVentas.DataBind();

    }
    private void CargarListaPorEmpleado(string CodigoEmpleado)
    {
        lstVentas = cVentaC.Obtener_VVenta_O_Compleja_CodigoEmpleado(CodigoEmpleado).ToList();
        gvListaVentas.DataSource = lstVentas;
        gvListaVentas.DataBind();

    }
    private void CargarListaPorProducto(string CodigoProducto)
    {
        lstVentas = cVentaC.Obtener_VVenta_O_Compleja_CodigoProducto(CodigoProducto).ToList();
        gvListaVentas.DataSource = lstVentas;
        gvListaVentas.DataBind();

    }
    private void Cargarddl()
    {
        ddlFiltros.Items.Add(new ListItem("Seleccione un filtro de Búsqueda", "0"));
        ddlFiltros.Items.Add(new ListItem("Apellido Paterno del Cliente", "1"));
        ddlFiltros.Items.Add(new ListItem("Apellido Paterno del Empleado", "2"));
        ddlFiltros.Items.Add(new ListItem("Nombre del Producto", "3"));
    }
}