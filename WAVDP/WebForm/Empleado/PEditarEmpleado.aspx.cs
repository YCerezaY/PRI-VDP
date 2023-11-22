using SWLNVDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Empleado_PEditarEmpleado : System.Web.UI.Page
{
    CEmpleado cEmpleado = new CEmpleado();
    EVEmpleado eVEmpleado = new EVEmpleado();
    private string CodigoEmpleado;
    protected void Page_Load(object sender, EventArgs e)
    {
        CodigoEmpleado = Request.QueryString["codigo"];
        if (!IsPostBack)
        {
            CargarDatos();
        }
    }
    private void CargarDatos()
    {
        eVEmpleado = cEmpleado.Obtener_VEmpleado_O_CodigoEmpleado(CodigoEmpleado);
        txbNombre.Text = eVEmpleado.NombreEmpleado;
        txbApellidoPaterno.Text = eVEmpleado.ApellidoPaternoEmpleado;
        txbApellidoMaterno.Text = eVEmpleado.ApellidoMaternoEmpleado;
    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txbNombre.Text) || string.IsNullOrEmpty(txbApellidoPaterno.Text)
             || string.IsNullOrEmpty(txbApellidoMaterno.Text))
        {
            Response.Write("<script>alert('No se permiten campos vacíos.');</script>");
        }
        else
        {
            cEmpleado.Actualizar_VEmpleado_A(CodigoEmpleado, txbNombre.Text.Trim(), txbApellidoPaterno.Text.Trim(), txbApellidoMaterno.Text.Trim());
            Response.Redirect("PListaEmpleados.aspx");
        }
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("PListaEmpleados.aspx");
    }
}