using SWLNVDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Cliente_PCrearCliente : System.Web.UI.Page
{
    CCliente cCliente = new CCliente();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        string codigo = CGeneracionCodigo.GenerateUniqueId();
        string nombre = txbNombre.Text.Trim();
        string apellidoPaterno = txbApellidoPaterno.Text.Trim();
        string apellidoMaterno = txbApellidoMaterno.Text.Trim();
        string direccion = txbDireccion.Text.Trim();
        string telefono = txbTelefono.Text.Trim();

        if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidoPaterno)
             || string.IsNullOrEmpty(apellidoMaterno) || string.IsNullOrEmpty(direccion)
             || string.IsNullOrEmpty(telefono))
        {
            Response.Write("<script>alert('No se permiten campos vacíos.');</script>");
        }
        else
        {
            cCliente.Insertar_VCliente_I(codigo, nombre, apellidoPaterno, apellidoMaterno, direccion, int.Parse(telefono));

            txbNombre.Text = "";
            txbApellidoPaterno.Text = "";
            txbApellidoMaterno.Text = "";
            txbDireccion.Text = "";
            txbTelefono.Text = "";
        }

    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("PListaClientes.aspx");
    }
}