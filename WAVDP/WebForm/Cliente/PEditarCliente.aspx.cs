using SWLNVDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Cliente_PEditarCliente : System.Web.UI.Page
{
    CCliente cCliente = new CCliente();
    EVCliente eVCliente = new EVCliente();
    private string CodigoCliente;
    protected void Page_Load(object sender, EventArgs e)
    {
        CodigoCliente = Request.QueryString["codigo"];
        if(!IsPostBack)
        {
            CargarDatos();
        }
    }
    private void CargarDatos()
    {
        eVCliente = cCliente.Obtener_VCliente_O_CodigoCliente(CodigoCliente);
        txbNombre.Text = eVCliente.NombreCliente;
        txbApellidoPaterno.Text = eVCliente.ApellidoPaternoCliente;
        txbApellidoMaterno.Text = eVCliente.ApellidoMaternoCliente;
        txbDireccion.Text = eVCliente.DireccionCliente;
        txbTelefono.Text = eVCliente.TelefonoCliente.ToString();
    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txbNombre.Text) || string.IsNullOrEmpty(txbApellidoPaterno.Text)
             || string.IsNullOrEmpty(txbApellidoMaterno.Text) || string.IsNullOrEmpty(txbDireccion.Text)
             || string.IsNullOrEmpty(txbTelefono.Text))
        {
            Response.Write("<script>alert('No se permiten campos vacíos.');</script>");
        }
        else
        {
            cCliente.Actualizar_VCliente_A(CodigoCliente, txbNombre.Text, txbApellidoPaterno.Text, txbApellidoMaterno.Text, txbDireccion.Text, int.Parse(txbTelefono.Text));
            Response.Redirect("PListaClientes.aspx");
        }
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("PListaClientes.aspx");
    }
}