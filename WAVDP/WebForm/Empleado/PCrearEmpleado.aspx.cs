using SWLNVDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Empleado_PCrearEmpleado : System.Web.UI.Page
{
    CEmpleado cEmpleado = new CEmpleado();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        string c = CGeneracionCodigo.GenerateUniqueId();
        string nombre = txbNombre.Text.Trim();
        string apellidoPaterno = txbApellidoPaterno.Text.Trim();
        string apellidoMaterno = txbApellidoMaterno.Text.Trim();

        if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidoPaterno)
             || string.IsNullOrEmpty(apellidoMaterno))
        {
            Response.Write("<script>alert('No se permiten campos vacíos.');</script>");
        }
        else
        {
            cEmpleado.Insertar_VEmpleado_I(c, nombre, apellidoPaterno, apellidoMaterno);

            txbNombre.Text = "";
            txbApellidoPaterno.Text = "";
            txbApellidoMaterno.Text = "";
        }
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("PListaEmpleados.aspx");
    }
}